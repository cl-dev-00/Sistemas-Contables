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

        public LibroDiarioForm()
        {
            InitializeComponent();

            tableLibroDiario.Rows.Add(1, 0, 0, 0);
            tableLibroDiario.Rows.Add(2, 0, 0, 0);
            tableLibroDiario.Rows.Add(3, 0, 0, 0);
            tableLibroDiario.Rows.Add(4, 0, 0, 0);
            tableLibroDiario.Rows.Add(5, 0, 0, 0);
            tableLibroDiario.Rows.Add(6, 0, 0, 0);
            tableLibroDiario.Rows.Add(1, 0, 0, 0);
            tableLibroDiario.Rows.Add(2, 0, 0, 0);
            tableLibroDiario.Rows.Add(3, 0, 0, 0);
            tableLibroDiario.Rows.Add(4, 0, 0, 0);
            tableLibroDiario.Rows.Add(5, 0, 0, 0);
            tableLibroDiario.Rows.Add(6, 0, 0, 0);
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            agregarPartidaForm = new AgregarPartidaForm();
            this.Parent.Parent.Parent.Visible = false;
            agregarPartidaForm.ShowDialog();
            this.Parent.Parent.Parent.Visible = true;
        }
    }
}
