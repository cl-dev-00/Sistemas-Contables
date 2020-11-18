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
    public class LibroDiarioDAO
    {
        private SQLiteConnection conn;
        private List<LibroDiario> lista;

        private const string TABLE = "librodiario";
        private const string ID_LIBRO_DIARIO = "n_libro";
        private const string PERIODO = "periodo";

        public List<LibroDiario> Lista
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

        public LibroDiarioDAO()
        {
            this.lista = new List<LibroDiario>();
        }

        public List<LibroDiario> getList(int idLibroDiario)
        {

            try
            {
                conn = Conexion.Conn;

                conn.Open();

                using (SQLiteCommand command = new SQLiteCommand())
                {
                    string sql = $"SELECT * FROM {TABLE} WHERE {ID_LIBRO_DIARIO} = @n_libro";
                    command.CommandText = sql;
                    command.Connection = Conexion.Conn;
                    command.Parameters.Add(new SQLiteParameter("@n_libro", idLibroDiario));
                    SQLiteDataReader result = command.ExecuteReader();


                    if (result.HasRows)
                    {

                        if (lista.Count > 0)
                        {
                            lista.Clear();
                        }

                        while (result.Read())
                        {
                            LibroDiario libroDiario = new LibroDiario();

                            libroDiario.IdLibroDiario = Convert.ToInt32(result[ID_LIBRO_DIARIO].ToString());
                            libroDiario.Periodo = result[PERIODO].ToString();

                            lista.Add(libroDiario);
                        }
                    }

                }

                conn.Close();


            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return this.lista;

        }
    }
}
