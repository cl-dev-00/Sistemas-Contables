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
    public partial class LibroMayorForm : Form
    {
        private LibroMayorController libroMayorController;
        private List<string> listaCodigos;
        private List<Partida> listaPartidas;
        private Partida partida;
        private string nivel3;

        public LibroMayorForm(LibroDiario libroDiario)
        {
            InitializeComponent();

            lblPeriodo.Text = libroDiario.Periodo;

            libroMayorController = new LibroMayorController();

            llenarTablaLibroMayor(libroDiario.IdLibroDiario);

        }

        public void llenarTablaLibroMayor(int idLibroDiario)
        {
            if(tableLibroMayor.Rows.Count > 0)
            {
                tableLibroMayor.Rows.Clear();
            }

            nivel3 = "";
            double totalMontos = 0;

            listaCodigos = libroMayorController.getListCodigos(idLibroDiario);

            foreach(string codigo in listaCodigos)
            {
                for(int i = 0; i < 4; i++) 
                {
                    nivel3 += codigo[i];
                }

                partida = libroMayorController.getPartida(nivel3);

                if (partida != null)
                {
                    listaPartidas = libroMayorController.getListPartida(nivel3, idLibroDiario);


                    if (tableLibroMayor.Rows.Count > 0)
                    {
                        int index = 0;
                        bool existe = false; //existe verifica que no halla dos cuentas duplicadas en la tabla

                        while (index < tableLibroMayor.Rows.Count)
                        {
                            if (tableLibroMayor.Rows[index].Cells["ColumnCuenta"].Value.ToString() == partida.ListaCuentasPartida[0].Nombre)
                            {
                                existe = true;
                                break;
                            }

                            index++;
                        }


                        if (!existe)
                        {
                            tableLibroMayor.Rows.Add("", partida.ListaCuentasPartida[0].Nombre, "", "", "");

                            llenarRegistros(totalMontos);
                        }

                    }
                    else
                    {

                        tableLibroMayor.Rows.Add("", partida.ListaCuentasPartida[0].Nombre, "", "", "");

                        llenarRegistros(totalMontos);
                    }
                }

                nivel3 = "";

            }

        }

        // el metodo llena la tabla de los registros de la cuentas
        public void llenarRegistros(double totalMontos)
        {
            foreach (Partida partidaAux in listaPartidas)
            {
                if (!string.IsNullOrEmpty(tableLibroMayor.Rows[tableLibroMayor.Rows.Count - 1].Cells["ColumnTotales"].Value.ToString()))
                {
                    totalMontos = Convert.ToDouble(tableLibroMayor.Rows[tableLibroMayor.Rows.Count - 1].Cells["ColumnTotales"].Value);
                }
                else
                {
                    totalMontos = 0;
                }

                double total = 0;

                if (partida.ListaCuentasPartida[0].TipoSaldo == "Deudor")
                {
                    total = partidaAux.ListaCuentasPartida[0].Debe - partidaAux.ListaCuentasPartida[0].Haber + totalMontos;

                    total = Math.Abs(total);

                    tableLibroMayor.Rows.Add(partidaAux.Fecha, partidaAux.Detalle, partidaAux.ListaCuentasPartida[0].Debe, partidaAux.ListaCuentasPartida[0].Haber, total);

                }
                else if (partida.ListaCuentasPartida[0].TipoSaldo == "Acreedor")
                {
                    total = partidaAux.ListaCuentasPartida[0].Haber - partidaAux.ListaCuentasPartida[0].Debe + totalMontos;

                    total = Math.Abs(total);

                    tableLibroMayor.Rows.Add(partidaAux.Fecha, partidaAux.Detalle, partidaAux.ListaCuentasPartida[0].Debe, partidaAux.ListaCuentasPartida[0].Haber, total);
                }

            }

            if(listaPartidas.Count > 0)
            {
                listaPartidas.Clear();
            }
        }

    }
}
