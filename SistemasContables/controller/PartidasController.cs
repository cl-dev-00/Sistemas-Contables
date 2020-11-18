using SistemasContables.DataBase;
using SistemasContables.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemasContables.controller
{
    public class PartidasController
    {
        private PartidasDAO partidasDAO;
        private List<Partida> lista;
        private List<CuentaPartida> listaCuentasPartida;

        public PartidasController()
        {
            this.partidasDAO = new PartidasDAO();
        }

        public List<Partida> getList(int idLibroDiario)
        {
            this.lista = this.partidasDAO.getList(idLibroDiario);

            return this.lista;
        }

        public List<CuentaPartida> getListCuentasPartida(int idPartida)
        {
            this.listaCuentasPartida = this.partidasDAO.getListCuentasPartida(idPartida);

            return this.listaCuentasPartida;
        }

    }
}
