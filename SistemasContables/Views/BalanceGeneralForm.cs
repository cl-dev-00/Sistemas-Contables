using SistemasContables.controller;
using SistemasContables.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemasContables.Views
{
    public partial class BalanceGeneralForm : Form
    {
        private BalanceGeneralController balanceGeneralController;
        private EstadoDeResultadosController estadoDeResultadosController;
        private List<CuentaPartida> listaCuentas;
        private List<CuentaPartida> listaSaldos;

        private int idLibroDiario;

        private double totalActivos;
        private double totalPasivos;
        private double totalCapital;
        private double totalPasivosCapital;

        private double impuestosPorPagar = 0;
        private double reservaLegal = 0;
        private double utilidadNeta = 0;

        //Lo uso para que sea punto ( . ) el separador de decimales, va cuando se hace .ToString("", nfi)
        private NumberFormatInfo formatoDecimales = new CultureInfo("en-US", false).NumberFormat;

        public BalanceGeneralForm(LibroDiario libroDiario)
        {
            InitializeComponent();

            idLibroDiario = libroDiario.IdLibroDiario;
            lblPeriodo.Text = libroDiario.Periodo;

            balanceGeneralController = new BalanceGeneralController();
            estadoDeResultadosController =  new EstadoDeResultadosController();

            calcularEstadoDeResultados();
            llenarTabla(libroDiario);

            lblActivos.Text = "$ " + redondear(totalActivos);
            lblPasivosCapital.Text = "$ " + redondear(totalPasivosCapital);
        }
        private void llenarTabla(LibroDiario libroDiario)
        {
            listaCuentas = balanceGeneralController.getListCuentas();
            List<string> codigosp = new List<string>();

            foreach (CuentaPartida cuenta in listaCuentas)
            {
                if (cuenta.Codigo == "1" || cuenta.Codigo == "2" || cuenta.Codigo == "3")
                {
                    if (!codigosp.Contains(cuenta.Codigo))
                    {
                        codigosp.Add(cuenta.Codigo);

                        if (cuenta.TipoSaldo == "Deudor")
                        {
                            tableActivos.Rows.Add(cuenta.Nombre, "", "");
                        }
                        else if (cuenta.TipoSaldo == "Acreedor")
                        {
                            tablePasivosCapital.Rows.Add(cuenta.Nombre, "", "");
                        }

                        llenarCuentas(libroDiario.IdLibroDiario, cuenta);
                    }
                }
            }
        }

        private void llenarCuentas(int idLibroDiario, CuentaPartida cuenta)
        {
            listaSaldos = balanceGeneralController.getListSaldos(idLibroDiario, cuenta.Codigo);

            List<string> codigos = new List<string>();

            double saldoCuentaMayor = 0;

            foreach (CuentaPartida cuentaPartida in listaSaldos)
            {
                double saldoPorCuenta = 0;
                double saldoDebe = 0;
                double saldoHaber = 0;

                if (!codigos.Contains(cuentaPartida.Codigo))
                {
                    codigos.Add(cuentaPartida.Codigo);

                    foreach (CuentaPartida cuentaEvaluada in listaSaldos)
                    {
                        if (cuentaEvaluada.Codigo == cuentaPartida.Codigo)
                        {
                            saldoDebe += cuentaEvaluada.Debe;
                            saldoHaber += cuentaEvaluada.Haber;
                        }
                    }

                    if (cuentaPartida.TipoSaldo == "Deudor")
                    {
                        saldoPorCuenta = saldoDebe - saldoHaber;
                        saldoCuentaMayor += saldoPorCuenta;

                        tableActivos.Rows.Add(cuentaPartida.Nombre, redondear(Math.Round(saldoPorCuenta, 2)), "");
                    }
                    else if (cuentaPartida.TipoSaldo == "Acreedor")
                    {
                        saldoPorCuenta = saldoHaber - saldoDebe;
                        saldoCuentaMayor += saldoPorCuenta;

                        tablePasivosCapital.Rows.Add(cuentaPartida.Nombre, redondear(Math.Round(saldoPorCuenta, 2)), "");
                    }

                }
            }

            if (cuenta.Codigo == "1")
            {
                if(cuenta.TipoSaldo == "Deudor")
                {
                    tableActivos.Rows.Add("Total " + cuenta.Nombre, saldoCuentaMayor);
                } else if(cuenta.TipoSaldo == "Acreedor")
                {
                    tablePasivosCapital.Rows.Add("Total " + cuenta.Nombre, saldoCuentaMayor);
                }

                totalActivos = saldoCuentaMayor;

            }
            else if (cuenta.Codigo == "2")
            {
                tablePasivosCapital.Rows.Add("Impuestos por Pagar", redondear(Math.Round(impuestosPorPagar, 2)));
            
                totalPasivos = saldoCuentaMayor;
            }
            else if (cuenta.Codigo == "3")
            {
                tablePasivosCapital.Rows.Add("Utilidad Neta", redondear(Math.Round(utilidadNeta, 2)));
                tablePasivosCapital.Rows.Add("Reserva Legal", redondear(Math.Round(reservaLegal, 2)));
            
                totalCapital = saldoCuentaMayor;
            }

            totalPasivosCapital = totalPasivos + totalCapital + impuestosPorPagar + reservaLegal + utilidadNeta;

        }

        //el metodo calcula el ompuestosPorPagar, reservaLegal y la utilidadNeta
        private void calcularEstadoDeResultados()
        {
            double ingresos = estadoDeResultadosController.getTotalIngresos(idLibroDiario);
            double costos = estadoDeResultadosController.getTotalCostos(idLibroDiario);
            double gastos = estadoDeResultadosController.getTotalGastos(idLibroDiario);
            double utilidadDeOperacion = 0;
            double utilidadAntesdeimpuestos = 0;

            double ingresosMenosCostos = ingresos - costos;

            utilidadDeOperacion = ingresosMenosCostos - gastos;
            reservaLegal = (ingresosMenosCostos - gastos) * 0.07;
            utilidadAntesdeimpuestos = (utilidadDeOperacion) - ((utilidadDeOperacion) * 0.07);

            if (ingresos < 150000)
            {
                impuestosPorPagar = utilidadAntesdeimpuestos * 0.25;
            }
            else
            {
                impuestosPorPagar = utilidadAntesdeimpuestos * 0.3;
            }

            utilidadNeta = utilidadAntesdeimpuestos - impuestosPorPagar;
        }

        // el metodo retorna un formato #.00 a los decimales de un string
        private string redondear(double cantidad)
        {
            return cantidad.ToString("0.00", formatoDecimales);
        }

    }
}

