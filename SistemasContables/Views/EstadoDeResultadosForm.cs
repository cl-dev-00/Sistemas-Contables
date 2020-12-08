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
        //Lo uso para que sea punto ( . ) el separador de decimales, va cuando se hace .ToString("", formatoDecimales)
        private NumberFormatInfo formatoDecimales = new CultureInfo("en-US", false).NumberFormat;

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


            double ingresos = estadoDeResultadosController.getIngresos_(libroDiario.IdLibroDiario);
            double costos = estadoDeResultadosController.getCostos_(libroDiario.IdLibroDiario);
            double gastos = estadoDeResultadosController.getGastos_(libroDiario.IdLibroDiario);
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

            llenarTablaEstadoDeResultados(ingresos, costos, ingresosmenoscostos, gastos_de_operacion, utilidad_de_operacion, reserva_legal, utilidad_antes_de_impuestos, impuestos_por_pagar, utilidad_neta);

            estadoDeResultadosController.utilidad_neta = utilidad_neta;
            estadoDeResultadosController.impuestos_por_pagar = impuestos_por_pagar;
            estadoDeResultadosController.reserva_legal = reserva_legal;


        }

        public double getUtilidad_neta()
        {
            return utilidad_neta;
        }

        public double getImpuestos()
        {
            return impuestos_por_pagar;
        }

        public double getReserva()
        {
            return reserva_legal;
        }

        public void llenarTablaEstadoDeResultados(double ingresos, double costos, double ingresosmenoscostos, double gastos_de_operacion, double utilidad_de_operacion, double reserva_legal, double utilidad_antes_de_impuestos, double impuestos_por_pagar, double utilidad_neta)
        {
            if (tableEstadoDeResultados.Rows.Count > 0)
            {
                tableEstadoDeResultados.Rows.Clear();
            }
            /* Agregando valores a la tabla*/
            tableEstadoDeResultados.Rows.Add("", "Ingresos", "$" + redondear(Math.Round(ingresos, 2)));
            tableEstadoDeResultados.Rows.Add("( - )", "Costos", "$ " + redondear(Math.Round(costos, 2)));
            tableEstadoDeResultados.Rows.Add("( = )", "Utilidad Bruta", "$ " + redondear(Math.Round(ingresosmenoscostos, 2)));
            tableEstadoDeResultados.Rows.Add("( - )", "Gastos de Operacion", "$ " + redondear(Math.Round(gastos_de_operacion, 2)));
            tableEstadoDeResultados.Rows.Add("( = )", "Utilidad de Operación", "$ " + redondear(Math.Round(utilidad_de_operacion, 2)));
            tableEstadoDeResultados.Rows.Add("( - )", "Reserva Legal", "$ " + redondear(Math.Round(reserva_legal, 2)));
            tableEstadoDeResultados.Rows.Add("( = )", "Utilidad Antes de Impuestos", "$ " + Math.Round(utilidad_antes_de_impuestos, 2));
            tableEstadoDeResultados.Rows.Add("( - )", "Impuestos Por Pagar", "$ " + redondear(Math.Round(impuestos_por_pagar, 2)));
            tableEstadoDeResultados.Rows.Add("( = )", "Utilidad Neta", "$ " + redondear(Math.Round(utilidad_neta, 2)));

        }

        // el metodo retorna un formato #.00 a los decimales de un string
        private string redondear(double cantidad)
        {
            return cantidad.ToString("0.00", formatoDecimales);
        }

    }
}