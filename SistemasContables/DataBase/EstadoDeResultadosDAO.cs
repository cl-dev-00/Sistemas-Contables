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
    class EstadoDeResultadosDAO
    {
        private SQLiteConnection conn;

        private Double Debe = 0.00;
        private Double Haber = 0.00;
        private Double ingresos = 0.0;
        private Double costos = 0.0;
        private Double gastos = 0.0;

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

        public EstadoDeResultadosDAO()
        {

        }

        public double getTotalIngresos(int idLibroDiario)
        {

            try
            {
                conn = Conexion.Conn;

                conn.Open();

                using (SQLiteCommand command = new SQLiteCommand())
                {
                    string sql = $"SELECT {TABLE_CUENTA}.{NOMBRE_CUENTA}, {TABLE_CUENTA_PARTIDA}.{DEBE}, {TABLE_CUENTA_PARTIDA}.{HABER} FROM {TABLE_CUENTA_PARTIDA} ";
                    sql += $"INNER JOIN {TABLE_CUENTA} ON {TABLE_CUENTA_PARTIDA}.{ID_CUENTA} = {TABLE_CUENTA}.{ID_CUENTA} ";
                    sql += $"INNER JOIN {TABLE_PARTIDA} ON {TABLE_CUENTA_PARTIDA}.{ID_PARTIDA} = {TABLE_PARTIDA}.{ID_PARTIDA} ";
                    sql += $"WHERE  {TABLE_PARTIDA}.{ID_LIBRO_DIARIO} = @idLibroDiario AND {TABLE_CUENTA}.{CODIGO} LIKE  @codigo || '%' ";

                    command.CommandText = sql;
                    command.Connection = Conexion.Conn;
                    command.Parameters.Add(new SQLiteParameter("@codigo", 5));
                    command.Parameters.Add(new SQLiteParameter("@idLibroDiario", idLibroDiario));
                    using (SQLiteDataReader result = command.ExecuteReader())
                    {
                        if (result.HasRows)
                        {

                            while (result.Read())
                            {
                                Debe += double.Parse(result[DEBE].ToString());
                                Haber += double.Parse(result[HABER].ToString());
                                ingresos = Haber - Debe;
                            }
                        }
                    }
                }

                //ingresos = 651651651;
                conn.Close();
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return ingresos;
        }

        public double getTotalCostos(int idLibroDiario)
        {

            try
            {
                conn = Conexion.Conn;

                conn.Open();

                using (SQLiteCommand command = new SQLiteCommand())
                {
                    string sql = $"SELECT {TABLE_CUENTA}.{NOMBRE_CUENTA}, {TABLE_CUENTA_PARTIDA}.{DEBE}, {TABLE_CUENTA_PARTIDA}.{HABER} FROM {TABLE_CUENTA_PARTIDA} ";
                    sql += $"INNER JOIN {TABLE_CUENTA} ON {TABLE_CUENTA_PARTIDA}.{ID_CUENTA} = {TABLE_CUENTA}.{ID_CUENTA} ";
                    sql += $"INNER JOIN {TABLE_PARTIDA} ON {TABLE_CUENTA_PARTIDA}.{ID_PARTIDA} = {TABLE_PARTIDA}.{ID_PARTIDA} ";
                    sql += $"WHERE  {TABLE_PARTIDA}.{ID_LIBRO_DIARIO} = @idLibroDiario AND {TABLE_CUENTA}.{CODIGO} LIKE  @codigo || '%' ";

                    command.CommandText = sql;
                    command.Connection = Conexion.Conn;
                    command.Parameters.Add(new SQLiteParameter("@codigo", 41));
                    command.Parameters.Add(new SQLiteParameter("@idLibroDiario", idLibroDiario));
                    using (SQLiteDataReader result = command.ExecuteReader())
                    {
                        if (result.HasRows)
                        {

                            while (result.Read())
                            {
                                Debe += double.Parse(result[DEBE].ToString());
                                Haber += double.Parse(result[HABER].ToString());
                                costos = Debe - Haber;
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
            return costos;
        }

        public double getTotalGastos(int idLibroDiario)
        {

            try
            {
                conn = Conexion.Conn;

                conn.Open();

                using (SQLiteCommand command = new SQLiteCommand())
                {
                    string sql = $"SELECT {TABLE_CUENTA}.{NOMBRE_CUENTA}, {TABLE_CUENTA_PARTIDA}.{DEBE}, {TABLE_CUENTA_PARTIDA}.{HABER} FROM {TABLE_CUENTA_PARTIDA} ";
                    sql += $"INNER JOIN {TABLE_CUENTA} ON {TABLE_CUENTA_PARTIDA}.{ID_CUENTA} = {TABLE_CUENTA}.{ID_CUENTA} ";
                    sql += $"INNER JOIN {TABLE_PARTIDA} ON {TABLE_CUENTA_PARTIDA}.{ID_PARTIDA} = {TABLE_PARTIDA}.{ID_PARTIDA} ";
                    sql += $"WHERE  {TABLE_PARTIDA}.{ID_LIBRO_DIARIO} = @idLibroDiario AND {TABLE_CUENTA}.{CODIGO} LIKE  @codigo || '%' ";

                    command.CommandText = sql;
                    command.Connection = Conexion.Conn;
                    command.Parameters.Add(new SQLiteParameter("@codigo", 42));
                    command.Parameters.Add(new SQLiteParameter("@idLibroDiario", idLibroDiario));
                    using (SQLiteDataReader result = command.ExecuteReader())
                    {
                        if (result.HasRows)
                        {

                            while (result.Read())
                            {
                                Debe += double.Parse(result[DEBE].ToString());
                                Haber += double.Parse(result[HABER].ToString());
                                gastos = Debe;
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
            return gastos;
        }
    }
}