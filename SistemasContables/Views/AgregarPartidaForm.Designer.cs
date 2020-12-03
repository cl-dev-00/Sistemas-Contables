namespace SistemasContables.Views
{
    partial class AgregarPartidaForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panelContenedor = new System.Windows.Forms.Panel();
            this.panelContenido = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.lblPartida = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dpFecha = new Bunifu.Framework.UI.BunifuDatepicker();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.btnAgregarPartida = new FontAwesome.Sharp.IconButton();
            this.btnEditarPartida = new FontAwesome.Sharp.IconButton();
            this.btnNuevaCuenta = new FontAwesome.Sharp.IconButton();
            this.btnEliminarCuenta = new FontAwesome.Sharp.IconButton();
            this.label14 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tablePartida = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.ColumnFecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnCodigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnDetalle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1Debe = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnHaber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panelTop = new System.Windows.Forms.Panel();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.btnMinimizar = new FontAwesome.Sharp.IconButton();
            this.btnRestoreWindow = new FontAwesome.Sharp.IconButton();
            this.btnMaximizar = new FontAwesome.Sharp.IconButton();
            this.btnExit = new FontAwesome.Sharp.IconButton();
            this.MoverPanelTop = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.MoverTitulo = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.bordesTabla = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.bunifuElipse2 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.bunifuElipse3 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.bunifuElipse4 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.bunifuElipse5 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.bunifuElipse6 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.bunifuElipse7 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.licensing1 = new Guna.UI.WinForms.Licensing();
            this.cbTipoTransaccion = new Guna.UI.WinForms.GunaComboBox();
            this.cbCuenta = new Guna.UI.WinForms.GunaComboBox();
            this.txtMonto = new Guna.UI.WinForms.GunaTextBox();
            this.txtDescripcion = new Guna.UI.WinForms.GunaTextBox();
            this.cbDebito = new Guna.UI.WinForms.GunaCheckBox();
            this.cbCredito = new Guna.UI.WinForms.GunaCheckBox();
            this.cbExcento = new Guna.UI.WinForms.GunaCheckBox();
            this.cbIncluido = new Guna.UI.WinForms.GunaCheckBox();
            this.cbMasIva = new Guna.UI.WinForms.GunaCheckBox();
            this.panelContenedor.SuspendLayout();
            this.panelContenido.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tablePartida)).BeginInit();
            this.panelTop.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelContenedor
            // 
            this.panelContenedor.Controls.Add(this.panelContenido);
            this.panelContenedor.Controls.Add(this.panelTop);
            this.panelContenedor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelContenedor.Location = new System.Drawing.Point(0, 0);
            this.panelContenedor.Name = "panelContenedor";
            this.panelContenedor.Size = new System.Drawing.Size(1000, 770);
            this.panelContenedor.TabIndex = 0;
            // 
            // panelContenido
            // 
            this.panelContenido.BackColor = System.Drawing.Color.White;
            this.panelContenido.Controls.Add(this.cbIncluido);
            this.panelContenido.Controls.Add(this.cbMasIva);
            this.panelContenido.Controls.Add(this.cbExcento);
            this.panelContenido.Controls.Add(this.cbCredito);
            this.panelContenido.Controls.Add(this.cbDebito);
            this.panelContenido.Controls.Add(this.txtDescripcion);
            this.panelContenido.Controls.Add(this.txtMonto);
            this.panelContenido.Controls.Add(this.cbCuenta);
            this.panelContenido.Controls.Add(this.cbTipoTransaccion);
            this.panelContenido.Controls.Add(this.label7);
            this.panelContenido.Controls.Add(this.label10);
            this.panelContenido.Controls.Add(this.lblPartida);
            this.panelContenido.Controls.Add(this.label12);
            this.panelContenido.Controls.Add(this.label3);
            this.panelContenido.Controls.Add(this.dpFecha);
            this.panelContenido.Controls.Add(this.flowLayoutPanel1);
            this.panelContenido.Controls.Add(this.label14);
            this.panelContenido.Controls.Add(this.label2);
            this.panelContenido.Controls.Add(this.label1);
            this.panelContenido.Controls.Add(this.panel1);
            this.panelContenido.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelContenido.Location = new System.Drawing.Point(0, 40);
            this.panelContenido.Margin = new System.Windows.Forms.Padding(2);
            this.panelContenido.Name = "panelContenido";
            this.panelContenido.Size = new System.Drawing.Size(1000, 730);
            this.panelContenido.TabIndex = 7;
            // 
            // label7
            // 
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(499, 62);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(129, 23);
            this.label7.TabIndex = 64;
            this.label7.Text = "Tipo de pago";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label10
            // 
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.Black;
            this.label10.Location = new System.Drawing.Point(42, 129);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(179, 23);
            this.label10.TabIndex = 63;
            this.label10.Text = "Tipo de transacción";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblPartida
            // 
            this.lblPartida.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold);
            this.lblPartida.ForeColor = System.Drawing.Color.Black;
            this.lblPartida.Location = new System.Drawing.Point(42, 13);
            this.lblPartida.Name = "lblPartida";
            this.lblPartida.Size = new System.Drawing.Size(179, 23);
            this.lblPartida.TabIndex = 16;
            this.lblPartida.Text = "Partida No ";
            this.lblPartida.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label12
            // 
            this.label12.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.Black;
            this.label12.Location = new System.Drawing.Point(39, 503);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(182, 23);
            this.label12.TabIndex = 55;
            this.label12.Text = "Descripcion / Detalle";
            this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(39, 416);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 23);
            this.label3.TabIndex = 54;
            this.label3.Text = "Fecha";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dpFecha
            // 
            this.dpFecha.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.dpFecha.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(99)))), ((int)(((byte)(72)))));
            this.dpFecha.BorderRadius = 0;
            this.dpFecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dpFecha.ForeColor = System.Drawing.Color.White;
            this.dpFecha.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.dpFecha.FormatCustom = null;
            this.dpFecha.Location = new System.Drawing.Point(43, 451);
            this.dpFecha.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dpFecha.Name = "dpFecha";
            this.dpFecha.Size = new System.Drawing.Size(318, 35);
            this.dpFecha.TabIndex = 53;
            this.dpFecha.Value = new System.DateTime(2020, 11, 15, 10, 20, 18, 864);
            this.dpFecha.onValueChanged += new System.EventHandler(this.dpFecha_onValueChanged);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.flowLayoutPanel1.Controls.Add(this.btnAgregarPartida);
            this.flowLayoutPanel1.Controls.Add(this.btnEditarPartida);
            this.flowLayoutPanel1.Controls.Add(this.btnNuevaCuenta);
            this.flowLayoutPanel1.Controls.Add(this.btnEliminarCuenta);
            this.flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(149, 654);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(801, 55);
            this.flowLayoutPanel1.TabIndex = 46;
            // 
            // btnAgregarPartida
            // 
            this.btnAgregarPartida.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAgregarPartida.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.btnAgregarPartida.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAgregarPartida.FlatAppearance.BorderSize = 0;
            this.btnAgregarPartida.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregarPartida.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btnAgregarPartida.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregarPartida.ForeColor = System.Drawing.Color.White;
            this.btnAgregarPartida.IconChar = FontAwesome.Sharp.IconChar.Check;
            this.btnAgregarPartida.IconColor = System.Drawing.Color.White;
            this.btnAgregarPartida.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnAgregarPartida.IconSize = 40;
            this.btnAgregarPartida.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAgregarPartida.Location = new System.Drawing.Point(608, 3);
            this.btnAgregarPartida.MinimumSize = new System.Drawing.Size(190, 50);
            this.btnAgregarPartida.Name = "btnAgregarPartida";
            this.btnAgregarPartida.Rotation = 0D;
            this.btnAgregarPartida.Size = new System.Drawing.Size(190, 50);
            this.btnAgregarPartida.TabIndex = 16;
            this.btnAgregarPartida.Text = "Agregar Partida";
            this.btnAgregarPartida.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAgregarPartida.UseVisualStyleBackColor = false;
            this.btnAgregarPartida.Click += new System.EventHandler(this.btnAgregarPartida_Click);
            // 
            // btnEditarPartida
            // 
            this.btnEditarPartida.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEditarPartida.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(156)))), ((int)(((byte)(18)))));
            this.btnEditarPartida.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEditarPartida.FlatAppearance.BorderSize = 0;
            this.btnEditarPartida.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditarPartida.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btnEditarPartida.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditarPartida.ForeColor = System.Drawing.Color.White;
            this.btnEditarPartida.IconChar = FontAwesome.Sharp.IconChar.Edit;
            this.btnEditarPartida.IconColor = System.Drawing.Color.White;
            this.btnEditarPartida.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnEditarPartida.IconSize = 40;
            this.btnEditarPartida.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEditarPartida.Location = new System.Drawing.Point(412, 3);
            this.btnEditarPartida.MinimumSize = new System.Drawing.Size(190, 50);
            this.btnEditarPartida.Name = "btnEditarPartida";
            this.btnEditarPartida.Rotation = 0D;
            this.btnEditarPartida.Size = new System.Drawing.Size(190, 50);
            this.btnEditarPartida.TabIndex = 6;
            this.btnEditarPartida.Text = "Editar Partida";
            this.btnEditarPartida.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnEditarPartida.UseVisualStyleBackColor = false;
            this.btnEditarPartida.Click += new System.EventHandler(this.btnEditarPartida_Click);
            // 
            // btnNuevaCuenta
            // 
            this.btnNuevaCuenta.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnNuevaCuenta.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(174)))), ((int)(((byte)(96)))));
            this.btnNuevaCuenta.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNuevaCuenta.FlatAppearance.BorderSize = 0;
            this.btnNuevaCuenta.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNuevaCuenta.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btnNuevaCuenta.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNuevaCuenta.ForeColor = System.Drawing.Color.White;
            this.btnNuevaCuenta.IconChar = FontAwesome.Sharp.IconChar.Plus;
            this.btnNuevaCuenta.IconColor = System.Drawing.Color.White;
            this.btnNuevaCuenta.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnNuevaCuenta.IconSize = 40;
            this.btnNuevaCuenta.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNuevaCuenta.Location = new System.Drawing.Point(216, 3);
            this.btnNuevaCuenta.MinimumSize = new System.Drawing.Size(190, 50);
            this.btnNuevaCuenta.Name = "btnNuevaCuenta";
            this.btnNuevaCuenta.Rotation = 0D;
            this.btnNuevaCuenta.Size = new System.Drawing.Size(190, 50);
            this.btnNuevaCuenta.TabIndex = 15;
            this.btnNuevaCuenta.Text = "Nueva cuenta";
            this.btnNuevaCuenta.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnNuevaCuenta.UseVisualStyleBackColor = false;
            this.btnNuevaCuenta.Click += new System.EventHandler(this.btnNuevaCuenta_Click);
            // 
            // btnEliminarCuenta
            // 
            this.btnEliminarCuenta.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEliminarCuenta.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(69)))), ((int)(((byte)(96)))));
            this.btnEliminarCuenta.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEliminarCuenta.FlatAppearance.BorderSize = 0;
            this.btnEliminarCuenta.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminarCuenta.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btnEliminarCuenta.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminarCuenta.ForeColor = System.Drawing.Color.White;
            this.btnEliminarCuenta.IconChar = FontAwesome.Sharp.IconChar.TrashAlt;
            this.btnEliminarCuenta.IconColor = System.Drawing.Color.White;
            this.btnEliminarCuenta.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnEliminarCuenta.IconSize = 40;
            this.btnEliminarCuenta.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEliminarCuenta.Location = new System.Drawing.Point(12, 3);
            this.btnEliminarCuenta.MinimumSize = new System.Drawing.Size(190, 50);
            this.btnEliminarCuenta.Name = "btnEliminarCuenta";
            this.btnEliminarCuenta.Rotation = 0D;
            this.btnEliminarCuenta.Size = new System.Drawing.Size(198, 50);
            this.btnEliminarCuenta.TabIndex = 13;
            this.btnEliminarCuenta.Text = "Eliminar Cuenta";
            this.btnEliminarCuenta.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnEliminarCuenta.UseVisualStyleBackColor = false;
            this.btnEliminarCuenta.Click += new System.EventHandler(this.btnEliminarCuenta_Click);
            // 
            // label14
            // 
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.Color.Black;
            this.label14.Location = new System.Drawing.Point(674, 62);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(146, 23);
            this.label14.TabIndex = 41;
            this.label14.Text = "Tipo de cuenta";
            this.label14.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(270, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(198, 23);
            this.label2.TabIndex = 13;
            this.label2.Text = "Configuracion del IVA";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(42, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 37);
            this.label1.TabIndex = 12;
            this.label1.Text = "Monto ($)";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.tablePartida);
            this.panel1.Location = new System.Drawing.Point(40, 214);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(906, 190);
            this.panel1.TabIndex = 0;
            // 
            // tablePartida
            // 
            this.tablePartida.AllowUserToAddRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.tablePartida.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.tablePartida.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.tablePartida.BackgroundColor = System.Drawing.SystemColors.Control;
            this.tablePartida.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tablePartida.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(132)))), ((int)(((byte)(227)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI Symbol", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.tablePartida.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.tablePartida.ColumnHeadersHeight = 50;
            this.tablePartida.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnFecha,
            this.ColumnCodigo,
            this.ColumnDetalle,
            this.Column1Debe,
            this.ColumnHaber});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI Symbol", 11F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(229)))), ((int)(((byte)(244)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.tablePartida.DefaultCellStyle = dataGridViewCellStyle3;
            this.tablePartida.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tablePartida.DoubleBuffered = true;
            this.tablePartida.EnableHeadersVisualStyles = false;
            this.tablePartida.HeaderBgColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(132)))), ((int)(((byte)(227)))));
            this.tablePartida.HeaderForeColor = System.Drawing.Color.White;
            this.tablePartida.Location = new System.Drawing.Point(0, 0);
            this.tablePartida.Name = "tablePartida";
            this.tablePartida.ReadOnly = true;
            this.tablePartida.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.tablePartida.RowHeadersVisible = false;
            this.tablePartida.RowTemplate.Height = 40;
            this.tablePartida.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.tablePartida.Size = new System.Drawing.Size(906, 190);
            this.tablePartida.TabIndex = 1;
            // 
            // ColumnFecha
            // 
            this.ColumnFecha.HeaderText = "Fecha";
            this.ColumnFecha.Name = "ColumnFecha";
            this.ColumnFecha.ReadOnly = true;
            // 
            // ColumnCodigo
            // 
            this.ColumnCodigo.HeaderText = "Codigo";
            this.ColumnCodigo.Name = "ColumnCodigo";
            this.ColumnCodigo.ReadOnly = true;
            // 
            // ColumnDetalle
            // 
            this.ColumnDetalle.HeaderText = "Detalle";
            this.ColumnDetalle.Name = "ColumnDetalle";
            this.ColumnDetalle.ReadOnly = true;
            // 
            // Column1Debe
            // 
            this.Column1Debe.HeaderText = "Debe";
            this.Column1Debe.Name = "Column1Debe";
            this.Column1Debe.ReadOnly = true;
            // 
            // ColumnHaber
            // 
            this.ColumnHaber.HeaderText = "Haber";
            this.ColumnHaber.Name = "ColumnHaber";
            this.ColumnHaber.ReadOnly = true;
            // 
            // panelTop
            // 
            this.panelTop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(71)))), ((int)(((byte)(94)))));
            this.panelTop.Controls.Add(this.lblTitulo);
            this.panelTop.Controls.Add(this.btnMinimizar);
            this.panelTop.Controls.Add(this.btnRestoreWindow);
            this.panelTop.Controls.Add(this.btnMaximizar);
            this.panelTop.Controls.Add(this.btnExit);
            this.panelTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTop.Location = new System.Drawing.Point(0, 0);
            this.panelTop.Name = "panelTop";
            this.panelTop.Size = new System.Drawing.Size(1000, 40);
            this.panelTop.TabIndex = 6;
            // 
            // lblTitulo
            // 
            this.lblTitulo.Dock = System.Windows.Forms.DockStyle.Left;
            this.lblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold);
            this.lblTitulo.ForeColor = System.Drawing.Color.White;
            this.lblTitulo.Location = new System.Drawing.Point(0, 0);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(157, 40);
            this.lblTitulo.TabIndex = 15;
            this.lblTitulo.Text = "Texto Accion";
            this.lblTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnMinimizar
            // 
            this.btnMinimizar.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnMinimizar.FlatAppearance.BorderSize = 0;
            this.btnMinimizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMinimizar.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btnMinimizar.IconChar = FontAwesome.Sharp.IconChar.Minus;
            this.btnMinimizar.IconColor = System.Drawing.Color.White;
            this.btnMinimizar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnMinimizar.IconSize = 35;
            this.btnMinimizar.Location = new System.Drawing.Point(796, 0);
            this.btnMinimizar.Margin = new System.Windows.Forms.Padding(2);
            this.btnMinimizar.Name = "btnMinimizar";
            this.btnMinimizar.Rotation = 0D;
            this.btnMinimizar.Size = new System.Drawing.Size(51, 40);
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
            this.btnRestoreWindow.Location = new System.Drawing.Point(847, 0);
            this.btnRestoreWindow.Margin = new System.Windows.Forms.Padding(2);
            this.btnRestoreWindow.Name = "btnRestoreWindow";
            this.btnRestoreWindow.Rotation = 0D;
            this.btnRestoreWindow.Size = new System.Drawing.Size(51, 40);
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
            this.btnMaximizar.Location = new System.Drawing.Point(898, 0);
            this.btnMaximizar.Margin = new System.Windows.Forms.Padding(2);
            this.btnMaximizar.Name = "btnMaximizar";
            this.btnMaximizar.Rotation = 0D;
            this.btnMaximizar.Size = new System.Drawing.Size(51, 40);
            this.btnMaximizar.TabIndex = 2;
            this.btnMaximizar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnMaximizar.UseVisualStyleBackColor = true;
            this.btnMaximizar.Click += new System.EventHandler(this.btnMaximizar_Click);
            // 
            // btnExit
            // 
            this.btnExit.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnExit.FlatAppearance.BorderSize = 0;
            this.btnExit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(47)))), ((int)(((byte)(6)))));
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.Flip = FontAwesome.Sharp.FlipOrientation.Horizontal;
            this.btnExit.IconChar = FontAwesome.Sharp.IconChar.Times;
            this.btnExit.IconColor = System.Drawing.Color.White;
            this.btnExit.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnExit.IconSize = 35;
            this.btnExit.Location = new System.Drawing.Point(949, 0);
            this.btnExit.Margin = new System.Windows.Forms.Padding(2);
            this.btnExit.Name = "btnExit";
            this.btnExit.Rotation = 0D;
            this.btnExit.Size = new System.Drawing.Size(51, 40);
            this.btnExit.TabIndex = 1;
            this.btnExit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // MoverPanelTop
            // 
            this.MoverPanelTop.Fixed = true;
            this.MoverPanelTop.Horizontal = true;
            this.MoverPanelTop.TargetControl = this.panelTop;
            this.MoverPanelTop.Vertical = true;
            // 
            // MoverTitulo
            // 
            this.MoverTitulo.Fixed = true;
            this.MoverTitulo.Horizontal = true;
            this.MoverTitulo.TargetControl = this.lblTitulo;
            this.MoverTitulo.Vertical = true;
            // 
            // bordesTabla
            // 
            this.bordesTabla.ElipseRadius = 10;
            this.bordesTabla.TargetControl = this.tablePartida;
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 7;
            // 
            // bunifuElipse2
            // 
            this.bunifuElipse2.ElipseRadius = 7;
            // 
            // bunifuElipse3
            // 
            this.bunifuElipse3.ElipseRadius = 20;
            this.bunifuElipse3.TargetControl = this.btnAgregarPartida;
            // 
            // bunifuElipse4
            // 
            this.bunifuElipse4.ElipseRadius = 20;
            this.bunifuElipse4.TargetControl = this.btnEditarPartida;
            // 
            // bunifuElipse5
            // 
            this.bunifuElipse5.ElipseRadius = 20;
            this.bunifuElipse5.TargetControl = this.btnNuevaCuenta;
            // 
            // bunifuElipse6
            // 
            this.bunifuElipse6.ElipseRadius = 20;
            this.bunifuElipse6.TargetControl = this.btnEliminarCuenta;
            // 
            // bunifuElipse7
            // 
            this.bunifuElipse7.ElipseRadius = 10;
            this.bunifuElipse7.TargetControl = this.dpFecha;
            // 
            // licensing1
            // 
            this.licensing1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.licensing1.Font = new System.Drawing.Font("Segoe UI Semibold", 10F);
            this.licensing1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.licensing1.Location = new System.Drawing.Point(0, 0);
            this.licensing1.Margin = new System.Windows.Forms.Padding(6);
            this.licensing1.Name = "licensing1";
            this.licensing1.Size = new System.Drawing.Size(405, 500);
            this.licensing1.TabIndex = 0;
            // 
            // cbTipoTransaccion
            // 
            this.cbTipoTransaccion.BackColor = System.Drawing.Color.Transparent;
            this.cbTipoTransaccion.BaseColor = System.Drawing.Color.White;
            this.cbTipoTransaccion.BorderColor = System.Drawing.Color.Silver;
            this.cbTipoTransaccion.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbTipoTransaccion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbTipoTransaccion.FocusedColor = System.Drawing.Color.Empty;
            this.cbTipoTransaccion.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbTipoTransaccion.ForeColor = System.Drawing.Color.Black;
            this.cbTipoTransaccion.FormattingEnabled = true;
            this.cbTipoTransaccion.ItemHeight = 28;
            this.cbTipoTransaccion.Items.AddRange(new object[] {
            "Seleccione",
            "Debe",
            "Haber"});
            this.cbTipoTransaccion.Location = new System.Drawing.Point(43, 164);
            this.cbTipoTransaccion.Name = "cbTipoTransaccion";
            this.cbTipoTransaccion.OnHoverItemBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.cbTipoTransaccion.OnHoverItemForeColor = System.Drawing.Color.White;
            this.cbTipoTransaccion.Size = new System.Drawing.Size(175, 34);
            this.cbTipoTransaccion.StartIndex = 0;
            this.cbTipoTransaccion.TabIndex = 69;
            // 
            // cbCuenta
            // 
            this.cbCuenta.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cbCuenta.BackColor = System.Drawing.Color.Transparent;
            this.cbCuenta.BaseColor = System.Drawing.Color.White;
            this.cbCuenta.BorderColor = System.Drawing.Color.Silver;
            this.cbCuenta.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbCuenta.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbCuenta.FocusedColor = System.Drawing.Color.Empty;
            this.cbCuenta.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbCuenta.ForeColor = System.Drawing.Color.Black;
            this.cbCuenta.FormattingEnabled = true;
            this.cbCuenta.IntegralHeight = false;
            this.cbCuenta.ItemHeight = 28;
            this.cbCuenta.Items.AddRange(new object[] {
            "Seleccionar"});
            this.cbCuenta.Location = new System.Drawing.Point(678, 95);
            this.cbCuenta.Name = "cbCuenta";
            this.cbCuenta.OnHoverItemBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.cbCuenta.OnHoverItemForeColor = System.Drawing.Color.White;
            this.cbCuenta.Size = new System.Drawing.Size(282, 34);
            this.cbCuenta.StartIndex = 0;
            this.cbCuenta.TabIndex = 71;
            // 
            // txtMonto
            // 
            this.txtMonto.BaseColor = System.Drawing.Color.White;
            this.txtMonto.BorderColor = System.Drawing.Color.Silver;
            this.txtMonto.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtMonto.FocusedBaseColor = System.Drawing.Color.White;
            this.txtMonto.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(151)))), ((int)(((byte)(230)))));
            this.txtMonto.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txtMonto.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.txtMonto.Location = new System.Drawing.Point(46, 90);
            this.txtMonto.Name = "txtMonto";
            this.txtMonto.PasswordChar = '\0';
            this.txtMonto.Size = new System.Drawing.Size(172, 35);
            this.txtMonto.TabIndex = 72;
            this.txtMonto.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtMonto_KeyPress);
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.BaseColor = System.Drawing.Color.White;
            this.txtDescripcion.BorderColor = System.Drawing.Color.Silver;
            this.txtDescripcion.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtDescripcion.FocusedBaseColor = System.Drawing.Color.White;
            this.txtDescripcion.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(151)))), ((int)(((byte)(230)))));
            this.txtDescripcion.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txtDescripcion.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDescripcion.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.txtDescripcion.Location = new System.Drawing.Point(40, 540);
            this.txtDescripcion.MultiLine = true;
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.PasswordChar = '\0';
            this.txtDescripcion.Size = new System.Drawing.Size(906, 76);
            this.txtDescripcion.TabIndex = 73;
            // 
            // cbDebito
            // 
            this.cbDebito.BaseColor = System.Drawing.Color.White;
            this.cbDebito.CheckedOffColor = System.Drawing.Color.Gray;
            this.cbDebito.CheckedOnColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(174)))), ((int)(((byte)(96)))));
            this.cbDebito.Enabled = false;
            this.cbDebito.FillColor = System.Drawing.Color.White;
            this.cbDebito.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbDebito.Location = new System.Drawing.Point(503, 99);
            this.cbDebito.Name = "cbDebito";
            this.cbDebito.Size = new System.Drawing.Size(89, 26);
            this.cbDebito.TabIndex = 75;
            this.cbDebito.Text = "Debito";
            this.cbDebito.Click += new System.EventHandler(this.cbDebito_Click);
            // 
            // cbCredito
            // 
            this.cbCredito.BaseColor = System.Drawing.Color.White;
            this.cbCredito.CheckedOffColor = System.Drawing.Color.Gray;
            this.cbCredito.CheckedOnColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(174)))), ((int)(((byte)(96)))));
            this.cbCredito.Enabled = false;
            this.cbCredito.FillColor = System.Drawing.Color.White;
            this.cbCredito.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbCredito.Location = new System.Drawing.Point(503, 139);
            this.cbCredito.Name = "cbCredito";
            this.cbCredito.Size = new System.Drawing.Size(96, 26);
            this.cbCredito.TabIndex = 76;
            this.cbCredito.Text = "Credito";
            this.cbCredito.Click += new System.EventHandler(this.cbCredito_Click);
            // 
            // cbExcento
            // 
            this.cbExcento.BaseColor = System.Drawing.Color.White;
            this.cbExcento.Checked = true;
            this.cbExcento.CheckedOffColor = System.Drawing.Color.Gray;
            this.cbExcento.CheckedOnColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(174)))), ((int)(((byte)(96)))));
            this.cbExcento.FillColor = System.Drawing.Color.White;
            this.cbExcento.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbExcento.Location = new System.Drawing.Point(274, 95);
            this.cbExcento.Name = "cbExcento";
            this.cbExcento.Size = new System.Drawing.Size(103, 26);
            this.cbExcento.TabIndex = 78;
            this.cbExcento.Text = "Excento";
            this.cbExcento.Click += new System.EventHandler(this.cbExcento_Click);
            // 
            // cbIncluido
            // 
            this.cbIncluido.BaseColor = System.Drawing.Color.White;
            this.cbIncluido.CheckedOffColor = System.Drawing.Color.Gray;
            this.cbIncluido.CheckedOnColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(174)))), ((int)(((byte)(96)))));
            this.cbIncluido.FillColor = System.Drawing.Color.White;
            this.cbIncluido.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbIncluido.Location = new System.Drawing.Point(274, 173);
            this.cbIncluido.Name = "cbIncluido";
            this.cbIncluido.Size = new System.Drawing.Size(100, 26);
            this.cbIncluido.TabIndex = 80;
            this.cbIncluido.Text = "Incluido";
            this.cbIncluido.Click += new System.EventHandler(this.cbIncluido_Click);
            // 
            // cbMasIva
            // 
            this.cbMasIva.BaseColor = System.Drawing.Color.White;
            this.cbMasIva.CheckedOffColor = System.Drawing.Color.Gray;
            this.cbMasIva.CheckedOnColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(174)))), ((int)(((byte)(96)))));
            this.cbMasIva.FillColor = System.Drawing.Color.White;
            this.cbMasIva.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbMasIva.Location = new System.Drawing.Point(274, 135);
            this.cbMasIva.Name = "cbMasIva";
            this.cbMasIva.Size = new System.Drawing.Size(81, 26);
            this.cbMasIva.TabIndex = 79;
            this.cbMasIva.Text = "+ IVA";
            this.cbMasIva.Click += new System.EventHandler(this.cbMasIva_Click);
            // 
            // AgregarPartidaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1000, 770);
            this.Controls.Add(this.panelContenedor);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AgregarPartidaForm";
            this.Text = "AgregarPartidaForm";
            this.panelContenedor.ResumeLayout(false);
            this.panelContenido.ResumeLayout(false);
            this.panelContenido.PerformLayout();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tablePartida)).EndInit();
            this.panelTop.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelContenedor;
        private System.Windows.Forms.Panel panelTop;
        private FontAwesome.Sharp.IconButton btnMinimizar;
        private FontAwesome.Sharp.IconButton btnRestoreWindow;
        private FontAwesome.Sharp.IconButton btnMaximizar;
        private FontAwesome.Sharp.IconButton btnExit;
        private System.Windows.Forms.Panel panelContenido;
        private Bunifu.Framework.UI.BunifuDragControl MoverPanelTop;
        private System.Windows.Forms.Label lblTitulo;
        private Bunifu.Framework.UI.BunifuDragControl MoverTitulo;
        private System.Windows.Forms.Panel panel1;
        private Bunifu.Framework.UI.BunifuCustomDataGrid tablePartida;
        private Bunifu.Framework.UI.BunifuElipse bordesTabla;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label14;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse2;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse3;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private FontAwesome.Sharp.IconButton btnEditarPartida;
        private FontAwesome.Sharp.IconButton btnNuevaCuenta;
        private FontAwesome.Sharp.IconButton btnEliminarCuenta;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse4;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse5;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse6;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label3;
        private Bunifu.Framework.UI.BunifuDatepicker dpFecha;
        private System.Windows.Forms.Label lblPartida;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnFecha;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnCodigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnDetalle;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1Debe;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnHaber;
        private System.Windows.Forms.Label label7;
        private FontAwesome.Sharp.IconButton btnAgregarPartida;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse7;
        private Guna.UI.WinForms.GunaComboBox cbCuenta;
        private Guna.UI.WinForms.GunaComboBox cbTipoTransaccion;
        private Guna.UI.WinForms.Licensing licensing1;
        private Guna.UI.WinForms.GunaTextBox txtMonto;
        private Guna.UI.WinForms.GunaCheckBox cbCredito;
        private Guna.UI.WinForms.GunaCheckBox cbDebito;
        private Guna.UI.WinForms.GunaTextBox txtDescripcion;
        private Guna.UI.WinForms.GunaCheckBox cbIncluido;
        private Guna.UI.WinForms.GunaCheckBox cbMasIva;
        private Guna.UI.WinForms.GunaCheckBox cbExcento;
    }
}