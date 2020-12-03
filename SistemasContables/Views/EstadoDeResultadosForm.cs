using SistemasContables.controller;
using SistemasContables.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Globalization;

namespace SistemasContables.Views
{
  
    public partial class EstadoDeResultadosForm : Form
    {
        //Lo uso para que sea punto ( . ) el separador de decimales, va cuando se hace .ToString("", nfi)
        NumberFormatInfo nfi = new CultureInfo("en-US", false).NumberFormat;

        private EstadoDeResultadosController estadoDeResultadosController;
        private double gastos_de_operacion = 0;
        private double utilidad_de_operacion = 0;
        private double reserva_legal = 0;
        private double utilidad_antes_de_impuestos = 0;
        private double impuestos_por_pagar = 0;
        private double utilidad_neta = 0;

        public EstadoDeResultadosForm(LibroDiario libroDiario)
        {
            InitializeComponent();

            lblPeriodo.Text = libroDiario.Periodo;

            estadoDeResultadosController = new EstadoDeResultadosController();

            llenarTablaEstadoDeResultados(libroDiario.IdLibroDiario); 

        }

        public void llenarTablaEstadoDeResultados(int idLibroDiario)
        {
            if (tableEstadoDeResultados.Rows.Count > 0)
            {
                tableEstadoDeResultados.Rows.Clear();
            }

            double ingresos = estadoDeResultadosController.getIngresos_(idLibroDiario);
            double costos = estadoDeResultadosController.getCostos_(idLibroDiario);
            double gastos = estadoDeResultadosController.getGastos_(idLibroDiario);
            double ingresosmenoscostos = ingresos - costos; 

            gastos_de_operacion = gastos;
            utilidad_de_operacion = ingresosmenoscostos - gastos;
            reserva_legal = (ingresosmenoscostos - gastos) * 0.07;
            utilidad_antes_de_impuestos = (utilidad_de_operacion) - ((utilidad_de_operacion) * 0.07);

            if (ingresos < 150000)
            {      
               impuestos_por_pagar = utilidad_antes_de_impuestos * 0.25;
            }
            else
            {
                impuestos_por_pagar = utilidad_antes_de_impuestos * 0.3;
            }

            utilidad_neta = utilidad_antes_de_impuestos - impuestos_por_pagar;

            /* Agregando valores a la tabla*/

            tableEstadoDeResultados.Rows.Add("", "Ingresos", "$"+ Math.Round(ingresos, 2).ToString("0.00", nfi));
            tableEstadoDeResultados.Rows.Add("( - )", "Costos", "$ " + Math.Round(costos, 2).ToString("0.00", nfi));
            tableEstadoDeResultados.Rows.Add("( = )", "Utilidad Bruta", "$ " + Math.Round(ingresosmenoscostos, 2).ToString("0.00", nfi));
            tableEstadoDeResultados.Rows.Add("( - )", "Gastos de Operacion", "$ " + Math.Round(gastos_de_operacion, 2).ToString("0.00", nfi));
            tableEstadoDeResultados.Rows.Add("( = )", "Utilidad de Operación", "$ " + Math.Round(utilidad_de_operacion, 2).ToString("0.00", nfi));
            tableEstadoDeResultados.Rows.Add("( - )", "Reserva Legal", "$ " + Math.Round(reserva_legal, 2).ToString("0.00", nfi));
            tableEstadoDeResultados.Rows.Add("( = )", "Utilidad Antes de Impuestos", "$ " + Math.Round(utilidad_antes_de_impuestos, 2).ToString("0.00", nfi));
            tableEstadoDeResultados.Rows.Add("( - )", "Impuestos Por Pagar", "$ " + Math.Round(impuestos_por_pagar, 2).ToString("0.00", nfi));
            tableEstadoDeResultados.Rows.Add("( = )", "Utilidad Neta", "$ " + Math.Round(utilidad_neta, 2).ToString("0.00", nfi));

        }

       
    }
}
