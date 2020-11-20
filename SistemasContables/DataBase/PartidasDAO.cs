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
        private int idPartida;
        private int idCuenta;
        List<Partida> lista = null;

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

        public PartidasDAO()
        {
            lista = new List<Partida>();
        }

        public void insert(Partida partida)
        {
            try
            {
                conn = Conexion.Conn;

                conn.Open();

                using (SQLiteCommand command = new SQLiteCommand())
                {
                    string sql = $"INSERT INTO {TABLE_PARTIDA}({ID_PARTIDA}, {FECHA}, {CONCEPTO}, {N_PARTIDA}, {ID_LIBRO_DIARIO}) ";
                    sql += "VALUES(NULL, @fecha, @concepto, @n_partida, @id_libro_diario);";
                    command.CommandText = sql;
                    command.Connection = Conexion.Conn;
                    command.Parameters.Add(new SQLiteParameter("@fecha", partida.Fecha));
                    command.Parameters.Add(new SQLiteParameter("@concepto", partida.Detalle));
                    command.Parameters.Add(new SQLiteParameter("@n_partida", partida.N_Partida));
                    command.Parameters.Add(new SQLiteParameter("@id_libro_diario", partida.IdLibro));
                    command.ExecuteNonQuery();

                    //Ingreso las cuentasPartidas a sus respectiva partida a la database

                    this.idPartida = obtenerIdPartidaInsertada(partida.IdLibro);

                    foreach (CuentaPartida cuentaPartida in partida.ListaCuentasPartida)
                    {
                        this.idCuenta = obtenerIdCuentaActual(cuentaPartida.Codigo);
                        cuentaPartida.IdCuenta = this.idCuenta;
                        cuentaPartida.IdPartida = this.idPartida;

                        insertarCuentaPartida(cuentaPartida);
                    }

                }

                conn.Close();


                MessageBox.Show("Se ingreso la partida correctamente", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

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
                            partida.ListaCuentasPartida = getListCuentasPartida(partida.IdPartida);

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

            return lista;

        }

        public void update(Partida partida)
        {
            try
            {
                conn = Conexion.Conn;

                conn.Open();

                using (SQLiteCommand command = new SQLiteCommand())
                {
                    string sql = $"UPDATE {TABLE_PARTIDA} SET {FECHA} = @fecha, {CONCEPTO} = @concepto WHERE {N_PARTIDA} =  @n_partida";
                    command.CommandText = sql;
                    command.Connection = Conexion.Conn;
                    command.Parameters.Add(new SQLiteParameter("@fecha", partida.Fecha));
                    command.Parameters.Add(new SQLiteParameter("@concepto", partida.Detalle));
                    command.Parameters.Add(new SQLiteParameter("@n_partida", partida.N_Partida));
                    command.ExecuteNonQuery();

                    //Ingreso las cuentasPartidas a sus respectiva partida a la database

                    idPartida = obtenerIdPartida(partida.N_Partida, partida.IdLibro);

                    deleteCuentaPartida(idPartida);

                    foreach (CuentaPartida cuentaPartida in partida.ListaCuentasPartida)
                    {
                        this.idCuenta = obtenerIdCuentaActual(cuentaPartida.Codigo);
                        cuentaPartida.IdCuenta = this.idCuenta;
                        cuentaPartida.IdPartida = this.idPartida;

                        insertarCuentaPartida(cuentaPartida);
                    }

                }

                conn.Close();

                MessageBox.Show("Se ha modificado la partida correctamente", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void delete(int n_partida, int idLibro)
        {
            try
            {
                conn = Conexion.Conn;

                conn.Open();

                using (SQLiteCommand command = new SQLiteCommand())
                {

                    idPartida = obtenerIdPartida(n_partida, idLibro);

                    deleteCuentaPartida(idPartida);

                    string sql = $"DELETE FROM {TABLE_PARTIDA} WHERE {N_PARTIDA} = @n_partida";

                    command.CommandText = sql;
                    command.Connection = Conexion.Conn;
                    command.Parameters.Add(new SQLiteParameter("@n_partida", n_partida));
                    command.ExecuteNonQuery();

                    reorderPartidas(n_partida);

                }

                conn.Close();


            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public Partida getPartida(int n_partida, int idLibro)
        {
            Partida partida = null;

            try
            {
                conn = Conexion.Conn;

                conn.Open();

                using (SQLiteCommand command = new SQLiteCommand())
                {
                    idPartida = obtenerIdPartida(n_partida, idLibro);

                    string sql = $"SELECT {FECHA}, {CONCEPTO} FROM {TABLE_PARTIDA} WHERE {ID_PARTIDA} = @idPartida";
                    command.CommandText = sql;
                    command.Connection = Conexion.Conn;
                    command.Parameters.Add(new SQLiteParameter("@idPartida", idPartida));
                    SQLiteDataReader result = command.ExecuteReader();

                    if (result.HasRows)
                    {

                        while (result.Read())
                        {
                            partida = new Partida();

                            partida.Fecha = result[FECHA].ToString();
                            partida.Detalle = result[CONCEPTO].ToString();

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

        private void insertarCuentaPartida(CuentaPartida cuentaPartida)
        {
            using (SQLiteCommand command = new SQLiteCommand())
            {
                string sql = $"INSERT INTO  {TABLE_CUENTA_PARTIDA}({ID_CUENTA_PARTIDA}, {ID_CUENTA}, {ID_PARTIDA}, {DEBE}, {HABER}) ";
                sql += "VALUES (NULL, @idCuenta, @idPartida, @debe, @haber);";
                command.CommandText = sql;
                command.Connection = Conexion.Conn;
                command.Parameters.Add(new SQLiteParameter("@idCuenta", cuentaPartida.IdCuenta));
                command.Parameters.Add(new SQLiteParameter("@idPartida", cuentaPartida.IdPartida));
                command.Parameters.Add(new SQLiteParameter("@debe", cuentaPartida.Debe));
                command.Parameters.Add(new SQLiteParameter("@haber", cuentaPartida.Haber));
                command.ExecuteNonQuery();

            }

        }

        private int obtenerIdPartidaInsertada(int idLibroDiario)
        {
            int id = 0;

            using (SQLiteCommand command = new SQLiteCommand())
            {
                string sql = $"SELECT {ID_PARTIDA} FROM {TABLE_PARTIDA} WHERE {ID_LIBRO_DIARIO} =@idLibroDiario ORDER BY {ID_PARTIDA} DESC LIMIT 1;";
                command.CommandText = sql;
                command.Connection = Conexion.Conn;
                command.Parameters.Add(new SQLiteParameter("@idLibroDiario", idLibroDiario));
                SQLiteDataReader result = command.ExecuteReader();


                if (result.HasRows)
                {
                    while (result.Read())
                    {

                        id = Convert.ToInt32(result[ID_PARTIDA].ToString());

                    }
                }

            }

            return id;
        }

        private int obtenerIdCuentaActual(string codigoCuenta)
        {
            int id = 0;

            using (SQLiteCommand command = new SQLiteCommand())
            {
                string sql = $"SELECT {ID_CUENTA} FROM {TABLE_CUENTA} WHERE {CODIGO} = @codigo";
                command.CommandText = sql;
                command.Connection = Conexion.Conn;
                command.Parameters.Add(new SQLiteParameter("@codigo", codigoCuenta));
                SQLiteDataReader result = command.ExecuteReader();

                if (result.HasRows)
                {
                    while (result.Read())
                    {

                        id = Convert.ToInt32(result[ID_CUENTA].ToString());

                    }
                }

            }

            return id;
        }

        private List<CuentaPartida> getListCuentasPartida(int idPartida)
        {
            List<CuentaPartida> listaCuentasPartida = new List<CuentaPartida>(); ;


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

                        cuentaPartida.Codigo = result[CODIGO].ToString();
                        cuentaPartida.Nombre = result[NOMBRE_CUENTA].ToString();
                        cuentaPartida.Debe = Convert.ToDouble(result[DEBE].ToString());
                        cuentaPartida.Haber = Convert.ToDouble(result[HABER].ToString());

                        listaCuentasPartida.Add(cuentaPartida);
                    }
                }

            }


            return listaCuentasPartida;

        }

        private void deleteCuentaPartida(int idPartida)
        {
            using (SQLiteCommand command = new SQLiteCommand())
            {
                string sql = $"DELETE FROM {TABLE_CUENTA_PARTIDA} WHERE {ID_PARTIDA} = @idPartida ";

                command.CommandText = sql;
                command.Connection = Conexion.Conn;
                command.Parameters.Add(new SQLiteParameter("@idPartida", idPartida));
                command.ExecuteNonQuery();

            }
        }

        private int obtenerIdPartida(int n_partida, int idLibro)
        {
            int id = 0;

            using (SQLiteCommand command = new SQLiteCommand())
            {
                string sql = $"SELECT {ID_PARTIDA} FROM {TABLE_PARTIDA} WHERE {N_PARTIDA} = @n_partida AND {ID_LIBRO_DIARIO} = @idLibro;";
                command.CommandText = sql;
                command.Connection = Conexion.Conn;
                command.Parameters.Add(new SQLiteParameter("@n_partida", n_partida));
                command.Parameters.Add(new SQLiteParameter("@idLibro", idLibro));
                SQLiteDataReader result = command.ExecuteReader();


                if (result.HasRows)
                {
                    while (result.Read())
                    {

                        id = Convert.ToInt32(result[ID_PARTIDA].ToString());

                    }
                }

            }

            return id;
        }

        private void reorderPartidas(int n_partida)
        {
            using (SQLiteCommand command = new SQLiteCommand())
            {
                string sql = $"UPDATE {TABLE_PARTIDA} SET {N_PARTIDA} = {N_PARTIDA} - 1  WHERE {N_PARTIDA} > @n_partida;";

                command.CommandText = sql;
                command.Connection = Conexion.Conn;
                command.Parameters.Add(new SQLiteParameter("@n_partida", n_partida));
                command.ExecuteNonQuery();

            }
        }

    }
}
