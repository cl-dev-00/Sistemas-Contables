using SistemasContables.controller;
using SistemasContables.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemasContables.Views
{
    public partial class BalanceDeComprobacionForm : Form
    {
        private BalanceComprobacionController balanceComprobacionController;
        private List<CuentaPartida> listaCuentas;
        private List<CuentaPartida> listaCuentaPartidas;

        private int idLibroDiario;
        private bool exit = false;

        public BalanceDeComprobacionForm(LibroDiario libroDiario)
        {
            InitializeComponent();

            idLibroDiario = libroDiario.IdLibroDiario;

            lblPeriodo.Text = libroDiario.Periodo;

            balanceComprobacionController = new BalanceComprobacionController();

            llenarTabla();

            lblDeudor.Text = TotalDeudor().ToString();
            lblAcreedor.Text = TotalAcreedor().ToString();
        }

        private void llenarTabla()
        {
            listaCuentas = balanceComprobacionController.getListCuentas();

            foreach(CuentaPartida cuenta in listaCuentas)
            {
                if(cuenta.Codigo == "1" || cuenta.Codigo == "2" || cuenta.Codigo == "31" || cuenta.Codigo == "5" || cuenta.Codigo == "41" || cuenta.Codigo == "42")
                {
                    tableBalanceDeComprobacion.Rows.Add("", "",cuenta.Nombre, "", "");

                    llenarCuentas(cuenta);

                    if (listaCuentaPartidas.Count > 0)
                    {
                        listaCuentaPartidas.Clear();
                    }
                }

            }

        }

        private void llenarCuentas(CuentaPartida cuenta)
        {

            listaCuentaPartidas = balanceComprobacionController.getListCuentasPartidas(cuenta.Codigo, idLibroDiario);

            foreach (CuentaPartida cuentaPartida in listaCuentaPartidas)
            {
                string texto = $"Nombre: {cuenta.Nombre}, Codigo: {cuenta.Codigo} ,Nombre: {cuentaPartida.Nombre}, Tipo Saldo: {cuenta.TipoSaldo}, Debe: ${cuentaPartida.Debe}, Haber: ${cuentaPartida.Haber}";

                if (tableBalanceDeComprobacion.Rows.Count == 1)
                {
                    if (cuenta.TipoSaldo == "Deudor")
                    {
                        if (cuentaPartida.Haber <= 0)
                        {
                            tableBalanceDeComprobacion.Rows.Add(cuentaPartida.IdPartida, cuentaPartida.Codigo, cuentaPartida.Nombre, cuentaPartida.Debe, cuentaPartida.Haber);
                        }
                        else if (cuentaPartida.Haber > 0)
                        {
                            tableBalanceDeComprobacion.Rows.Add(cuentaPartida.IdPartida, cuentaPartida.Codigo, cuentaPartida.Nombre, 0 - cuentaPartida.Haber, 0);
                        }
                    }
                    else if (cuenta.TipoSaldo == "Acreedor")
                    {
                        if (cuentaPartida.Debe <= 0)
                        {
                            tableBalanceDeComprobacion.Rows.Add(cuentaPartida.IdPartida, cuentaPartida.Codigo, cuentaPartida.Nombre, cuentaPartida.Debe, cuentaPartida.Haber);
                        }
                        else if (cuentaPartida.Debe > 0)
                        {
                            tableBalanceDeComprobacion.Rows.Add(cuentaPartida.IdPartida, cuentaPartida.Codigo, cuentaPartida.Nombre, 0, 0 - cuentaPartida.Debe);
                        }
                    }
                }
                else if (tableBalanceDeComprobacion.Rows.Count > 1)
                {

                    for (int i = 0; i < tableBalanceDeComprobacion.Rows.Count; i++)
                    {
                        if (tableBalanceDeComprobacion.Rows[i].Cells["ColumnCodigo"].Value.ToString() == cuentaPartida.Codigo)
                        {

                            if (cuenta.TipoSaldo == "Deudor")
                            {
                                double debe = Convert.ToDouble(tableBalanceDeComprobacion.Rows[i].Cells["ColumnDeudor"].Value);

                                if (cuentaPartida.Haber <= 0)
                                {
                                    tableBalanceDeComprobacion.Rows[i].Cells["ColumnDeudor"].Value = debe += cuentaPartida.Debe;
                                }
                                else if (cuentaPartida.Haber > 0)
                                {
                                    tableBalanceDeComprobacion.Rows[i].Cells["ColumnDeudor"].Value = debe += 0 - cuentaPartida.Haber;
                                }
                            }
                            else if (cuenta.TipoSaldo == "Acreedor")
                            {
                                double haber = Convert.ToDouble(tableBalanceDeComprobacion.Rows[i].Cells["ColumnAcreedor"].Value);

                                if (cuentaPartida.Debe <= 0)
                                {
                                    tableBalanceDeComprobacion.Rows[i].Cells["ColumnAcreedor"].Value = haber += cuentaPartida.Haber;
                                }
                                else if (cuentaPartida.Debe > 0)
                                {
                                    tableBalanceDeComprobacion.Rows[i].Cells["ColumnAcreedor"].Value = haber += 0 - cuentaPartida.Debe;
                                }
                            }

                            exit = true;
                            break;

                        } 
                        else
                        {
                            exit = false;
                        }
                    }

                    if(!exit)
                    {

                        if (cuenta.TipoSaldo == "Deudor")
                        {
                            if (cuentaPartida.Haber <= 0)
                            {
                                tableBalanceDeComprobacion.Rows.Add(cuentaPartida.IdPartida, cuentaPartida.Codigo, cuentaPartida.Nombre,cuentaPartida.Debe, cuentaPartida.Haber);

                            }
                            else if (cuentaPartida.Haber > 0)
                            {
                                tableBalanceDeComprobacion.Rows.Add(cuentaPartida.IdPartida, cuentaPartida.Codigo, cuentaPartida.Nombre, 0 - cuentaPartida.Haber, 0);
                            }
                        }
                        else if (cuenta.TipoSaldo == "Acreedor")
                        {
                            if (cuentaPartida.Debe <= 0)
                            {
                                tableBalanceDeComprobacion.Rows.Add(cuentaPartida.IdPartida, cuentaPartida.Codigo, cuentaPartida.Nombre, cuentaPartida.Debe, cuentaPartida.Haber);
                            }
                            else if (cuentaPartida.Debe > 0)
                            {
                                tableBalanceDeComprobacion.Rows.Add(cuentaPartida.IdPartida, cuentaPartida.Codigo, cuentaPartida.Nombre, 0, 0 - cuentaPartida.Debe);
                            }
                        }

                    }

                }

            }

        }


        // el metodo retorna la suma de todas cuentas en de la columna Debe
        private double TotalDeudor()
        {
            double total = 0;

            for (int i = 0; i < tableBalanceDeComprobacion.Rows.Count; i++)
            {

                if (!string.IsNullOrEmpty(tableBalanceDeComprobacion.Rows[i].Cells["ColumnDeudor"].Value.ToString()))
                {
                    total += Convert.ToDouble(tableBalanceDeComprobacion.Rows[i].Cells["ColumnDeudor"].Value.ToString());
                }

            }

            return total;
        }

        // el metodo retorna la suma de todas cuentas en de la columna Haber
        private double TotalAcreedor()
        {
            double total = 0;

            for (int i = 0; i < tableBalanceDeComprobacion.Rows.Count; i++)
            {

                if (!string.IsNullOrEmpty(tableBalanceDeComprobacion.Rows[i].Cells["ColumnAcreedor"].Value.ToString()))
                {
                    total += Convert.ToDouble(tableBalanceDeComprobacion.Rows[i].Cells["ColumnAcreedor"].Value.ToString());
                }

            }

            return total;
        }

    }

}
