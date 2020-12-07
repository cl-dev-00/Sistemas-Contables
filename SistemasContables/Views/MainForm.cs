using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using SistemasContables.Views;
using FontAwesome.Sharp;
using System.Resources;
using Microsoft.VisualBasic.CompilerServices;
using SistemasContables.Models;
using SistemasContables.controller;

namespace SistemasContables
{
    public partial class MainForm : Form
    {
        private LibroDiario libroDiario;
        private List<LibroDiario> listaLibroDiario;
        private LibroDiariosController libroDiarioController;
        private IconButton btnCurrent;
        private Panel leftPanelBtn;

        private Form currentForm = null;
        private Color color = Color.FromArgb(27, 156, 252);

        int indexLibroDiario = 0;
        string currentNameForm = "inicio";

        private int PosicionFormX;
        private int PosicionFormY;
        private int WindowWidth;
        private int WindowHeight;

        private double reserva_legal;
        private double impuestos_por_pagar;
        private double utilidad_neta;



        public MainForm()
        {
            InitializeComponent();
            leftPanelBtn = new Panel();
            leftPanelBtn.Size = new Size(7, btnInicio.Height);
            panelNavegacion.Controls.Add(leftPanelBtn);
            openFormInPane(new InicioForm());

            libroDiarioController = new LibroDiariosController();

            listaLibroDiario = libroDiarioController.getList();

            libroDiario = listaLibroDiario[indexLibroDiario];

            lblPagina.Text = (indexLibroDiario + 1).ToString();


        }

        // cierra el programa
        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
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
            this.Size = new Size(WindowWidth,WindowHeight);
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


        // Displiega o miniza la barra de navegacion
        private void btnMenu_Click(object sender, EventArgs e)
        {
            disabledButton();

            if(panelNavegacion.Width == 252)
            {
                panelNavegacion.Visible = false;

                panelNavegacion.Width = 62;
                pbLogo.Image = Properties.Resources.icon;

                AnimacionPanelNavegacion.ShowSync(panelNavegacion);
            } else
            {
                panelNavegacion.Visible = false;

                panelNavegacion.Width = 252;
                pbLogo.Image = Properties.Resources.logo;

                AnimacionPanelNavegacion.ShowSync(panelNavegacion);
            }

        }

        // abre el form de inicio en el panel de contenido
        private void btnInicio_Click(object sender, EventArgs e)
        {
            currentNameForm = "inicio";
            activaButton(this.btnInicio);
            openFormInPane(new InicioForm());
        }

        // abre el form del libro diario en el panel de contenido
        private void btnLibroDiario_Click(object sender, EventArgs e)
        {
            currentNameForm = "libro_diario";
            activaButton(this.btnLibroDiario);
            openFormInPane(new LibroDiarioForm(libroDiario));
        }

        // abre el form del libro mayor en el panel de contenido
        private void btnLibroMayor_Click(object sender, EventArgs e)
        {
            currentNameForm = "libro_mayor";
            activaButton(this.btnLibroMayor);
            openFormInPane(new LibroMayorForm(libroDiario));
        }

        // abre el form de balance de comprobacion en el panel de contenido
        private void btnBalanceDeComprobacion_Click(object sender, EventArgs e)
        {
            currentNameForm = "balance_comprobacion";
            activaButton(this.btnBalanceDeComprobacion);
            openFormInPane(new BalanceDeComprobacionForm(libroDiario));
        }

        // abre el form de estado de resultados en el panel de contenido
        private void btnEstadoDeResultados_Click(object sender, EventArgs e)
        {
            currentNameForm = "estado_resultados";
            activaButton(this.btnEstadoDeResultados);

            EstadoDeResultadosForm estadoFrom = new EstadoDeResultadosForm(libroDiario);

            openFormInPane(estadoFrom);

            utilidad_neta = estadoFrom.getUtilidad_neta();
            impuestos_por_pagar = estadoFrom.getImpuestos();
            reserva_legal = estadoFrom.getReserva();
        }

        // abre el form de balance general en el panel de contenido
        private void btnBalanceGeneral_Click(object sender, EventArgs e)
        {
            currentNameForm = "balance_general";
            activaButton(this.btnBalanceGeneral);
            openFormInPane(new BalanceGeneralForm(libroDiario, impuestos_por_pagar, reserva_legal, utilidad_neta));
        }

        // cambia los estilos del button que esten en el panel de navegacion cuando se haga click
        private void activaButton(object senderBtn)
        {
            if(senderBtn != null && panelNavegacion.Width == 252)
            {
                disabledButton();

                // Estilos del button
                btnCurrent = (IconButton)senderBtn;
                //btnCurrent.BackColor = color;

                //// Estilos del button
                //btnCurrent = (IconButton)senderBtn;
                //btnCurrent.ForeColor = color;
                //btnCurrent.TextAlign = ContentAlignment.MiddleCenter;
                //btnCurrent.IconColor = color;
                //btnCurrent.ImageAlign = ContentAlignment.MiddleRight;
                //btnCurrent.TextImageRelation = TextImageRelation.TextBeforeImage;

                //// Estilos del panel izquierdo del button
                leftPanelBtn.BackColor = color;
                leftPanelBtn.Location = new Point(0, btnCurrent.Location.Y);
                leftPanelBtn.Visible = true;
                leftPanelBtn.BringToFront();
            } else
            {
                disabledButton();

                // Estilos del button
                btnCurrent = (IconButton)senderBtn;
                //btnCurrent.BackColor = color;

                //// Estilos del button
                //btnCurrent = (IconButton)senderBtn;
                //btnCurrent.IconColor = color;

                // Estilos del panel izquierdo del button
                leftPanelBtn.BackColor = color;
                leftPanelBtn.Location = new Point(0, btnCurrent.Location.Y);
                leftPanelBtn.Visible = true;
                leftPanelBtn.BringToFront();


            }
        }

        // cambia los estilos del button que esten en el panel de navegacion cuando se desactiva
        private void disabledButton()
        {
            if (btnCurrent != null)
            {
                // Estilos del button
                //btnCurrent.BackColor = color;

                //// Estilos del button
                //btnCurrent.ForeColor = Color.White;
                //btnCurrent.TextAlign = ContentAlignment.MiddleCenter;
                //btnCurrent.IconColor = Color.White;
                //btnCurrent.ImageAlign = ContentAlignment.MiddleLeft;
                //btnCurrent.TextImageRelation = TextImageRelation.ImageBeforeText;

                // Estilos del panel izquierdo del button
                leftPanelBtn.Visible = false;

            }
        }

        // abre un form dentro del panel de contenido
        private void openFormInPane(object childForm)
        {
            if(currentForm != null)
            {
                currentForm.Dispose();
            }

            if (this.panelContenido.Controls.Count > 0)
            {
                this.panelContenido.Controls.RemoveAt(0);
            }

            currentForm = childForm as Form;
            currentForm.TopLevel = false;
            currentForm.Dock = DockStyle.Fill;
            this.panelContenido.Controls.Add(currentForm);
            this.panelContenido.Tag = currentForm;
            currentForm.Show();

        }

        // el metodo elimina el libro diario
        private void btnDeleteLibroDiario_Click(object sender, EventArgs e)
        {
            DialogResult res = MessageBox.Show("¿Desea eliminar el libro diario actual?", "Mensaje", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (res == DialogResult.OK)
            {
                bool resultado = libroDiarioController.delete(libroDiario.IdLibroDiario);

                if(resultado)
                {
                    MessageBox.Show("Se elimino el libro diario con exito", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                } else
                {
                    MessageBox.Show("No se logro eliminar el libro diario", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }


                listaLibroDiario = libroDiarioController.getList();

                indexLibroDiario = 0;

                libroDiario = listaLibroDiario[indexLibroDiario];

                lblPagina.Text = (indexLibroDiario + 1).ToString();

                recargarForm();

            }
        }

        // el metodo mueve el libro diario actual al anterior
        private void btnPrevious_Click(object sender, EventArgs e)
        {
            if(indexLibroDiario > 0)
            {
                indexLibroDiario--;
                lblPagina.Text = (indexLibroDiario + 1).ToString();

                libroDiario = listaLibroDiario[indexLibroDiario];

                recargarForm();
            }
        }

        // el metodo mueve el libro diario actual al siguiente
        private void btnNext_Click(object sender, EventArgs e)
        {
            if(indexLibroDiario < listaLibroDiario.Count-1)
            {
                indexLibroDiario++;
                lblPagina.Text = (indexLibroDiario + 1).ToString();

                libroDiario = listaLibroDiario[indexLibroDiario];

                recargarForm();
            }
        }

        // el metodo muestra una ventana para agregar un nuevo libro diario
        private void btnAddLibroDiario_Click(object sender, EventArgs e)
        {
            using (AgregarLibroDiarioForm agregarLibroDiarioForm = new AgregarLibroDiarioForm(listaLibroDiario.Count))
            {
                this.Visible = false;
                agregarLibroDiarioForm.ShowDialog();
                this.Visible = true;

                listaLibroDiario = libroDiarioController.getList();

                indexLibroDiario = listaLibroDiario.Count - 1;

                libroDiario = listaLibroDiario[indexLibroDiario];

                recargarForm();

                lblPagina.Text = (indexLibroDiario + 1).ToString();
            }

        }

        // el metodo regarca el form cada vez que se cambia de libro diario
        private void recargarForm()
        {
            if (currentNameForm == "inicio")
            {
                openFormInPane(new InicioForm());
            }
            else if (currentNameForm == "libro_diario")
            {
                openFormInPane(new LibroDiarioForm(libroDiario));
            }
            else if (currentNameForm == "libro_mayor")
            {
                openFormInPane(new LibroMayorForm(libroDiario));
            }
            else if (currentNameForm == "balance_comprobacion")
            {
                openFormInPane(new BalanceDeComprobacionForm(libroDiario));
            }
            else if (currentNameForm == "estado_resultados")
            {
                openFormInPane(new EstadoDeResultadosForm(libroDiario));
            }
            else if (currentNameForm == "balance_general")
            {
                openFormInPane(new BalanceGeneralForm(libroDiario, impuestos_por_pagar, reserva_legal, utilidad_neta));
            }

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
