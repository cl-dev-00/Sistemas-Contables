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
            this.chart.Series["grafico"].Points.AddXY("Enero", 10);
            this.chart.Series["grafico"].Points.AddXY("Febrero", 20);
            this.chart.Series["grafico"].Points.AddXY("Marzo", 40);
            this.chart.Series["grafico"].Points.AddXY("Abril", 25);
            this.chart.Series["grafico"].Points.AddXY("Mayo", 60);
            this.chart.Series["grafico"].Points.AddXY("Junio", 40);
            this.chart.Series["grafico"].Points.AddXY("Julio", 65);
            this.chart.Series["grafico"].Points.AddXY("Agosto", 40);
            this.chart.Series["grafico"].Points.AddXY("Septiembre", 25);
            this.chart.Series["grafico"].Points.AddXY("Octubre", 60);
            this.chart.Series["grafico"].Points.AddXY("Noviembre", 40);
            this.chart.Series["grafico"].Points.AddXY("Diciembre", 65);

        }

    }
}
