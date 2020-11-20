using SistemasContables.DataBase;
using SistemasContables.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemasContables.controller
{
    public class LibroDiariosController
    {

        private LibroDiarioDAO libroDiarioDao;

        public LibroDiariosController()
        {
            this.libroDiarioDao = new LibroDiarioDAO();
        }

        public LibroDiario getPeriodoLibroDiario(int idLibroDiario)
        {
            LibroDiario libroDiario = libroDiarioDao.getPeriodoLibroDiario(idLibroDiario);

            return libroDiario;
        }

    }
}
