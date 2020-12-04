using SistemasContables.DataBase;
using SistemasContables.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemasContables.controller
{
    public class EstadoDeResultadosController
    {
        private EstadoDeResultadosDAO estadoDeResultadosDAO;
        public double utilidad_neta;
        public double impuestos_por_pagar;
        public double reserva_legal;
        public EstadoDeResultadosController()
        {
            estadoDeResultadosDAO = new EstadoDeResultadosDAO();
        }

        public double getIngresos_(int idLibroDiario)
        {
            return estadoDeResultadosDAO.getIngresos_(idLibroDiario);
        }

        public double getCostos_(int idLibroDiario)
        {
            return estadoDeResultadosDAO.getCostos_(idLibroDiario);
        }
        public double getGastos_(int idLibroDiario)
        {
            return estadoDeResultadosDAO.getGastos_(idLibroDiario);
        }



    }
}