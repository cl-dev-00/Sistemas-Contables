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
        private NumberFormatInfo nfi = new CultureInfo("en-US", false).NumberFormat;

        private double debe = 0;
        private double haber = 0;

        private bool exit = false;
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
            //string codigoCuentaPrincipal = null;
            //string codigoCuentaSaltar = null;//Tengo hueva poner otro nombre

            foreach (CuentaPartida cuenta in listaCuentas)
            {
                if (cuenta.Codigo == "1" || cuenta.Codigo == "2" || cuenta.Codigo == "3")
                {
                    if (!codigosp.Contains(cuenta.Codigo))
                    {
                        codigosp.Add(cuenta.Codigo);

                        tableBalanceGeneral.Rows.Add(cuenta.Nombre, "", "");

                        llenarCuentas(libroDiario.IdLibroDiario, cuenta, impuestos_por_pagar, reserva_legal, utilidad_neta);
                        
                    }
                }
            }
        }

        private void llenarCuentas(int idLibroDiario, CuentaPartida cuenta, double impuestos_por_pagar, double reserva_legal, double utilidad_neta)
        {
            listaSaldos = balanceGeneralController.getListSaldos(idLibroDiario, cuenta.Codigo);

            double totalActivos = 0, totalPasivos = 0, totalPatrimonio = 0;

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

                    tableBalanceGeneral.Rows.Add("", cuentaPartida.Nombre, saldoPorCuenta, "");
                    saldoCuentaMayor += saldoPorCuenta;

                }
                
            }
            if (cuenta.Codigo == "1")
            {
                totalActivos = saldoCuentaMayor;
            }
            else if (cuenta.Codigo == "2")
            {
                totalPasivos = saldoCuentaMayor;

            }
            else if (cuenta.Codigo == "3")
            {
                totalPatrimonio = saldoCuentaMayor;
            }

            tableBalanceGeneral.Rows.Add("Total de " + cuenta.Nombre, saldoCuentaMayor, "");
       
            label1.Text = "Total Activos = $" + Math.Round(totalActivos, 2).ToString("0.00", nfi);

            double pasivos = totalPasivos + impuestos_por_pagar;
            double capital = totalPatrimonio + reserva_legal + utilidad_neta;

            double pasivos__ = pasivos + capital;
            label2.Text = "Total Pasivos = $" + Math.Round(pasivos__, 2).ToString("0.00", nfi);


        }

    }
}
