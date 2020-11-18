using SistemasContables.Models;
using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemasContables.DataBase
{
    public class CuentasDAO
    {
        private SQLiteConnection conn;
        private List<Cuenta> lista;

        private const string TABLE = "cuenta";
        private const string ID_CUENTA = "idCuenta";
        private const string CODIGO = "codigo";
        private const string NIVEL = "nivel";
        private const string NOMBRE_CUENTA = "nombreCuenta";
        private const string TIPO_SALDO = "tipoSaldo";

        public List<Cuenta> Lista
        {
            get
            {
                return this.lista;
            }
            set
            {
                this.lista = value;
            }
        }

        public CuentasDAO()
        {
            this.lista = new List<Cuenta>();
        }

        public List<Cuenta> getList()
        {

            try
            {
                conn = Conexion.Conn;

                conn.Open();

                using (SQLiteCommand command = new SQLiteCommand())
                {
                    string sql = $"SELECT * FROM {TABLE}";
                    command.CommandText = sql;
                    command.Connection = Conexion.Conn;
                    SQLiteDataReader result = command.ExecuteReader();


                    if (result.HasRows)
                    {
                        
                        if(lista.Count > 0)
                        {
                            lista.Clear();
                        }

                        while (result.Read())
                        {
                            Cuenta cuenta = new Cuenta();

                            cuenta.IdCuenta = Convert.ToInt32(result[ID_CUENTA]);
                            cuenta.Codigo = result[CODIGO].ToString();
                            cuenta.Nivel = Convert.ToInt32(result[NIVEL]);
                            cuenta.Nombre = result[NOMBRE_CUENTA].ToString();
                            cuenta.TipoSaldo = result[TIPO_SALDO].ToString();

                            lista.Add(cuenta);
                        }
                    }

                }

                conn.Close();


            } catch(Exception exception)
            {
                MessageBox.Show(exception.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return this.lista;

        }

    }
}
