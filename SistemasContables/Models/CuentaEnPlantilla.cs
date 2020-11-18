using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemasContables.Models
{
    public class CuentaEnPlantilla
    {
        private int idCuentaPlantilla;
        private int idCuenta;
        private string debe;
        private string haber;
        private int idPlantilla;

        public int IdCuentaPlantilla
        {
            get
            {
                return this.idCuentaPlantilla;
            }
            set
            {
                this.idCuentaPlantilla = value;
            }
        }

        public int IdCuenta
        {
            get
            {
                return this.idCuenta;
            }
            set
            {
                this.idCuenta = value;
            }
        }

        public string Debe
        {
            get
            {
                return this.debe;
            }
            set
            {
                this.debe = value;
            }
        }

        public string Haber
        {
            get
            {
                return this.haber;
            }
            set
            {
                this.haber = value;
            }
        }

        public int IdPlantilla
        {
            get
            {
                return this.idPlantilla;
            }
            set
            {
                this.idPlantilla = value;
            }
        }

    }
}
