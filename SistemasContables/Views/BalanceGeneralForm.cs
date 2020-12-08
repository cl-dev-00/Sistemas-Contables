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
        private List<CuentaPartida> listaCuentas;
        private List<CuentaPartida> listaSaldos;

        //Lo uso para que sea punto ( . ) el separador de decimales, va cuando se hace .ToString("", nfi)
        private NumberFormatInfo formatoDecimales = new CultureInfo("en-US", false).NumberFormat;
        double totalActivos = 0, totalPasivos = 0, totalPatrimonio = 0;

        public BalanceGeneralForm(LibroDiario libroDiario, double impuestos_por_pagar, double reserva_legal, double utilidad_neta)
        {
            InitializeComponent();

            lblPeriodo.Text = libroDiario.Periodo;

            balanceGeneralController = new BalanceGeneralController();

            llenarTabla(libroDiario, impuestos_por_pagar, reserva_legal, utilidad_neta);
        }
        private void llenarTabla(LibroDiario libroDiario, double impuestos_por_pagar, double reserva_legal, double utilidad_neta)
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

                        tableActivos.Rows.Add(cuenta.Nombre, "", "");

                        llenarCuentas(libroDiario.IdLibroDiario, cuenta, impuestos_por_pagar, reserva_legal, utilidad_neta);
                    }
                }
            }
        }

        private void llenarCuentas(int idLibroDiario, CuentaPartida cuenta, double impuestos_por_pagar, double reserva_legal, double utilidad_neta)
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
                    }
                    else if (cuentaPartida.TipoSaldo == "Acreedor")
                    {
                        saldoPorCuenta = saldoHaber - saldoDebe;
                    }

                    saldoCuentaMayor += saldoPorCuenta;
                    tableActivos.Rows.Add(cuentaPartida.Nombre, redondear(Math.Round(saldoPorCuenta, 2)), "");
                }
            }

            if (cuenta.Codigo == "1")
            {
                tableActivos.Rows.Add("Total " + cuenta.Nombre, saldoCuentaMayor);
                totalActivos = saldoCuentaMayor;
                lblActivos.Text = "Total Activos = $" + redondear(Math.Round(totalActivos, 2));
            }
            else if (cuenta.Codigo == "2")
            {
                tableActivos.Rows.Add("Impuestos por Pagar", redondear(Math.Round(impuestos_por_pagar, 2)));
                totalPasivos = saldoCuentaMayor;
            }
            else if (cuenta.Codigo == "3")
            {
                tableActivos.Rows.Add("Utilidad Neta", redondear(Math.Round(utilidad_neta, 2)));
                tableActivos.Rows.Add("Reserva Legal", redondear(Math.Round(reserva_legal, 2)));
                totalPatrimonio = saldoCuentaMayor;
            }

            double pasivos = totalPasivos + impuestos_por_pagar;
            double capital = totalPatrimonio + reserva_legal + utilidad_neta;

            double pasivos__ = pasivos + capital;
            lblPasivosCapital.Text = "Total Pasivos + Patrimonio = $" + redondear(Math.Round(pasivos__, 2));
        }

        // el metodo retorna un formato #.00 a los decimales de un string
        private string redondear(double cantidad)
        {
            return cantidad.ToString("0.00", formatoDecimales);
        }

    }
}

