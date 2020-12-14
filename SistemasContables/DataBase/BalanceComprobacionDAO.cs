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
    class BalanceComprobacionDAO
    {
        private SQLiteConnection conn;
        private List<CuentaPartida> listaCuentas;
        private List<CuentaPartida> listaCuentaPartidas;

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

        public BalanceComprobacionDAO()
        {
            listaCuentas = new List<CuentaPartida>();
            listaCuentaPartidas = new List<CuentaPartida>();
        }
        public List<CuentaPartida> getListCuentas()
        {

            try
            {
                conn = Conexion.Conn;

                conn.Open();

                using (SQLiteCommand command = new SQLiteCommand())
                {
                    string sql = $"SELECT {CODIGO}, {NOMBRE_CUENTA}, {TIPO_SALDO} FROM {TABLE_CUENTA} WHERE nivel = 1 OR nivel = 2";

                    command.CommandText = sql;
                    command.Connection = Conexion.Conn;

                    using (SQLiteDataReader result = command.ExecuteReader())
                    {
                        if (result.HasRows)
                        {
                            if (listaCuentas.Count > 0)
                            {             
                                listaCuentas.Clear();
                            }

                            while (result.Read())
                            {
                                CuentaPartida cuenta = new CuentaPartida();
                                cuenta.Codigo = result[CODIGO].ToString();
                                cuenta.Nombre = result[NOMBRE_CUENTA].ToString();
                                cuenta.TipoSaldo = result[TIPO_SALDO].ToString();

                                listaCuentas.Add(cuenta);
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

            return listaCuentas;

        }

        public List<CuentaPartida> getListCuentasPartidas(string codigo, int idLibroDiario)
        {


            try
            {
                conn = Conexion.Conn;

                conn.Open();

                using (SQLiteCommand command = new SQLiteCommand())
                {
                    string sql = $"SELECT {TABLE_CUENTA}.{CODIGO}, {TABLE_CUENTA}.{NOMBRE_CUENTA}, {TABLE_PARTIDA}.{N_PARTIDA}, {TABLE_CUENTA_PARTIDA}.{DEBE}, {TABLE_CUENTA_PARTIDA}.{HABER} ";
                    sql += $"FROM {TABLE_CUENTA_PARTIDA} INNER JOIN {TABLE_CUENTA} ON {TABLE_CUENTA_PARTIDA}.{ID_CUENTA} = {TABLE_CUENTA}.{ID_CUENTA} ";
                    sql += $"INNER JOIN {TABLE_PARTIDA} ON {TABLE_CUENTA_PARTIDA}.{ID_PARTIDA} = {TABLE_PARTIDA}.{ID_PARTIDA} ";
                    sql += $"WHERE {TABLE_PARTIDA}.{ID_LIBRO_DIARIO} = @idLibroDiario AND {TABLE_CUENTA}.{CODIGO} LIKE @codigo || '%'";

                    command.CommandText = sql;
                    command.Connection = Conexion.Conn;
                    command.Parameters.Add(new SQLiteParameter("@codigo", codigo));
                    command.Parameters.Add(new SQLiteParameter("@idLibroDiario", idLibroDiario));

                    using (SQLiteDataReader result = command.ExecuteReader())
                    {

                        if (result.HasRows)
                        {
                            while (result.Read())
                            {
                                CuentaPartida cuentaPartida = new CuentaPartida();
                                cuentaPartida.IdPartida = Convert.ToInt32(result[N_PARTIDA]);
                                cuentaPartida.Codigo = result[CODIGO].ToString();
                                cuentaPartida.Nombre = result[NOMBRE_CUENTA].ToString();
                                cuentaPartida.Debe = Convert.ToDouble(result[DEBE]);
                                cuentaPartida.Haber = Convert.ToDouble(result[HABER]);

                                listaCuentaPartidas.Add(cuentaPartida);
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

            return listaCuentaPartidas;

        }
    }
}
