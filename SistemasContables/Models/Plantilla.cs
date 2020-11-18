using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemasContables.Models
{
    public class Plantilla
    {
        private int idPlantilla;
        private string nombrePlantilla;
        private string cuentaDefault;
        private string tipoIva;

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

        public string NombrePlantilla
        {
            get
            {
                return this.nombrePlantilla;
            }
            set
            {
                this.nombrePlantilla = value;
            }
        }

        public string CuentaDefault
        {
            get
            {
                return this.cuentaDefault;
            }
            set
            {
                this.cuentaDefault = value;
            }
        }

        public string TipoIVA
        {
            get
            {
                return this.tipoIva;
            }
            set
            {
                this.tipoIva = value;
            }
        }

    }
}
