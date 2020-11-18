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

        public LibroDiarioForm()
        {
            InitializeComponent();

            partidasControlles = new PartidasController();

            this.lista = this.partidasControlles.getList(1);

            foreach(Partida partida in lista)
            {
                tableLibroDiario.Rows.Add(partida.Fecha, "Partida " + partida.N_Partida, "", "");

                foreach(CuentaPartida cuentaPartida in partida.ListaCuentasPartida)
                {
                    tableLibroDiario.Rows.Add("", cuentaPartida.Nombre, cuentaPartida.Debe, cuentaPartida.Haber);
                }

                tableLibroDiario.Rows.Add("", partida.Detalle, "", "");
            }

        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            agregarPartidaForm = new AgregarPartidaForm();
            this.Parent.Parent.Parent.Visible = false;
            agregarPartidaForm.ShowDialog();
            this.Parent.Parent.Parent.Visible = true;
        }
    }
}
