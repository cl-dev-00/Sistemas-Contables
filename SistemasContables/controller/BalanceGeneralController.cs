using SistemasContables.DataBase;
using SistemasContables.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemasContables.controller
{
    public class BalanceGeneralController
    {
        private String[] Activostxt;
        private String[] Pasivostxt;

        private double[] activos_n;
        private double[] pasivos_n;

        private BalanceGeneralDAO balanceGeneralDAO;

        public BalanceGeneralController()
        {
            balanceGeneralDAO = new BalanceGeneralDAO();
        }

        public void getActivos(int idLibroDiario)
        {
            balanceGeneralDAO.getActivos(idLibroDiario);
        }
        public void getPasivos(int idLibroDiario)
        {
            balanceGeneralDAO.getPasivos(idLibroDiario);
        }
        public String[] getActivos_txt()
    {
            return balanceGeneralDAO.getActivos_txt();
    }
    public double[] getActivos__()
    {
        return balanceGeneralDAO.getActivos__();
    }
    public String[] getPasivos_txt()
    {
        return balanceGeneralDAO.getPasivos_txt();
    }
    public double[] getPasivos__()
    {
        return balanceGeneralDAO.getPasivos__();
    }



}
}