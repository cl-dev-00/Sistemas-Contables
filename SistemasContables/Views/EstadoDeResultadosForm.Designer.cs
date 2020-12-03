namespace SistemasContables.Views
{
    partial class EstadoDeResultadosForm
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
            this.panelTabla = new System.Windows.Forms.Panel();
            this.tableEstadoDeResultados = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.ColumnOperacion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnCuentas = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnTotales = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.lblTitulo = new System.Windows.Forms.Label();
            this.lblPeriodo = new System.Windows.Forms.Label();
            this.panelTabla.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tableEstadoDeResultados)).BeginInit();
            this.SuspendLayout();
            // 
            // panelTabla
            // 
            this.panelTabla.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelTabla.Controls.Add(this.tableEstadoDeResultados);
            this.panelTabla.Location = new System.Drawing.Point(73, 199);
            this.panelTabla.Name = "panelTabla";
            this.panelTabla.Size = new System.Drawing.Size(801, 459);
            this.panelTabla.TabIndex = 7;
            // 
            // tableEstadoDeResultados
            // 
            this.tableEstadoDeResultados.AllowUserToAddRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.tableEstadoDeResultados.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.tableEstadoDeResultados.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.tableEstadoDeResultados.BackgroundColor = System.Drawing.SystemColors.Control;
            this.tableEstadoDeResultados.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tableEstadoDeResultados.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(132)))), ((int)(((byte)(227)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI Symbol", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.tableEstadoDeResultados.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.tableEstadoDeResultados.ColumnHeadersHeight = 50;
            this.tableEstadoDeResultados.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnOperacion,
            this.ColumnCuentas,
            this.ColumnTotales});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI Symbol", 11F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(229)))), ((int)(((byte)(244)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.tableEstadoDeResultados.DefaultCellStyle = dataGridViewCellStyle3;
            this.tableEstadoDeResultados.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableEstadoDeResultados.DoubleBuffered = true;
            this.tableEstadoDeResultados.EnableHeadersVisualStyles = false;
            this.tableEstadoDeResultados.HeaderBgColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(132)))), ((int)(((byte)(227)))));
            this.tableEstadoDeResultados.HeaderForeColor = System.Drawing.Color.White;
            this.tableEstadoDeResultados.Location = new System.Drawing.Point(0, 0);
            this.tableEstadoDeResultados.Name = "tableEstadoDeResultados";
            this.tableEstadoDeResultados.ReadOnly = true;
            this.tableEstadoDeResultados.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.tableEstadoDeResultados.RowHeadersVisible = false;
            this.tableEstadoDeResultados.RowTemplate.Height = 40;
            this.tableEstadoDeResultados.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.tableEstadoDeResultados.Size = new System.Drawing.Size(801, 459);
            this.tableEstadoDeResultados.TabIndex = 0;
            // 
            // ColumnOperacion
            // 
            this.ColumnOperacion.HeaderText = "Operacion";
            this.ColumnOperacion.Name = "ColumnOperacion";
            this.ColumnOperacion.ReadOnly = true;
            // 
            // ColumnCuentas
            // 
            this.ColumnCuentas.HeaderText = "Cuenta";
            this.ColumnCuentas.Name = "ColumnCuentas";
            this.ColumnCuentas.ReadOnly = true;
            // 
            // ColumnTotales
            // 
            this.ColumnTotales.HeaderText = "Totales";
            this.ColumnTotales.Name = "ColumnTotales";
            this.ColumnTotales.ReadOnly = true;
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 7;
            this.bunifuElipse1.TargetControl = this.tableEstadoDeResultados;
            // 
            // lblTitulo
            // 
            this.lblTitulo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold);
            this.lblTitulo.Location = new System.Drawing.Point(336, 24);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(295, 33);
            this.lblTitulo.TabIndex = 17;
            this.lblTitulo.Text = "Estado de Resultados";
            this.lblTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblPeriodo
            // 
            this.lblPeriodo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblPeriodo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPeriodo.Location = new System.Drawing.Point(174, 69);
            this.lblPeriodo.Name = "lblPeriodo";
            this.lblPeriodo.Size = new System.Drawing.Size(600, 35);
            this.lblPeriodo.TabIndex = 18;
            this.lblPeriodo.Text = "texto periodo";
            this.lblPeriodo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // EstadoDeResultadosForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(948, 710);
            this.Controls.Add(this.lblPeriodo);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.panelTabla);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "EstadoDeResultadosForm";
            this.Text = "EstadoDeResultadosForm";
            this.panelTabla.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tableEstadoDeResultados)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panelTabla;
        private Bunifu.Framework.UI.BunifuCustomDataGrid tableEstadoDeResultados;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnOperacion;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnCuentas;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnTotales;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label lblPeriodo;
    }
}