namespace SistemasContables.Views
{
    partial class BalanceGeneralForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnImprimir = new FontAwesome.Sharp.IconButton();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.lblPeriodo = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panelActivos = new System.Windows.Forms.Panel();
            this.panelPasivosCapital = new System.Windows.Forms.Panel();
            this.gunaElipse1 = new Guna.UI.WinForms.GunaElipse(this.components);
            this.ColumnHaberPasivo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnPasivos = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tablePasivosCapital = new Guna.UI.WinForms.GunaDataGridView();
            this.ColumnDebeActivos = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnActivos = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tableActivos = new Guna.UI.WinForms.GunaDataGridView();
            this.panelActivos.SuspendLayout();
            this.panelPasivosCapital.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tablePasivosCapital)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tableActivos)).BeginInit();
            this.SuspendLayout();
            // 
            // btnImprimir
            // 
            this.btnImprimir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(58)))), ((int)(((byte)(71)))));
            this.btnImprimir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnImprimir.FlatAppearance.BorderSize = 0;
            this.btnImprimir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnImprimir.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btnImprimir.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnImprimir.ForeColor = System.Drawing.Color.White;
            this.btnImprimir.IconChar = FontAwesome.Sharp.IconChar.FilePdf;
            this.btnImprimir.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(69)))), ((int)(((byte)(96)))));
            this.btnImprimir.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnImprimir.IconSize = 40;
            this.btnImprimir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnImprimir.Location = new System.Drawing.Point(73, 143);
            this.btnImprimir.Margin = new System.Windows.Forms.Padding(0, 3, 3, 3);
            this.btnImprimir.MinimumSize = new System.Drawing.Size(140, 50);
            this.btnImprimir.Name = "btnImprimir";
            this.btnImprimir.Rotation = 0D;
            this.btnImprimir.Size = new System.Drawing.Size(140, 50);
            this.btnImprimir.TabIndex = 7;
            this.btnImprimir.Text = "Imprimir";
            this.btnImprimir.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnImprimir.UseVisualStyleBackColor = false;
            // 
            // lblTitulo
            // 
            this.lblTitulo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold);
            this.lblTitulo.Location = new System.Drawing.Point(368, 24);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(228, 33);
            this.lblTitulo.TabIndex = 16;
            this.lblTitulo.Text = "Balance General";
            this.lblTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblPeriodo
            // 
            this.lblPeriodo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblPeriodo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPeriodo.Location = new System.Drawing.Point(174, 69);
            this.lblPeriodo.Name = "lblPeriodo";
            this.lblPeriodo.Size = new System.Drawing.Size(600, 32);
            this.lblPeriodo.TabIndex = 17;
            this.lblPeriodo.Text = "texto periodo";
            this.lblPeriodo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(59, 602);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(397, 40);
            this.label1.TabIndex = 18;
            this.label1.Text = "texto periodo";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(480, 602);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(393, 40);
            this.label2.TabIndex = 19;
            this.label2.Text = "texto periodo";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panelActivos
            // 
            this.panelActivos.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.panelActivos.Controls.Add(this.tableActivos);
            this.panelActivos.Location = new System.Drawing.Point(73, 202);
            this.panelActivos.Name = "panelActivos";
            this.panelActivos.Size = new System.Drawing.Size(380, 397);
            this.panelActivos.TabIndex = 36;
            // 
            // panelPasivosCapital
            // 
            this.panelPasivosCapital.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelPasivosCapital.Controls.Add(this.tablePasivosCapital);
            this.panelPasivosCapital.Location = new System.Drawing.Point(493, 202);
            this.panelPasivosCapital.Name = "panelPasivosCapital";
            this.panelPasivosCapital.Size = new System.Drawing.Size(380, 397);
            this.panelPasivosCapital.TabIndex = 37;
            // 
            // gunaElipse1
            // 
            this.gunaElipse1.Radius = 10;
            this.gunaElipse1.TargetControl = this.btnImprimir;
            // 
            // ColumnHaberPasivo
            // 
            this.ColumnHaberPasivo.FillWeight = 65F;
            this.ColumnHaberPasivo.HeaderText = "Cantidad ($)";
            this.ColumnHaberPasivo.Name = "ColumnHaberPasivo";
            this.ColumnHaberPasivo.ReadOnly = true;
            // 
            // ColumnPasivos
            // 
            this.ColumnPasivos.FillWeight = 135F;
            this.ColumnPasivos.HeaderText = "Pasivos y Capital";
            this.ColumnPasivos.Name = "ColumnPasivos";
            this.ColumnPasivos.ReadOnly = true;
            // 
            // tablePasivosCapital
            // 
            this.tablePasivosCapital.AllowUserToAddRows = false;
            this.tablePasivosCapital.AllowUserToDeleteRows = false;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            this.tablePasivosCapital.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            this.tablePasivosCapital.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.tablePasivosCapital.BackgroundColor = System.Drawing.SystemColors.Control;
            this.tablePasivosCapital.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tablePasivosCapital.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.tablePasivosCapital.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(95)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(113)))), ((int)(((byte)(88)))), ((int)(((byte)(226)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.tablePasivosCapital.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.tablePasivosCapital.ColumnHeadersHeight = 40;
            this.tablePasivosCapital.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnPasivos,
            this.ColumnHaberPasivo});
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.tablePasivosCapital.DefaultCellStyle = dataGridViewCellStyle6;
            this.tablePasivosCapital.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tablePasivosCapital.EnableHeadersVisualStyles = false;
            this.tablePasivosCapital.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.tablePasivosCapital.Location = new System.Drawing.Point(0, 0);
            this.tablePasivosCapital.Name = "tablePasivosCapital";
            this.tablePasivosCapital.ReadOnly = true;
            this.tablePasivosCapital.RowHeadersVisible = false;
            this.tablePasivosCapital.RowHeadersWidth = 40;
            this.tablePasivosCapital.RowTemplate.Height = 40;
            this.tablePasivosCapital.RowTemplate.ReadOnly = true;
            this.tablePasivosCapital.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.tablePasivosCapital.Size = new System.Drawing.Size(380, 397);
            this.tablePasivosCapital.TabIndex = 35;
            this.tablePasivosCapital.Theme = Guna.UI.WinForms.GunaDataGridViewPresetThemes.Guna;
            this.tablePasivosCapital.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.tablePasivosCapital.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.tablePasivosCapital.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.tablePasivosCapital.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.tablePasivosCapital.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.tablePasivosCapital.ThemeStyle.BackColor = System.Drawing.SystemColors.Control;
            this.tablePasivosCapital.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.tablePasivosCapital.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(95)))), ((int)(((byte)(255)))));
            this.tablePasivosCapital.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.tablePasivosCapital.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tablePasivosCapital.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.tablePasivosCapital.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.tablePasivosCapital.ThemeStyle.HeaderStyle.Height = 40;
            this.tablePasivosCapital.ThemeStyle.ReadOnly = true;
            this.tablePasivosCapital.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.tablePasivosCapital.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.tablePasivosCapital.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.tablePasivosCapital.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.tablePasivosCapital.ThemeStyle.RowsStyle.Height = 40;
            this.tablePasivosCapital.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.tablePasivosCapital.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            // 
            // ColumnDebeActivos
            // 
            this.ColumnDebeActivos.FillWeight = 65F;
            this.ColumnDebeActivos.HeaderText = "Cantidad ($)";
            this.ColumnDebeActivos.Name = "ColumnDebeActivos";
            this.ColumnDebeActivos.ReadOnly = true;
            // 
            // ColumnActivos
            // 
            this.ColumnActivos.FillWeight = 135F;
            this.ColumnActivos.HeaderText = "Activos";
            this.ColumnActivos.Name = "ColumnActivos";
            this.ColumnActivos.ReadOnly = true;
            // 
            // tableActivos
            // 
            this.tableActivos.AllowUserToAddRows = false;
            this.tableActivos.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.tableActivos.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.tableActivos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.tableActivos.BackgroundColor = System.Drawing.SystemColors.Control;
            this.tableActivos.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tableActivos.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.tableActivos.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(95)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(113)))), ((int)(((byte)(88)))), ((int)(((byte)(226)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.tableActivos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.tableActivos.ColumnHeadersHeight = 40;
            this.tableActivos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnActivos,
            this.ColumnDebeActivos});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.tableActivos.DefaultCellStyle = dataGridViewCellStyle3;
            this.tableActivos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableActivos.EnableHeadersVisualStyles = false;
            this.tableActivos.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.tableActivos.Location = new System.Drawing.Point(0, 0);
            this.tableActivos.Name = "tableActivos";
            this.tableActivos.ReadOnly = true;
            this.tableActivos.RowHeadersVisible = false;
            this.tableActivos.RowHeadersWidth = 40;
            this.tableActivos.RowTemplate.Height = 40;
            this.tableActivos.RowTemplate.ReadOnly = true;
            this.tableActivos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.tableActivos.Size = new System.Drawing.Size(380, 397);
            this.tableActivos.TabIndex = 35;
            this.tableActivos.Theme = Guna.UI.WinForms.GunaDataGridViewPresetThemes.Guna;
            this.tableActivos.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.tableActivos.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.tableActivos.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.tableActivos.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.tableActivos.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.tableActivos.ThemeStyle.BackColor = System.Drawing.SystemColors.Control;
            this.tableActivos.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.tableActivos.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(95)))), ((int)(((byte)(255)))));
            this.tableActivos.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.tableActivos.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tableActivos.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.tableActivos.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.tableActivos.ThemeStyle.HeaderStyle.Height = 40;
            this.tableActivos.ThemeStyle.ReadOnly = true;
            this.tableActivos.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.tableActivos.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.tableActivos.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.tableActivos.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.tableActivos.ThemeStyle.RowsStyle.Height = 40;
            this.tableActivos.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.tableActivos.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            // 
            // BalanceGeneralForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(948, 710);
            this.Controls.Add(this.panelPasivosCapital);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panelActivos);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnImprimir);
            this.Controls.Add(this.lblPeriodo);
            this.Controls.Add(this.lblTitulo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "BalanceGeneralForm";
            this.Text = "BalanceGeneralForm";
            this.panelActivos.ResumeLayout(false);
            this.panelPasivosCapital.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tablePasivosCapital)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tableActivos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label lblPeriodo;
        private FontAwesome.Sharp.IconButton btnImprimir;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panelActivos;
        private System.Windows.Forms.Panel panelPasivosCapital;
        private Guna.UI.WinForms.GunaElipse gunaElipse1;
        private Guna.UI.WinForms.GunaDataGridView tableActivos;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnActivos;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnDebeActivos;
        private Guna.UI.WinForms.GunaDataGridView tablePasivosCapital;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnPasivos;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnHaberPasivo;
    }
}