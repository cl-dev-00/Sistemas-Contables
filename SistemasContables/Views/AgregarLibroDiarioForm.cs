using SistemasContables.controller;
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
    public partial class AgregarLibroDiarioForm : Form
    {
        private LibroDiariosController libroDiarioController;
        private string periodo;
        private string[] meses = {"Enero", "Febrero", "Marzo", "Abril", "Mayo", "Junio", "Julio", "Agosto", "Septiembre","Octubre", "Noviembre", "Diciembre"};

        public AgregarLibroDiarioForm(int idLibroDiario)
        {
            InitializeComponent();
            libroDiarioController = new LibroDiariosController();

            idLibroDiario++;
            lblNumLibro.Text += idLibroDiario;
        }

        private void btnAgregarLibro_Click(object sender, EventArgs e)
        {

            llenarPeriodo();

            
            bool resultado = libroDiarioController.insert(periodo);

            if (resultado)
            {
                MessageBox.Show("Se ingreso el libro diario con exito", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("No se logro ingresar el libro diario", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            this.Close();
        }


        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void llenarPeriodo()
        {

            int dayDesde = dpDesde.Value.Day;
            int monthDesde = dpDesde.Value.Month;
            int yearDesde = dpDesde.Value.Year;

            int dayHasta = dpHasta.Value.Day;
            int monthHasta = dpHasta.Value.Month;
            int yearHasta = dpHasta.Value.Year;

            periodo = $"Del {dayDesde} de {meses[monthDesde - 1]} del {yearDesde} Al {dayHasta} de  {meses[monthHasta-1]} del {yearHasta}";
        }

        //METODO PARA REDIMENCIONAR/CAMBIAR TAMAÑO A FORMULARIO  TIEMPO DE EJECUCION ----------------------------------------------------------
        private int tolerance = 15;
        private const int WM_NCHITTEST = 132;
        private const int HTBOTTOMRIGHT = 17;
        private Rectangle sizeGripRectangle;

        protected override void WndProc(ref Message m)
        {
            switch (m.Msg)
            {
                case WM_NCHITTEST:
                    base.WndProc(ref m);
                    var hitPoint = this.PointToClient(new Point(m.LParam.ToInt32() & 0xffff, m.LParam.ToInt32() >> 16));
                    if (sizeGripRectangle.Contains(hitPoint))
                        m.Result = new IntPtr(HTBOTTOMRIGHT);
                    break;
                default:
                    base.WndProc(ref m);
                    break;
            }
        }
        //----------------DIBUJAR RECTANGULO / EXCLUIR ESQUINA PANEL 
        protected override void OnSizeChanged(EventArgs e)
        {
            base.OnSizeChanged(e);
            var region = new Region(new Rectangle(0, 0, this.ClientRectangle.Width, this.ClientRectangle.Height));
            sizeGripRectangle = new Rectangle(this.ClientRectangle.Width - tolerance, this.ClientRectangle.Height - tolerance, tolerance, tolerance);
            region.Exclude(sizeGripRectangle);
            this.panelContenedor.Region = region;
            this.Invalidate();
        }
        //----------------COLOR Y GRIP DE RECTANGULO INFERIOR
        protected override void OnPaint(PaintEventArgs e)
        {
            SolidBrush blueBrush = new SolidBrush(Color.FromArgb(55, 61, 69));
            e.Graphics.FillRectangle(blueBrush, sizeGripRectangle);
            base.OnPaint(e);
            ControlPaint.DrawSizeGrip(e.Graphics, Color.Transparent, sizeGripRectangle);
        }
    }
}
