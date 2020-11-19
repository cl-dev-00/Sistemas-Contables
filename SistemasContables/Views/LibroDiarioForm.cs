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
    public partial class LibroDiarioForm : Form
    {
        private AgregarPartidaForm agregarPartidaForm;
        private PartidasController partidasControlles;
        private List<Partida> lista;
        private int numeroPartidas;
        private int libroIdario = 1;

        public LibroDiarioForm()
        {
            InitializeComponent();

            this.partidasControlles = new PartidasController();

            llenarTabla();

        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            agregarPartidaForm = new AgregarPartidaForm(this.partidasControlles,libroIdario ,numeroPartidas);
            this.Parent.Parent.Parent.Visible = false;
            agregarPartidaForm.ShowDialog();
            this.Parent.Parent.Parent.Visible = true;
            llenarTabla();
        }

        //el metodo llena la tabla del libro diario
        public void llenarTabla()
        {
            if(this.tableLibroDiario.Rows.Count > 0 && this.lista.Count > 0)
            {
                this.tableLibroDiario.Rows.Clear();
                this.lista.Clear();
            }

            this.lista = this.partidasControlles.getList(this.libroIdario);

            this.numeroPartidas = lista.Count;

            foreach (Partida partida in lista)
            {
                tableLibroDiario.Rows.Add(partida.Fecha, "Partida No " + partida.N_Partida, "", "");

                foreach (CuentaPartida cuentaPartida in partida.ListaCuentasPartida)
                {
                    tableLibroDiario.Rows.Add("", cuentaPartida.Nombre, cuentaPartida.Debe, cuentaPartida.Haber);
                }

                tableLibroDiario.Rows.Add("", partida.Detalle, "", "");
            }

        }

    }
}
