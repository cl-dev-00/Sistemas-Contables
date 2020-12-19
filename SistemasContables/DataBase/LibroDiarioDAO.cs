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

        private const string TABLE_LIBRO_DIARIO = "librodiario";
        private const string ID_LIBRO_DIARIO = "n_libro";
        private const string PERIODO = "periodo";

        private const string TABLE_PARTIDA = "partida";
        private const string ID_PARTIDA = "idPartida";
        private const string N_PARTIDA = "n_partida";
        private const string FECHA = "fecha";

        private const string TABLE_CUENTA_PARTIDA = "cuenta_partida";
        private const string ID_CUENTA = "idCuenta";
        private const string DEBE = "debe";
        private const string HABER = "haber";
        private const string CONCEPTO = "concepto";

        private const string TABLE_CUENTA = "cuenta";
        private const string CODIGO = "codigo";
        private const string NOMBRE_CUENTA = "nombreCuenta";
        private const string TIPO_SALDO = "tipoSaldo";

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
            lista = new List<LibroDiario>();
        }

        public bool insert(string periodo)
        {
            try
            {
                conn = Conexion.Conn;

                conn.Open();

                using (SQLiteCommand command = new SQLiteCommand())
                {
                    string sql = $"INSERT INTO {TABLE_LIBRO_DIARIO}(periodo) VALUES(@periodo)";
                    command.CommandText = sql;
                    command.Connection = Conexion.Conn;
                    command.Parameters.Add(new SQLiteParameter("@periodo", periodo));
                    command.ExecuteNonQuery();

                }

                conn.Close();

                return true;
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return false;
        }

        public List<LibroDiario> getList()
        {

            try
            {
                conn = Conexion.Conn;

                conn.Open();

                using (SQLiteCommand command = new SQLiteCommand())
                {
                    string sql = $"SELECT * FROM {TABLE_LIBRO_DIARIO}";
                    command.CommandText = sql;
                    command.Connection = Conexion.Conn;

                    using (SQLiteDataReader result = command.ExecuteReader())
                    {
                        if (result.HasRows)
                        {
                            if(lista.Count > 0)
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

                }

                conn.Close();


            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return lista;

        }

        public bool delete(int idLibroDiario)
        {
            try
            {
                conn = Conexion.Conn;

                conn.Open();

                using (SQLiteCommand command = new SQLiteCommand())
                {
                    deleteCuentasPartidas(idLibroDiario);
                    deletePartidas(idLibroDiario);

                    string sql = $"DELETE FROM {TABLE_LIBRO_DIARIO} WHERE {ID_LIBRO_DIARIO} = @idLibroDiario";
                    command.CommandText = sql;
                    command.Connection = Conexion.Conn;
                    command.Parameters.Add(new SQLiteParameter("@idLibroDiario", idLibroDiario));
                    command.ExecuteNonQuery();

                }

                conn.Close();


                return true;
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                return false;
            }

        }

        private void deletePartidas(int idLibroDiario)
        {

            using (SQLiteCommand command = new SQLiteCommand())
            {
                string sql = $"DELETE FROM {TABLE_PARTIDA} WHERE {ID_LIBRO_DIARIO} = @idLibroDiario";
                command.CommandText = sql;
                command.Connection = Conexion.Conn;
                command.Parameters.Add(new SQLiteParameter("@idLibroDiario", idLibroDiario));
                command.ExecuteNonQuery();
            }

        }

        private void deleteCuentasPartidas(int idLibroDiario)
        {

            using (SQLiteCommand command = new SQLiteCommand())
            {
                string sql = $"DELETE FROM {TABLE_CUENTA_PARTIDA} WHERE {ID_PARTIDA} IN ";
                sql += $"(SELECT {TABLE_CUENTA_PARTIDA}.{ID_PARTIDA} FROM {TABLE_CUENTA_PARTIDA} "; 
                sql += $"INNER JOIN {TABLE_PARTIDA} ON ";
                sql += $"{TABLE_CUENTA_PARTIDA}.{ID_PARTIDA} = {TABLE_PARTIDA}.{ID_PARTIDA} ";
                sql += $"WHERE {TABLE_PARTIDA}.{ID_LIBRO_DIARIO} = @idLibroDiario)";
                command.CommandText = sql;
                command.Connection = Conexion.Conn;
                command.Parameters.Add(new SQLiteParameter("@idLibroDiario", idLibroDiario));
                command.ExecuteNonQuery();
            }

        }

        public double total(string cuentaCalcular, int idLibroDiario)
        {
            double total = 0;
            double debe = DebeOrHaber(cuentaCalcular, DEBE, idLibroDiario);
            double haber = DebeOrHaber(cuentaCalcular, HABER, idLibroDiario);
            
            total = debe + haber;

            return Math.Round(total, 2);

        }

        private double DebeOrHaber(string cuentaCalcular, string campoCalcular,  int idLibroDiario)
        {
            double total = 0;

            try
            {
                conn = Conexion.Conn;

                conn.Open();

                using (SQLiteCommand command = new SQLiteCommand())
                {
                    string sql = $"SELECT SUM({TABLE_CUENTA_PARTIDA}.{campoCalcular}) FROM {TABLE_CUENTA_PARTIDA} ";
                    sql += $"INNER JOIN {TABLE_CUENTA} ON {TABLE_CUENTA_PARTIDA}.{ID_CUENTA} = {TABLE_CUENTA}.{ID_CUENTA} ";
                    sql += $"INNER JOIN {TABLE_PARTIDA} ON {TABLE_CUENTA_PARTIDA}.{ID_PARTIDA} = {TABLE_PARTIDA}.{ID_PARTIDA} ";
                    sql += $"WHERE {ID_LIBRO_DIARIO} = @idLibroDiario AND ";
                    sql += queryString(cuentaCalcular, campoCalcular);

                    if (string.IsNullOrEmpty(sql))
                    {
                        conn.Close();

                        return 0;
                    }
                    Console.WriteLine(sql);

                    command.CommandText = sql;
                    command.Connection = Conexion.Conn;
                    command.Parameters.Add(new SQLiteParameter("@idLibroDiario", idLibroDiario));
                    var result = command.ExecuteScalar();

                    if (!string.IsNullOrEmpty(result.ToString()))
                    {
                        total = Convert.ToDouble(result);
                    }

                }

                conn.Close();

            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return total;

        }

        private string queryString(string cuentaCalcular, string campoCalcular)
        {
            string sql = "";

            if (cuentaCalcular == "activos")
            {
                sql += $"{TABLE_CUENTA}.{CODIGO} LIKE '1%'";
            }
            else if (cuentaCalcular == "pasivos")
            {
                sql += $"{TABLE_CUENTA}.{CODIGO} LIKE '2%'";
            }
            else if (cuentaCalcular == "ingresos")
            {
                sql += $"{TABLE_CUENTA}.{CODIGO} LIKE '5%'";
            }
            else if (cuentaCalcular == "costos")
            {
                sql += $"{TABLE_CUENTA}.{CODIGO} LIKE '41%'";
            }
            else if (cuentaCalcular == "gastos")
            {
                sql += $"{TABLE_CUENTA}.{CODIGO} LIKE '42%'";
            }
            else if (cuentaCalcular == "capital")
            {
                sql += $"{TABLE_CUENTA}.{CODIGO} LIKE '31%'";
            }
            else
            {
                return null;
            }

            return sql;
        }

    }
}
