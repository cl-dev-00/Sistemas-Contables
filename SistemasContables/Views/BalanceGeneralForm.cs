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

namespace SistemasContables.Views
{
    public partial class BalanceGeneralForm : Form
    {
         private String[] Activos_txt;
         private String[] Pasivos_txt;

        private double[] activos_n;
        private double[] pasivos_n;
        public BalanceGeneralForm(LibroDiario libroDiario)
        {
            InitializeComponent();
            BalanceGeneralController balanceGeneralController;
            balanceGeneralController = new BalanceGeneralController(); 
            balanceGeneralController.getActivos(libroDiario.IdLibroDiario);
            balanceGeneralController.getPasivos(libroDiario.IdLibroDiario);

            Activos_txt = balanceGeneralController.getActivos_txt();
            Pasivos_txt = balanceGeneralController.getActivos_txt();
            activos_n = balanceGeneralController.getActivos__();
            pasivos_n = balanceGeneralController.getPasivos__(); 

   
        lblPeriodo.Text = libroDiario.Periodo;

           //tableBalanceGeneral.Rows.Add(Activos_txt[0], activos_n[0], "", "");
            tableBalanceGeneral.Rows.Add("Algo", "Algo", "", "");
            /*
            for (int i = 0; i <= Activos_txt.Length;i++)
            {
                tableBalanceGeneral.Rows.Add(Activos_txt[i], activos_n[i], "", "");
            }

            for (int i = 0; i <= Pasivos_txt.Length; i++)
            {
                tableBalanceGeneral.Rows.Add("", "", Pasivos_txt[i], pasivos_n[i]);
            }*/
        }
    }
}
