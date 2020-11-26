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
    public class LibroMayorDAO
    {
        private SQLiteConnection conn;
        private List<string> listaCodigos;
        private List<Partida> listaPartidas;
        private CuentaPartida cuentaPartida;

        private const string TABLE_PARTIDA = "partida";
        private const string ID_PARTIDA = "idPartida";
        private const string N_PARTIDA = "n_partida";
        private const string ID_LIBRO_DIARIO = "n_libro";
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

        public LibroMayorDAO()
        {
            listaCodigos = new List<string>();
            listaPartidas = new List<Partida>();
            cuentaPartida = new CuentaPartida();
        }

        public List<string> getListCodigos(int idLibroDiario)
        {


            try
            {
                conn = Conexion.Conn;

                conn.Open();

                using (SQLiteCommand command = new SQLiteCommand())
                {
                    string sql = $"SELECT {TABLE_CUENTA}.{CODIGO} FROM {TABLE_CUENTA_PARTIDA} ";
                    sql += $"INNER JOIN {TABLE_CUENTA} ON {TABLE_CUENTA_PARTIDA}.{ID_CUENTA} = {TABLE_CUENTA}.{ID_CUENTA} ";
                    sql += $"INNER JOIN {TABLE_PARTIDA} ON {TABLE_CUENTA_PARTIDA}.{ID_PARTIDA} = {TABLE_PARTIDA}.{ID_PARTIDA} "; 
                    sql += $"WHERE {TABLE_PARTIDA}.{ID_LIBRO_DIARIO} = @idLibroDiario";


                    command.CommandText = sql;
                    command.Connection = Conexion.Conn;
                    command.Parameters.Add(new SQLiteParameter("@idLibroDiario", idLibroDiario));

                    using (SQLiteDataReader result = command.ExecuteReader())
                    {
                        if (result.HasRows)
                        {
                            if (listaCodigos.Count > 0)
                            {
                                listaCodigos.Clear();
                            }

                            while (result.Read())
                            {
                                listaCodigos.Add(result[CODIGO].ToString());
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

            return listaCodigos;

        }

        public Partida getPartida(string nivel3)
        {
            Partida partida = null;

            try
            {
                conn = Conexion.Conn;

                conn.Open();

                using (SQLiteCommand command = new SQLiteCommand())
                {

                    string sql = $"SELECT {NOMBRE_CUENTA}, {TIPO_SALDO} FROM {TABLE_CUENTA} WHERE {CODIGO} = @nivel3";

                    command.CommandText = sql;
                    command.Connection = Conexion.Conn;
                    command.Parameters.Add(new SQLiteParameter("@nivel3", nivel3));

                    using (SQLiteDataReader result = command.ExecuteReader())
                    {
                        if (result.HasRows)
                        {
                            partida = new Partida();
                            partida.ListaCuentasPartida = new List<CuentaPartida>();
                            
                            if (result.Read())
                            {
                                cuentaPartida.Nombre = result[NOMBRE_CUENTA].ToString();
                                cuentaPartida.TipoSaldo = result[TIPO_SALDO].ToString();

                                partida.ListaCuentasPartida.Add(cuentaPartida);
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

            return partida;

        }

        public List<Partida> getListPartida(string codigo, int idLibroDiario)
        {


            try
            {
                conn = Conexion.Conn;

                conn.Open();

                //codigo = codigo.Replace("\"", "");

                using (SQLiteCommand command = new SQLiteCommand())
                {
                    string sql = $"SELECT {TABLE_CUENTA}.{CODIGO}, {TABLE_PARTIDA}.{FECHA}, {TABLE_PARTIDA}.{CONCEPTO}, {TABLE_CUENTA_PARTIDA}.{DEBE}, {TABLE_CUENTA_PARTIDA}.{HABER} FROM {TABLE_CUENTA_PARTIDA} ";
                    sql += $"INNER JOIN {TABLE_CUENTA} ON {TABLE_CUENTA_PARTIDA}.{ID_CUENTA} = {TABLE_CUENTA}.{ID_CUENTA} ";
                    sql += $"INNER JOIN {TABLE_PARTIDA} ON {TABLE_CUENTA_PARTIDA}.{ID_PARTIDA} = {TABLE_PARTIDA}.{ID_PARTIDA} ";
                    sql += $"WHERE {TABLE_PARTIDA}.{ID_LIBRO_DIARIO} = @idLibroDiario AND {TABLE_CUENTA}.{CODIGO} LIKE '"+ codigo +"%'";
                    //MessageBox.Show(codigo);

                    command.CommandText = sql;
                    command.Connection = Conexion.Conn;
                    //command.Parameters.Add(new SQLiteParameter("@codigo", codigo));
                    command.Parameters.Add(new SQLiteParameter("@idLibroDiario", idLibroDiario));

                    using (SQLiteDataReader result = command.ExecuteReader())
                    {
                        if (result.HasRows)
                        {
                            //MessageBox.Show("hasta aqui");
                            if (listaPartidas.Count > 0)
                            {
                                listaPartidas.Clear();
                            }

                            while (result.Read())
                            {
                                Partida partidaAux = new Partida();
                                partidaAux.ListaCuentasPartida = new List<CuentaPartida>();
                                partidaAux.Fecha = result[FECHA].ToString();
                                partidaAux.Detalle = result[CONCEPTO].ToString();

                                cuentaPartida = new CuentaPartida();

                                cuentaPartida.Codigo = result[CODIGO].ToString();
                                cuentaPartida.Debe = Convert.ToDouble(result[DEBE].ToString());
                                cuentaPartida.Haber = Convert.ToDouble(result[HABER].ToString());

                                partidaAux.ListaCuentasPartida.Add(cuentaPartida);
                                listaPartidas.Add(partidaAux);
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

            return listaPartidas;

        }

    }
}
