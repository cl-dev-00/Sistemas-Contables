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
        private double debe = 0;
        private double haber = 0;
        private bool exit = false;

        public BalanceDeComprobacionForm(LibroDiario libroDiario)
        {
            InitializeComponent();

            idLibroDiario = libroDiario.IdLibroDiario;

            lblPeriodo.Text = libroDiario.Periodo;

            balanceComprobacionController = new BalanceComprobacionController();

            llenarTabla();

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
                }

            }

        }

        private void llenarCuentas(CuentaPartida cuenta)
        {
            listaCuentaPartidas = balanceComprobacionController.getListCuentasPartidas(cuenta.Codigo, idLibroDiario);

            foreach (CuentaPartida cuentaPartida in listaCuentaPartidas)
            {
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
                            tableBalanceDeComprobacion.Rows.Add(cuentaPartida.IdPartida, cuentaPartida.Codigo, cuentaPartida.Nombre, cuentaPartida.Debe, 0);
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
                            tableBalanceDeComprobacion.Rows.Add(cuentaPartida.IdPartida, cuentaPartida.Codigo, cuentaPartida.Nombre, 0, cuentaPartida.Haber);
                        }
                    }
                }
                else if (tableBalanceDeComprobacion.Rows.Count > 1)
                {

                    for (int i = 0; i < tableBalanceDeComprobacion.Rows.Count; i++)
                    {
                        if (tableBalanceDeComprobacion.Rows[i].Cells["ColumnCodigo"].Value.ToString() == cuentaPartida.Codigo)
                        {
                            debe = Convert.ToDouble(tableBalanceDeComprobacion.Rows[i].Cells["ColumnDeudor"].Value);
                            haber = Convert.ToDouble(tableBalanceDeComprobacion.Rows[i].Cells["ColumnAcreedor"].Value);

                            if (cuenta.TipoSaldo == "Deudor")
                            {
                                if (cuentaPartida.Haber <= 0)
                                {
                                    debe += cuentaPartida.Debe;

                                    tableBalanceDeComprobacion.Rows[i].Cells["ColumnDeudor"].Value = debe;
                                }
                                else if (cuentaPartida.Haber > 0)
                                {
                                    debe += 0 - cuentaPartida.Haber;

                                    tableBalanceDeComprobacion.Rows[i].Cells["ColumnAcreedor"].Value = debe;
                                }
                            }
                            else if (cuenta.TipoSaldo == "Acreedor")
                            {
                                if (cuentaPartida.Debe <= 0)
                                {
                                    haber += cuentaPartida.Haber;

                                    tableBalanceDeComprobacion.Rows[i].Cells["ColumnDeudor"].Value = haber;
                                }
                                else if (cuentaPartida.Debe > 0)
                                {
                                    haber += 0 - cuentaPartida.Debe;

                                    tableBalanceDeComprobacion.Rows[i].Cells["ColumnAcreedor"].Value = haber;
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
                                tableBalanceDeComprobacion.Rows.Add(cuentaPartida.IdPartida, cuentaPartida.Codigo, cuentaPartida.Nombre, cuentaPartida.Debe, 0);
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
                                tableBalanceDeComprobacion.Rows.Add(cuentaPartida.IdPartida, cuentaPartida.Codigo, cuentaPartida.Nombre, 0, cuentaPartida.Haber);
                            }
                        }

                    }

                }

            }
        }


    }

}
