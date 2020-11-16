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
    public partial class AgregarPartidaForm : Form
    {
        private int PosicionFormX;
        private int PosicionFormY;
        private int WindowWidth;
        private int WindowHeight;

        public AgregarPartidaForm()
        {
            InitializeComponent();

            tablePartida.Rows.Add(1, 0, 0, 0, 0);
            tablePartida.Rows.Add(2, 0, 0, 0, 0);
            tablePartida.Rows.Add(3, 0, 0, 0, 0);
            tablePartida.Rows.Add(4, 0, 0, 0, 0);
            tablePartida.Rows.Add(5, 0, 0, 0, 0);
            tablePartida.Rows.Add(6, 0, 0, 0, 0);
            tablePartida.Rows.Add(1, 0, 0, 0, 0);
            tablePartida.Rows.Add(2, 0, 0, 0, 0);
            tablePartida.Rows.Add(3, 0, 0, 0, 0);
            tablePartida.Rows.Add(4, 0, 0, 0, 0);
            tablePartida.Rows.Add(5, 0, 0, 0, 0);
            tablePartida.Rows.Add(6, 0, 0, 0, 0);

        }

        // cierra el programa
        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        // maximiza la ventana
        private void btnMaximizar_Click(object sender, EventArgs e)
        {
            // obtengo la posicion de la ventana previo a maximizar la ventana
            PosicionFormX = this.Location.X;
            PosicionFormY = this.Location.Y;

            // obtengo la tamaño de la ventana previo a maximizar la ventana
            WindowWidth = this.Size.Width;
            WindowHeight = this.Size.Height;

            this.Size = Screen.PrimaryScreen.WorkingArea.Size;
            this.Location = Screen.PrimaryScreen.WorkingArea.Location;
            this.btnMaximizar.Visible = false;
            this.btnRestoreWindow.Visible = true;
        }

        // restaurar el tamaño de la ventana al tamaño antes de maximizar
        private void btnRestoreWindow_Click(object sender, EventArgs e)
        {
            this.Size = new Size(WindowWidth, WindowHeight);
            // devulvo a la ventana a la posicion previo a maximizar la ventana
            this.Location = new Point(PosicionFormX, PosicionFormY);
            this.btnMaximizar.Visible = true;
            this.btnRestoreWindow.Visible = false;
        }

        // minimiza la ventana
        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
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

        private void btnAgregarPartida_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
