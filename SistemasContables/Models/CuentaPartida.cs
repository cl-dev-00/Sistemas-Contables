using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemasContables.Models
{
    public class CuentaPartida
    {
        private int idCuentaPartida;
        private int idCuenta;
        private int idPartida;
        private double debe;
        private double haber;

        public int IdCuentaPartida
        {
            get
            {
                return this.idCuentaPartida;
            }
            set
            {
                this.idCuentaPartida = value;
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

        public int IdPartida
        {
            get
            {
                return this.idPartida;
            }
            set
            {
                this.idPartida = value;
            }
        }

        public double Debe
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

        public double Haber
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

    }
}
