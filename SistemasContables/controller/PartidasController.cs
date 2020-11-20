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

        public PartidasController()
        {
            this.partidasDAO = new PartidasDAO();
        }

        public void insert(Partida partida)
        {
            partidasDAO.insert(partida);
        }

        public List<Partida> getList(int idLibroDiario)
        {
            List<Partida> lista = this.partidasDAO.getList(idLibroDiario);

            return lista;
        }

        public void update(Partida partida)
        {
            partidasDAO.update(partida);
        }

        public void delete(int n_partida, int idLibro)
        {
            partidasDAO.delete(n_partida, idLibro);
        }

        public Partida getPartida(int n_partida, int idLibro)
        {
            Partida partida = partidasDAO.getPartida(n_partida, idLibro);

            return partida;
        }

    }
}
