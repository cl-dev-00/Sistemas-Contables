using SistemasContables.controller;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemasContables.Views
{
    public partial class InicioForm : Form
    {
        //Lo uso para que sea punto ( . ) el separador de decimales, va cuando se hace .ToString("", formatoDecimales)
        private NumberFormatInfo formatoDecimales = new CultureInfo("en-US", false).NumberFormat;

        public InicioForm(LibroDiariosController libroDiarioController)
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

            lblActivos.Text = "$ " + redondear(libroDiarioController.total("activos"));
            lblCapital.Text = "$ " + redondear(libroDiarioController.total("capital"));
            lblPasivos.Text = "$ " + redondear(libroDiarioController.total("pasivos"));
            lblIngresos.Text = "$ " + redondear(libroDiarioController.total("ingresos"));
            lblCostos.Text = "$ " + redondear(libroDiarioController.total("costos"));
            lblGastos.Text = "$ " + redondear(libroDiarioController.total("gastos"));

        }

        // el metodo retorna un formato #.00 a los decimales de un string
        private string redondear(double cantidad)
        {
            return cantidad.ToString("0.00", formatoDecimales);
        }

    }
}
