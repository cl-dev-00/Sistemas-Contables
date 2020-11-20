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
        private int idLibroIdario;
        private string accion;

        public LibroDiarioForm(LibroDiario libroDiario)
        {
            InitializeComponent();

            idLibroIdario = libroDiario.IdLibroDiario;
            lblPeriodo.Text = libroDiario.Periodo;

            this.partidasControlles = new PartidasController();

            llenarTabla();

        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            accion = "ingresar";
            agregarPartidaForm = new AgregarPartidaForm(this.partidasControlles, idLibroIdario, numeroPartidas, accion);
            this.Parent.Parent.Parent.Visible = false;
            agregarPartidaForm.ShowDialog();
            this.Parent.Parent.Parent.Visible = true;
            llenarTabla();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {

            int indexFila = tableLibroDiario.CurrentRow.Index;

            string celdaPartida = tableLibroDiario.Rows[indexFila].Cells[1].Value.ToString();

            if (celdaPartida.Contains("Partida"))
            {
                string[] partidaString = celdaPartida.Split(' ');
                int numeroPartida = Convert.ToInt32(partidaString[2]);


                accion = "editar";
                agregarPartidaForm = new AgregarPartidaForm(this.partidasControlles, idLibroIdario, numeroPartida, accion);
                this.Parent.Parent.Parent.Visible = false;
                agregarPartidaForm.ShowDialog();
                this.Parent.Parent.Parent.Visible = true;
                llenarTabla();

            }
            else
            {
                MessageBox.Show("Para editar una partida Selecciona la fila que corresponda\n a la partidano, no seleccione una fila de cuenta o detalle", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }


        private void btnEliminar_Click(object sender, EventArgs e)
        {
            int indexFila = tableLibroDiario.CurrentRow.Index;

            string celdaPartida = tableLibroDiario.Rows[indexFila].Cells[1].Value.ToString();

            if (celdaPartida.Contains("Partida"))
            {
                string[] partidaString = celdaPartida.Split(' ');
                int numeroPartida = Convert.ToInt32(partidaString[2]);


                partidasControlles.delete(numeroPartida, idLibroIdario);

                llenarTabla();

            }
            else
            {
                MessageBox.Show("Para eliminar una partida Selecciona la fila que corresponda\n a la partida, no seleccione una fila de cuenta o detalle", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        //el metodo llena la tabla del libro diario
        public void llenarTabla()
        {
            if (tableLibroDiario.Rows.Count > 0 && lista.Count > 0)
            {
                tableLibroDiario.Rows.Clear();
                lista.Clear();
            }

            lista = partidasControlles.getList(idLibroIdario);

            numeroPartidas = lista.Count;

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
