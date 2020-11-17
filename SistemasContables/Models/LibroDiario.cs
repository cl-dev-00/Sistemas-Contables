using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemasContables.Models
{
    public class LibroDiario
    {
        private int numeroLibroDiario;
        private string periodo;

        public int NumeroLibroDiario
        {
            get
            {
                return this.numeroLibroDiario;
            }
            set
            {
                this.numeroLibroDiario = value;
            }
        }

        public string Periodo
        {
            get
            {
                return this.periodo;
            }
            set
            {
                this.periodo = value;
            }
        }
    }
}
