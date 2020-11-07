using SistemasContables.DataBase;
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
    public partial class InicioForm : Form
    {
        private Conexion conexion;

        public InicioForm()
        {
            InitializeComponent();
            this.chart.Series["grafico"].Points.AddXY("Lunes", 10);
            this.chart.Series["grafico"].Points.AddXY("Martes", 20);
            this.chart.Series["grafico"].Points.AddXY("Miercoles", 40);
            this.chart.Series["grafico"].Points.AddXY("Jueves", 25);
            this.chart.Series["grafico"].Points.AddXY("Viernes", 60);
            this.chart.Series["grafico"].Points.AddXY("Sabado", 40);
            this.chart.Series["grafico"].Points.AddXY("Domingo", 65);
        }

        private void btnConectar_Click(object sender, EventArgs e)
        {
            conexion = new Conexion();
        }
    }
}
