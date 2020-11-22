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
        private PartidasController partidasController;
        private List<Partida> lista;
        private Partida partidaAux = null;

        private int numeroPartidas;
        private int idLibroDiario;
        private string accion;

        public LibroDiarioForm(LibroDiario libroDiario)
        {
            InitializeComponent();

            idLibroDiario = libroDiario.IdLibroDiario;
            lblPeriodo.Text = libroDiario.Periodo;

            partidasController = new PartidasController();

            llenarTabla();
            Totales();

        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            accion = "ingresar";
            agregarPartidaForm = new AgregarPartidaForm(this.partidasController, idLibroDiario, numeroPartidas, accion);
            this.Parent.Parent.Parent.Visible = false;
            agregarPartidaForm.ShowDialog();
            this.Parent.Parent.Parent.Visible = true;
            llenarTabla();
            Totales();
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
                agregarPartidaForm = new AgregarPartidaForm(this.partidasController, idLibroDiario, numeroPartida, accion);
                this.Parent.Parent.Parent.Visible = false;
                agregarPartidaForm.ShowDialog();
                this.Parent.Parent.Parent.Visible = true;
                llenarTabla();
                Totales();

            }
            else
            {
                MessageBox.Show("Para editar una partida Selecciona la fila que corresponda\n a la partidano, no seleccione una fila de cuenta o detalle", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }


        private void btnEliminar_Click(object sender, EventArgs e)
        {
            int indexFila = tableLibroDiario.CurrentRow.Index;

            string celdaPartida = tableLibroDiario.Rows[indexFila].Cells["ColumnDetalle"].Value.ToString();

            if (celdaPartida.Contains("Partida"))
            {
                string[] partidaString = celdaPartida.Split(' ');
                int numeroPartida = Convert.ToInt32(partidaString[2]);


                partidasController.delete(numeroPartida, idLibroDiario);

                llenarTabla();
                Totales();
            }
            else
            {
                MessageBox.Show("Para eliminar una partida Selecciona la fila que corresponda\n a la partida, no seleccione una fila de cuenta o detalle", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnAjusteIva_Click(object sender, EventArgs e)
        {
            int numeroPartidaAux = numeroPartidas;

            double totalDebitoDebe = 0;
            double totalDebitoHaber = 0;
            double totalCreditoDebe = 0;
            double totalCreditoHaber = 0;
            double totalDebito = 0;
            double totalCredito = 0;
            bool IVAremanente = false;
            bool IVAimpuesto = false;


            for (int i = 0; i < tableLibroDiario.Rows.Count; i++)
            {

                if (tableLibroDiario.Rows[i].Cells["ColumnDetalle"].Value.ToString() == "Ajuste de IVA")
                {
                    partidasController.delete(numeroPartidas, idLibroDiario);
                    numeroPartidaAux--;
                    llenarTabla();
                }

            }

            for (int i = 0; i < tableLibroDiario.Rows.Count; i++)
            {

                if (tableLibroDiario.Rows[i].Cells["ColumnDetalle"].Value.ToString() == "Debito Fiscal IVA")
                {
                    totalDebitoDebe += Convert.ToDouble(tableLibroDiario.Rows[i].Cells["ColumnDebe"].Value.ToString());
                    totalDebitoHaber += Convert.ToDouble(tableLibroDiario.Rows[i].Cells["ColumnHaber"].Value.ToString());
                }
                else if (tableLibroDiario.Rows[i].Cells["ColumnDetalle"].Value.ToString() == "Credito Fiscal IVA")
                {
                    totalCreditoDebe += Convert.ToDouble(tableLibroDiario.Rows[i].Cells["ColumnDebe"].Value.ToString());
                    totalCreditoHaber += Convert.ToDouble(tableLibroDiario.Rows[i].Cells["ColumnHaber"].Value.ToString());
                } 

            }

            //ahora vamos a realizar las T para el Debito Fiscal IVA y Credito Fiscal Iva
            if (totalDebitoDebe > totalDebitoHaber)
            {
                totalDebito = totalDebitoDebe - totalDebitoHaber;
            }
            if (totalDebitoDebe < totalDebitoHaber)
            {
                totalDebito = totalDebitoHaber - totalDebitoDebe;
            }

            if (totalCreditoDebe > totalCreditoHaber)
            {
                totalCredito = totalCreditoDebe - totalCreditoHaber;
            }
            if (totalCreditoDebe < totalCreditoHaber)
            {
                totalCredito = totalCreditoHaber - totalCreditoDebe;
            }

            if(totalDebito > 0 || totalCredito > 0)
            {
                double remanente = 0.0;
                double impuesto = 0.0;

                if (totalCredito > totalDebito)
                {
                    remanente = totalCredito - totalDebito;
                    IVAremanente = true;
                }
                else if (totalCredito < totalDebito)
                {
                    impuesto = totalDebito - totalCredito;
                    IVAimpuesto = true;
                }

                DateTime dateTime = DateTime.Now;
                string today = dateTime.Day + "/" + dateTime.Month + "/" + dateTime.Year;

                if(partidaAux == null)
                {
                    partidaAux = new Partida();
                    partidaAux.ListaCuentasPartida = new List<CuentaPartida>();
                }
                else
                {
                    partidaAux.ListaCuentasPartida.Clear();
                }

                partidaAux.Fecha = today;
                partidaAux.Detalle = "Ajuste de IVA";
                partidaAux.IdLibro = idLibroDiario;
                partidaAux.N_Partida = numeroPartidaAux + 1;

                totalCredito = Math.Round(totalCredito, 2);
                totalDebito = Math.Round(totalDebito, 2);
                remanente = Math.Round(remanente, 2);
                impuesto = Math.Round(impuesto, 2);


                if (IVAremanente)
                {
                    if (totalCreditoDebe > totalCreditoHaber)
                    {
                        partidaAux.ListaCuentasPartida.Add(new CuentaPartida { Nombre = "Credito Fiscal IVA", Codigo = "110601", Debe = totalCredito, Haber =  0});
                        partidaAux.ListaCuentasPartida.Add(new CuentaPartida { Nombre = "Percepciones y retenciones de IVA", Codigo = "110602", Debe = remanente, Haber =  0});
                        partidaAux.ListaCuentasPartida.Add(new CuentaPartida { Nombre = "Debito Fiscal IVA", Codigo = "210702", Debe = 0, Haber = totalDebito});
                    }
                    else if (totalCreditoDebe < totalCreditoHaber)
                    {
                        partidaAux.ListaCuentasPartida.Add(new CuentaPartida { Nombre = "Debito Fiscal IVA", Codigo = "210702", Debe = totalDebito, Haber = 0 });
                        partidaAux.ListaCuentasPartida.Add(new CuentaPartida { Nombre = "Percepciones y retenciones de IVA", Codigo = "110602", Debe = remanente, Haber = 0 });
                        partidaAux.ListaCuentasPartida.Add(new CuentaPartida { Nombre = "Credito Fiscal IVA", Codigo = "110601", Debe = 0, Haber = totalCredito });
                    }

                }
                else if (IVAimpuesto)
                {
                    if (totalDebitoDebe > totalDebitoHaber)
                    {
                        partidaAux.ListaCuentasPartida.Add(new CuentaPartida { Nombre = "Credito Fiscal IVA", Codigo = "110601", Debe = totalCredito, Haber = 0 });
                        partidaAux.ListaCuentasPartida.Add(new CuentaPartida { Nombre = "RETENCIONES Y DESCUENTOS", Codigo = "2105", Haber = impuesto});
                        partidaAux.ListaCuentasPartida.Add(new CuentaPartida { Nombre = "Debito Fiscal IVA", Codigo = "210702", Haber = totalDebito});
                    }
                    else if (totalDebitoDebe < totalDebitoHaber)
                    {
                        partidaAux.ListaCuentasPartida.Add(new CuentaPartida { Nombre = "Debito Fiscal IVA", Codigo = "210702", Debe = totalDebito, Haber = 0 });
                        partidaAux.ListaCuentasPartida.Add(new CuentaPartida { Nombre = "RETENCIONES Y DESCUENTOS", Codigo = "2105", Debe = 0, Haber = impuesto});
                        partidaAux.ListaCuentasPartida.Add(new CuentaPartida { Nombre = "Credito Fiscal IVA", Codigo = "110601", Debe = 0, Haber = totalCredito });
                    }
                }


                partidasController.insert(partidaAux);
                llenarTabla();
                Totales();

            } else
            {
                MessageBox.Show("No se encontraron cuentas de Debito Fiscal IVA o Credito Fiscal IVA\nen las partidas del libro actual", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            Totales();

        }


        //el metodo llena la tabla del libro diario
        private void llenarTabla()
        {
            if (tableLibroDiario.Rows.Count > 0 && lista.Count > 0)
            {
                tableLibroDiario.Rows.Clear();
                lista.Clear();
            }

            lista = partidasController.getList(idLibroDiario);

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

        // ingreso los totales del debe y haber en sus respectivos labels
        private void Totales()
        {
            double totalDebe = TotalDebe();
            double totalHaber = TotalHaber();

            lblDebe.Text = "$ " + totalDebe.ToString();
            lblHaber.Text = "$ " + totalHaber.ToString();
        }

        // el metodo retorna la suma de todas cuentas en de la columna Debe
        private double TotalDebe()
        {
            double total = 0;

            for (int i = 0; i < tableLibroDiario.Rows.Count; i++)
            {

                if (!string.IsNullOrEmpty(tableLibroDiario.Rows[i].Cells["ColumnDebe"].Value.ToString()))
                {
                    total += Convert.ToDouble(tableLibroDiario.Rows[i].Cells["ColumnDebe"].Value.ToString());
                }

            }

            return total;
        }

        // el metodo retorna la suma de todas cuentas en de la columna Haber
        private double TotalHaber()
        {
            double total = 0;

            for (int i = 0; i < tableLibroDiario.Rows.Count; i++)
            {

                if (!string.IsNullOrEmpty(tableLibroDiario.Rows[i].Cells["ColumnHaber"].Value.ToString()))
                {
                    total += Convert.ToDouble(tableLibroDiario.Rows[i].Cells["ColumnHaber"].Value.ToString());
                }

            }

            return total;
        }

    }
}
