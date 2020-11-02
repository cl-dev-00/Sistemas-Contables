namespace SistemasContables
{
    partial class MainForm
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.barraTitulo = new System.Windows.Forms.Panel();
            this.btnMinimizar = new FontAwesome.Sharp.IconButton();
            this.btnRestoreWindow = new FontAwesome.Sharp.IconButton();
            this.btnMaximizar = new FontAwesome.Sharp.IconButton();
            this.btnExit = new FontAwesome.Sharp.IconButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panelNavegacion = new System.Windows.Forms.Panel();
            this.panelContenido = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.btnBalanceGeneral = new FontAwesome.Sharp.IconButton();
            this.btnEstadoDeResultados = new FontAwesome.Sharp.IconButton();
            this.btnBalanceDeComprobacion = new FontAwesome.Sharp.IconButton();
            this.btnLibroMayor = new FontAwesome.Sharp.IconButton();
            this.btnLibroDiario = new FontAwesome.Sharp.IconButton();
            this.btnInicio = new FontAwesome.Sharp.IconButton();
            this.btnMenu = new FontAwesome.Sharp.IconButton();
            this.barraTitulo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panelNavegacion.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // barraTitulo
            // 
            this.barraTitulo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(69)))), ((int)(((byte)(96)))));
            this.barraTitulo.Controls.Add(this.btnMinimizar);
            this.barraTitulo.Controls.Add(this.btnRestoreWindow);
            this.barraTitulo.Controls.Add(this.btnMaximizar);
            this.barraTitulo.Controls.Add(this.btnExit);
            this.barraTitulo.Controls.Add(this.pictureBox1);
            this.barraTitulo.Dock = System.Windows.Forms.DockStyle.Top;
            this.barraTitulo.Location = new System.Drawing.Point(0, 0);
            this.barraTitulo.Name = "barraTitulo";
            this.barraTitulo.Size = new System.Drawing.Size(1200, 55);
            this.barraTitulo.TabIndex = 1;
            this.barraTitulo.MouseDown += new System.Windows.Forms.MouseEventHandler(this.barraTitulo_MouseDown);
            // 
            // btnMinimizar
            // 
            this.btnMinimizar.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnMinimizar.FlatAppearance.BorderSize = 0;
            this.btnMinimizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMinimizar.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btnMinimizar.IconChar = FontAwesome.Sharp.IconChar.WindowMinimize;
            this.btnMinimizar.IconColor = System.Drawing.Color.White;
            this.btnMinimizar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnMinimizar.IconSize = 35;
            this.btnMinimizar.Location = new System.Drawing.Point(996, 0);
            this.btnMinimizar.Margin = new System.Windows.Forms.Padding(2);
            this.btnMinimizar.Name = "btnMinimizar";
            this.btnMinimizar.Rotation = 0D;
            this.btnMinimizar.Size = new System.Drawing.Size(51, 55);
            this.btnMinimizar.TabIndex = 4;
            this.btnMinimizar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnMinimizar.UseVisualStyleBackColor = true;
            this.btnMinimizar.Click += new System.EventHandler(this.btnMinimizar_Click);
            // 
            // btnRestoreWindow
            // 
            this.btnRestoreWindow.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnRestoreWindow.FlatAppearance.BorderSize = 0;
            this.btnRestoreWindow.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRestoreWindow.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btnRestoreWindow.IconChar = FontAwesome.Sharp.IconChar.WindowRestore;
            this.btnRestoreWindow.IconColor = System.Drawing.Color.White;
            this.btnRestoreWindow.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnRestoreWindow.IconSize = 35;
            this.btnRestoreWindow.Location = new System.Drawing.Point(1047, 0);
            this.btnRestoreWindow.Margin = new System.Windows.Forms.Padding(2);
            this.btnRestoreWindow.Name = "btnRestoreWindow";
            this.btnRestoreWindow.Rotation = 0D;
            this.btnRestoreWindow.Size = new System.Drawing.Size(51, 55);
            this.btnRestoreWindow.TabIndex = 3;
            this.btnRestoreWindow.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnRestoreWindow.UseVisualStyleBackColor = true;
            this.btnRestoreWindow.Visible = false;
            this.btnRestoreWindow.Click += new System.EventHandler(this.btnRestoreWindow_Click);
            // 
            // btnMaximizar
            // 
            this.btnMaximizar.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnMaximizar.FlatAppearance.BorderSize = 0;
            this.btnMaximizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMaximizar.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btnMaximizar.IconChar = FontAwesome.Sharp.IconChar.WindowMaximize;
            this.btnMaximizar.IconColor = System.Drawing.Color.White;
            this.btnMaximizar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnMaximizar.IconSize = 35;
            this.btnMaximizar.Location = new System.Drawing.Point(1098, 0);
            this.btnMaximizar.Margin = new System.Windows.Forms.Padding(2);
            this.btnMaximizar.Name = "btnMaximizar";
            this.btnMaximizar.Rotation = 0D;
            this.btnMaximizar.Size = new System.Drawing.Size(51, 55);
            this.btnMaximizar.TabIndex = 2;
            this.btnMaximizar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnMaximizar.UseVisualStyleBackColor = true;
            this.btnMaximizar.Click += new System.EventHandler(this.btnMaximizar_Click);
            // 
            // btnExit
            // 
            this.btnExit.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnExit.FlatAppearance.BorderSize = 0;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btnExit.IconChar = FontAwesome.Sharp.IconChar.WindowClose;
            this.btnExit.IconColor = System.Drawing.Color.White;
            this.btnExit.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnExit.IconSize = 35;
            this.btnExit.Location = new System.Drawing.Point(1149, 0);
            this.btnExit.Margin = new System.Windows.Forms.Padding(2);
            this.btnExit.Name = "btnExit";
            this.btnExit.Rotation = 0D;
            this.btnExit.Size = new System.Drawing.Size(51, 55);
            this.btnExit.TabIndex = 1;
            this.btnExit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Left;
            this.pictureBox1.Image = global::SistemasContables.Properties.Resources.logo;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(264, 55);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // panelNavegacion
            // 
            this.panelNavegacion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(54)))), ((int)(((byte)(64)))));
            this.panelNavegacion.Controls.Add(this.btnBalanceGeneral);
            this.panelNavegacion.Controls.Add(this.btnEstadoDeResultados);
            this.panelNavegacion.Controls.Add(this.btnBalanceDeComprobacion);
            this.panelNavegacion.Controls.Add(this.btnLibroMayor);
            this.panelNavegacion.Controls.Add(this.btnLibroDiario);
            this.panelNavegacion.Controls.Add(this.btnInicio);
            this.panelNavegacion.Controls.Add(this.btnMenu);
            this.panelNavegacion.Controls.Add(this.pictureBox2);
            this.panelNavegacion.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelNavegacion.Location = new System.Drawing.Point(0, 55);
            this.panelNavegacion.Name = "panelNavegacion";
            this.panelNavegacion.Size = new System.Drawing.Size(250, 585);
            this.panelNavegacion.TabIndex = 2;
            // 
            // panelContenido
            // 
            this.panelContenido.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelContenido.Location = new System.Drawing.Point(250, 55);
            this.panelContenido.Name = "panelContenido";
            this.panelContenido.Size = new System.Drawing.Size(950, 561);
            this.panelContenido.TabIndex = 3;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Dock = System.Windows.Forms.DockStyle.Top;
            this.pictureBox2.Image = global::SistemasContables.Properties.Resources.finanzas;
            this.pictureBox2.Location = new System.Drawing.Point(0, 0);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(250, 114);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 8;
            this.pictureBox2.TabStop = false;
            // 
            // btnBalanceGeneral
            // 
            this.btnBalanceGeneral.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBalanceGeneral.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnBalanceGeneral.FlatAppearance.BorderSize = 0;
            this.btnBalanceGeneral.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBalanceGeneral.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btnBalanceGeneral.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBalanceGeneral.ForeColor = System.Drawing.Color.White;
            this.btnBalanceGeneral.IconChar = FontAwesome.Sharp.IconChar.SearchDollar;
            this.btnBalanceGeneral.IconColor = System.Drawing.Color.White;
            this.btnBalanceGeneral.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnBalanceGeneral.IconSize = 48;
            this.btnBalanceGeneral.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBalanceGeneral.Location = new System.Drawing.Point(0, 474);
            this.btnBalanceGeneral.MinimumSize = new System.Drawing.Size(250, 60);
            this.btnBalanceGeneral.Name = "btnBalanceGeneral";
            this.btnBalanceGeneral.Padding = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.btnBalanceGeneral.Rotation = 0D;
            this.btnBalanceGeneral.Size = new System.Drawing.Size(250, 60);
            this.btnBalanceGeneral.TabIndex = 21;
            this.btnBalanceGeneral.Text = "Balance general";
            this.btnBalanceGeneral.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBalanceGeneral.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnBalanceGeneral.UseVisualStyleBackColor = true;
            this.btnBalanceGeneral.Click += new System.EventHandler(this.btnBalanceGeneral_Click);
            // 
            // btnEstadoDeResultados
            // 
            this.btnEstadoDeResultados.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEstadoDeResultados.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnEstadoDeResultados.FlatAppearance.BorderSize = 0;
            this.btnEstadoDeResultados.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEstadoDeResultados.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btnEstadoDeResultados.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEstadoDeResultados.ForeColor = System.Drawing.Color.White;
            this.btnEstadoDeResultados.IconChar = FontAwesome.Sharp.IconChar.Landmark;
            this.btnEstadoDeResultados.IconColor = System.Drawing.Color.White;
            this.btnEstadoDeResultados.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnEstadoDeResultados.IconSize = 48;
            this.btnEstadoDeResultados.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEstadoDeResultados.Location = new System.Drawing.Point(0, 414);
            this.btnEstadoDeResultados.MinimumSize = new System.Drawing.Size(250, 60);
            this.btnEstadoDeResultados.Name = "btnEstadoDeResultados";
            this.btnEstadoDeResultados.Padding = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.btnEstadoDeResultados.Rotation = 0D;
            this.btnEstadoDeResultados.Size = new System.Drawing.Size(250, 60);
            this.btnEstadoDeResultados.TabIndex = 20;
            this.btnEstadoDeResultados.Text = "Estado de resultados";
            this.btnEstadoDeResultados.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEstadoDeResultados.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnEstadoDeResultados.UseVisualStyleBackColor = true;
            this.btnEstadoDeResultados.Click += new System.EventHandler(this.btnEstadoDeResultados_Click);
            // 
            // btnBalanceDeComprobacion
            // 
            this.btnBalanceDeComprobacion.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBalanceDeComprobacion.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnBalanceDeComprobacion.FlatAppearance.BorderSize = 0;
            this.btnBalanceDeComprobacion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBalanceDeComprobacion.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btnBalanceDeComprobacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBalanceDeComprobacion.ForeColor = System.Drawing.Color.White;
            this.btnBalanceDeComprobacion.IconChar = FontAwesome.Sharp.IconChar.BalanceScale;
            this.btnBalanceDeComprobacion.IconColor = System.Drawing.Color.White;
            this.btnBalanceDeComprobacion.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnBalanceDeComprobacion.IconSize = 48;
            this.btnBalanceDeComprobacion.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBalanceDeComprobacion.Location = new System.Drawing.Point(0, 354);
            this.btnBalanceDeComprobacion.MinimumSize = new System.Drawing.Size(250, 60);
            this.btnBalanceDeComprobacion.Name = "btnBalanceDeComprobacion";
            this.btnBalanceDeComprobacion.Padding = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.btnBalanceDeComprobacion.Rotation = 0D;
            this.btnBalanceDeComprobacion.Size = new System.Drawing.Size(250, 60);
            this.btnBalanceDeComprobacion.TabIndex = 19;
            this.btnBalanceDeComprobacion.Text = "Balance de comprobacion";
            this.btnBalanceDeComprobacion.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBalanceDeComprobacion.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnBalanceDeComprobacion.UseVisualStyleBackColor = true;
            this.btnBalanceDeComprobacion.Click += new System.EventHandler(this.btnBalanceDeComprobacion_Click);
            // 
            // btnLibroMayor
            // 
            this.btnLibroMayor.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLibroMayor.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnLibroMayor.FlatAppearance.BorderSize = 0;
            this.btnLibroMayor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLibroMayor.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btnLibroMayor.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLibroMayor.ForeColor = System.Drawing.Color.White;
            this.btnLibroMayor.IconChar = FontAwesome.Sharp.IconChar.BookOpen;
            this.btnLibroMayor.IconColor = System.Drawing.Color.White;
            this.btnLibroMayor.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnLibroMayor.IconSize = 48;
            this.btnLibroMayor.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLibroMayor.Location = new System.Drawing.Point(0, 294);
            this.btnLibroMayor.MinimumSize = new System.Drawing.Size(250, 60);
            this.btnLibroMayor.Name = "btnLibroMayor";
            this.btnLibroMayor.Padding = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.btnLibroMayor.Rotation = 0D;
            this.btnLibroMayor.Size = new System.Drawing.Size(250, 60);
            this.btnLibroMayor.TabIndex = 18;
            this.btnLibroMayor.Text = "Libro Mayor";
            this.btnLibroMayor.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLibroMayor.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnLibroMayor.UseVisualStyleBackColor = true;
            this.btnLibroMayor.Click += new System.EventHandler(this.btnLibroMayor_Click);
            // 
            // btnLibroDiario
            // 
            this.btnLibroDiario.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLibroDiario.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnLibroDiario.FlatAppearance.BorderSize = 0;
            this.btnLibroDiario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLibroDiario.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btnLibroDiario.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLibroDiario.ForeColor = System.Drawing.Color.White;
            this.btnLibroDiario.IconChar = FontAwesome.Sharp.IconChar.Book;
            this.btnLibroDiario.IconColor = System.Drawing.Color.White;
            this.btnLibroDiario.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnLibroDiario.IconSize = 48;
            this.btnLibroDiario.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLibroDiario.Location = new System.Drawing.Point(0, 234);
            this.btnLibroDiario.MinimumSize = new System.Drawing.Size(250, 60);
            this.btnLibroDiario.Name = "btnLibroDiario";
            this.btnLibroDiario.Padding = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.btnLibroDiario.Rotation = 0D;
            this.btnLibroDiario.Size = new System.Drawing.Size(250, 60);
            this.btnLibroDiario.TabIndex = 17;
            this.btnLibroDiario.Text = "Libro Diario";
            this.btnLibroDiario.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLibroDiario.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnLibroDiario.UseVisualStyleBackColor = true;
            this.btnLibroDiario.Click += new System.EventHandler(this.btnLibroDiario_Click);
            // 
            // btnInicio
            // 
            this.btnInicio.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnInicio.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnInicio.FlatAppearance.BorderSize = 0;
            this.btnInicio.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInicio.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btnInicio.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInicio.ForeColor = System.Drawing.Color.White;
            this.btnInicio.IconChar = FontAwesome.Sharp.IconChar.Home;
            this.btnInicio.IconColor = System.Drawing.Color.White;
            this.btnInicio.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnInicio.IconSize = 48;
            this.btnInicio.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnInicio.Location = new System.Drawing.Point(0, 174);
            this.btnInicio.MinimumSize = new System.Drawing.Size(250, 60);
            this.btnInicio.Name = "btnInicio";
            this.btnInicio.Padding = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.btnInicio.Rotation = 0D;
            this.btnInicio.Size = new System.Drawing.Size(250, 60);
            this.btnInicio.TabIndex = 16;
            this.btnInicio.Text = "Inicio";
            this.btnInicio.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnInicio.UseVisualStyleBackColor = true;
            this.btnInicio.Click += new System.EventHandler(this.btnInicio_Click);
            // 
            // btnMenu
            // 
            this.btnMenu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnMenu.FlatAppearance.BorderSize = 0;
            this.btnMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMenu.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btnMenu.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMenu.ForeColor = System.Drawing.Color.White;
            this.btnMenu.IconChar = FontAwesome.Sharp.IconChar.Bars;
            this.btnMenu.IconColor = System.Drawing.Color.White;
            this.btnMenu.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnMenu.IconSize = 48;
            this.btnMenu.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMenu.Location = new System.Drawing.Point(0, 114);
            this.btnMenu.MinimumSize = new System.Drawing.Size(250, 60);
            this.btnMenu.Name = "btnMenu";
            this.btnMenu.Padding = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.btnMenu.Rotation = 0D;
            this.btnMenu.Size = new System.Drawing.Size(250, 60);
            this.btnMenu.TabIndex = 15;
            this.btnMenu.Text = "Menu";
            this.btnMenu.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnMenu.UseVisualStyleBackColor = true;
            this.btnMenu.Click += new System.EventHandler(this.btnMenu_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1200, 640);
            this.Controls.Add(this.panelContenido);
            this.Controls.Add(this.panelNavegacion);
            this.Controls.Add(this.barraTitulo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MainForm";
            this.Text = "Sistemas Contables";
            this.barraTitulo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panelNavegacion.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel barraTitulo;
        private System.Windows.Forms.PictureBox pictureBox1;
        private FontAwesome.Sharp.IconButton btnExit;
        private FontAwesome.Sharp.IconButton btnMinimizar;
        private FontAwesome.Sharp.IconButton btnRestoreWindow;
        private FontAwesome.Sharp.IconButton btnMaximizar;
        private System.Windows.Forms.Panel panelNavegacion;
        private System.Windows.Forms.Panel panelContenido;
        private System.Windows.Forms.PictureBox pictureBox2;
        private FontAwesome.Sharp.IconButton btnBalanceGeneral;
        private FontAwesome.Sharp.IconButton btnEstadoDeResultados;
        private FontAwesome.Sharp.IconButton btnBalanceDeComprobacion;
        private FontAwesome.Sharp.IconButton btnLibroMayor;
        private FontAwesome.Sharp.IconButton btnLibroDiario;
        private FontAwesome.Sharp.IconButton btnInicio;
        private FontAwesome.Sharp.IconButton btnMenu;
    }
}

