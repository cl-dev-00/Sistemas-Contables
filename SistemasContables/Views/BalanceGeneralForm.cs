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
        private List<Cuenta> listaCuentas;
        private List<CuentaPartida> listaSaldos;

        private int idLibroDiario;

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

            lblActivos.Text = "$ " + redondear(TotalActivos());
            lblPasivosCapital.Text = "$ " + redondear(TotalPasivosCapital());
        }
        private void llenarTabla(LibroDiario libroDiario)
        {
            listaCuentas = balanceGeneralController.getListCuentas();
            List<string> codigosp = new List<string>();

            foreach (Cuenta cuenta in listaCuentas)
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

        private void llenarCuentas(int idLibroDiario, Cuenta cuenta)
        {
            listaSaldos = balanceGeneralController.getListSaldos(idLibroDiario, cuenta.Codigo);

            List<string> codigos = new List<string>();

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

                        tableActivos.Rows.Add(cuentaPartida.Nombre, redondear(Math.Round(saldoPorCuenta, 2)), "");
                    }
                    else if (cuentaPartida.TipoSaldo == "Acreedor")
                    {
                        saldoPorCuenta = saldoHaber - saldoDebe;

                        tablePasivosCapital.Rows.Add(cuentaPartida.Nombre, redondear(Math.Round(saldoPorCuenta, 2)), "");
                    }

                }
            }

            if (cuenta.Codigo == "2")
            {
                tablePasivosCapital.Rows.Add("Impuestos por Pagar", redondear(Math.Round(impuestosPorPagar, 2)));
            }
            else if (cuenta.Codigo == "3")
            {
                tablePasivosCapital.Rows.Add("Utilidad Neta", redondear(Math.Round(utilidadNeta, 2)));
                tablePasivosCapital.Rows.Add("Reserva Legal", redondear(Math.Round(reservaLegal, 2)));
            }


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

        // el metodo retorna la suma de todos los activos
        private double TotalActivos()
        {
            double total = 0;

            for (int i = 0; i < tableActivos.Rows.Count; i++)
            {

                if (!string.IsNullOrEmpty(tableActivos.Rows[i].Cells["ColumnCantidadActivos"].Value.ToString()))
                {
                    total += Convert.ToDouble(tableActivos.Rows[i].Cells["ColumnCantidadActivos"].Value.ToString());
                }

            }

            total = Math.Round(total, 2);

            return total;
        }

        // el metodo retorna la suma de todos los pasivos + patrimonios
        private double TotalPasivosCapital()
        {
            double total = 0;

            for (int i = 0; i < tablePasivosCapital.Rows.Count; i++)
            {

                if (!string.IsNullOrEmpty(tablePasivosCapital.Rows[i].Cells["ColumnCantidadPasivos"].Value.ToString()))
                {
                    total += Convert.ToDouble(tablePasivosCapital.Rows[i].Cells["ColumnCantidadPasivos"].Value.ToString());
                }

            }

            total = Math.Round(total, 2);

            return total;
        }

        // el metodo retorna un formato #.00 a los decimales de un string
        private string redondear(double cantidad)
        {
            return cantidad.ToString("0.00", formatoDecimales);
        }

    }
}

