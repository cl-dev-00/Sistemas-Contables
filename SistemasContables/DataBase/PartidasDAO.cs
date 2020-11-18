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
    public class PartidasDAO
    {
        private SQLiteConnection conn;
        private List<Partida> lista;
        private List<CuentaPartida> listaCuentasPartida;

        private const string TABLE_PARTIDA = "partida";
        private const string ID_PARTIDA = "idPartida";
        private const string FECHA = "fecha";
        private const string CONCEPTO = "concepto";
        private const string N_PARTIDA = "n_partida";
        private const string ID_LIBRO_DIARIO = "n_libro";

        private const string TABLE_CUENTA_PARTIDA = "cuenta_partida";
        private const string ID_CUENTA_PARTIDA = "id_cuenta_partida";
        private const string ID_CUENTA = "idCuenta";
        private const string DEBE = "debe";
        private const string HABER = "haber";

        private const string TABLE_CUENTA = "cuenta";
        private const string CODIGO = "codigo";
        private const string NIVEL = "nivel";
        private const string NOMBRE_CUENTA = "nombreCuenta";
        private const string TIPO_SALDO = "tipoSaldo";

        public List<Partida> Lista
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

        public PartidasDAO()
        {
            this.lista = new List<Partida>();
            this.listaCuentasPartida = new List<CuentaPartida>();
        }

        public List<Partida> getList(int idLibroDiario)
        {

            try
            {
                conn = Conexion.Conn;

                conn.Open();

                using (SQLiteCommand command = new SQLiteCommand())
                {
                    string sql = $"SELECT * FROM {TABLE_PARTIDA} WHERE {ID_LIBRO_DIARIO} = @n_libro";
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
                            Partida partida = new Partida();

                            partida.IdPartida = Convert.ToInt32(result[ID_PARTIDA].ToString());
                            partida.Fecha = result[FECHA].ToString();
                            partida.Detalle = result[CONCEPTO].ToString();
                            partida.N_Partida = Convert.ToInt32(result[N_PARTIDA].ToString());
                            partida.IdLibro = Convert.ToInt32(result[ID_LIBRO_DIARIO].ToString());

                            lista.Add(partida);
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

        public List<CuentaPartida> getListCuentasPartida(int idPartida)
        {

            try
            {
                conn = Conexion.Conn;

                conn.Open();

                using (SQLiteCommand command = new SQLiteCommand())
                {
                    string sql = $"SELECT {TABLE_CUENTA}.{CODIGO}, {TABLE_CUENTA}.{NOMBRE_CUENTA}, {TABLE_CUENTA_PARTIDA}.{DEBE}, {TABLE_CUENTA_PARTIDA}.{HABER} FROM {TABLE_CUENTA} ";
                    sql += $"INNER JOIN {TABLE_CUENTA_PARTIDA} ON {TABLE_CUENTA}.{ID_CUENTA} = {TABLE_CUENTA_PARTIDA}.{ID_CUENTA} WHERE {ID_PARTIDA} = @idPartida";

                    command.CommandText = sql;
                    command.Connection = Conexion.Conn;
                    command.Parameters.Add(new SQLiteParameter("@idPartida", idPartida));
                    SQLiteDataReader result = command.ExecuteReader();


                    if (result.HasRows)
                    {

                        if (listaCuentasPartida.Count > 0)
                        {
                            listaCuentasPartida.Clear();
                        }

                        while (result.Read())
                        {
                            CuentaPartida cuentaPartida = new CuentaPartida();

                            cuentaPartida.Cuenta.Codigo = result[CODIGO].ToString();
                            cuentaPartida.Cuenta.Nombre = result[NOMBRE_CUENTA].ToString();
                            cuentaPartida.Debe = Convert.ToDouble(result[DEBE].ToString());
                            cuentaPartida.Haber = Convert.ToDouble(result[HABER].ToString());

                            listaCuentasPartida.Add(cuentaPartida);
                        }
                    }

                }

                conn.Close();


            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return this.listaCuentasPartida;

        }
    }
}
