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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panelTabla = new System.Windows.Forms.Panel();
            this.tableBalanceGeneral = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.ColumnActivos = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnDebeActivos = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnPasivos = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnHaberPasivo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.bunifuElipse2 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.bunifuElipse3 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.bunifuElipse4 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.bunifuElipse5 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.lblTitulo = new System.Windows.Forms.Label();
            this.panelTabla.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tableBalanceGeneral)).BeginInit();
            this.SuspendLayout();
            // 
            // panelTabla
            // 
            this.panelTabla.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelTabla.Controls.Add(this.tableBalanceGeneral);
            this.panelTabla.Location = new System.Drawing.Point(63, 161);
            this.panelTabla.Name = "panelTabla";
            this.panelTabla.Size = new System.Drawing.Size(816, 491);
            this.panelTabla.TabIndex = 7;
            // 
            // tableBalanceGeneral
            // 
            this.tableBalanceGeneral.AllowUserToAddRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.tableBalanceGeneral.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.tableBalanceGeneral.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.tableBalanceGeneral.BackgroundColor = System.Drawing.SystemColors.Control;
            this.tableBalanceGeneral.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tableBalanceGeneral.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(132)))), ((int)(((byte)(227)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI Symbol", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.tableBalanceGeneral.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.tableBalanceGeneral.ColumnHeadersHeight = 50;
            this.tableBalanceGeneral.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnActivos,
            this.ColumnDebeActivos,
            this.ColumnPasivos,
            this.ColumnHaberPasivo});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI Symbol", 11F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(229)))), ((int)(((byte)(244)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.tableBalanceGeneral.DefaultCellStyle = dataGridViewCellStyle3;
            this.tableBalanceGeneral.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableBalanceGeneral.DoubleBuffered = true;
            this.tableBalanceGeneral.EnableHeadersVisualStyles = false;
            this.tableBalanceGeneral.HeaderBgColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(132)))), ((int)(((byte)(227)))));
            this.tableBalanceGeneral.HeaderForeColor = System.Drawing.Color.White;
            this.tableBalanceGeneral.Location = new System.Drawing.Point(0, 0);
            this.tableBalanceGeneral.Name = "tableBalanceGeneral";
            this.tableBalanceGeneral.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.tableBalanceGeneral.RowHeadersVisible = false;
            this.tableBalanceGeneral.RowTemplate.Height = 40;
            this.tableBalanceGeneral.Size = new System.Drawing.Size(816, 491);
            this.tableBalanceGeneral.TabIndex = 0;
            // 
            // ColumnActivos
            // 
            this.ColumnActivos.HeaderText = "Activos";
            this.ColumnActivos.Name = "ColumnActivos";
            // 
            // ColumnDebeActivos
            // 
            this.ColumnDebeActivos.HeaderText = "Cantidad ($)";
            this.ColumnDebeActivos.Name = "ColumnDebeActivos";
            // 
            // ColumnPasivos
            // 
            this.ColumnPasivos.HeaderText = "Pasivos y Capital";
            this.ColumnPasivos.Name = "ColumnPasivos";
            // 
            // ColumnHaberPasivo
            // 
            this.ColumnHaberPasivo.HeaderText = "Cantidad ($)";
            this.ColumnHaberPasivo.Name = "ColumnHaberPasivo";
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 7;
            this.bunifuElipse1.TargetControl = this.tableBalanceGeneral;
            // 
            // bunifuElipse2
            // 
            this.bunifuElipse2.ElipseRadius = 20;
            // 
            // bunifuElipse3
            // 
            this.bunifuElipse3.ElipseRadius = 20;
            // 
            // bunifuElipse4
            // 
            this.bunifuElipse4.ElipseRadius = 20;
            // 
            // bunifuElipse5
            // 
            this.bunifuElipse5.ElipseRadius = 20;
            // 
            // lblTitulo
            // 
            this.lblTitulo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold);
            this.lblTitulo.Location = new System.Drawing.Point(368, 54);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(228, 33);
            this.lblTitulo.TabIndex = 16;
            this.lblTitulo.Text = "Balance General";
            this.lblTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // BalanceGeneralForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(948, 710);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.panelTabla);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "BalanceGeneralForm";
            this.Text = "BalanceGeneralForm";
            this.panelTabla.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tableBalanceGeneral)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panelTabla;
        private Bunifu.Framework.UI.BunifuCustomDataGrid tableBalanceGeneral;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse2;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse3;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse4;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnActivos;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnDebeActivos;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnPasivos;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnHaberPasivo;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse5;
        private System.Windows.Forms.Label lblTitulo;
    }
}