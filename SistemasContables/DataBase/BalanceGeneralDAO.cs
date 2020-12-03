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
    class BalanceGeneralDAO
    {
        private SQLiteConnection conn;

        private String[] Activos_txt;
        private String[] Pasivos_txt;

        private double[] activos__;
        private double[] pasivos__;

        private bool limite;
        private double saldo;


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

        public BalanceGeneralDAO()
        {
           

        }

        public void getActivos(int idLibroDiario)
        {
            try
            {
                conn = Conexion.Conn;

                conn.Open();

                limite = false;

                using (SQLiteCommand command = new SQLiteCommand())
                {
                    string sql = $"SELECT {TABLE_CUENTA}.{NOMBRE_CUENTA}, {TABLE_CUENTA_PARTIDA}.{DEBE}, {TABLE_CUENTA_PARTIDA}.{HABER} FROM {TABLE_CUENTA_PARTIDA} ";
                    sql += $"INNER JOIN {TABLE_CUENTA} ON {TABLE_CUENTA_PARTIDA}.{ID_CUENTA} = {TABLE_CUENTA}.{ID_CUENTA} ";
                    sql += $"INNER JOIN {TABLE_PARTIDA} ON {TABLE_CUENTA_PARTIDA}.{ID_PARTIDA} = {TABLE_PARTIDA}.{ID_PARTIDA} ";
                    sql += $"WHERE  {TABLE_PARTIDA}.{ID_LIBRO_DIARIO} = @idLibroDiario AND {TABLE_CUENTA}.{CODIGO} LIKE  @codigo || '%' ";
                    command.CommandText = sql;
                    command.Connection = Conexion.Conn;
                    command.Parameters.Add(new SQLiteParameter("@codigo", 1));
                    command.Parameters.Add(new SQLiteParameter("@idLibroDiario", idLibroDiario));
                    Activos_txt[0] = "Activos";
                    activos__[0] = 0;
                    using (SQLiteDataReader result = command.ExecuteReader())
                    {
                        if (result.HasRows)
                        {
                            while (result.Read())
                            {
                                if (Activos_txt.Length == 1)
                                {
                                    if (double.Parse(result[HABER].ToString()) <= 0)
                                    {
                                        addActivos(result[NOMBRE_CUENTA].ToString(), double.Parse(result[DEBE].ToString()));

                                    }
                                    else if (double.Parse(result[HABER].ToString()) > 0)
                                    {
                                        addActivos(result[NOMBRE_CUENTA].ToString(), 0 - double.Parse(result[DEBE].ToString()));
                                    }
                                }
                                else if (Activos_txt.Length > 1)
                                {
                                    for (int i = 0; i < Activos_txt.Length; i++)
                                    {

                                        if (Activos_txt[i].Equals(result[NOMBRE_CUENTA].ToString()))
                                        {
                                            saldo = activos__[i];

                                            if (double.Parse(result[HABER].ToString()) <= 0)
                                            {
                                                saldo += double.Parse(result[DEBE].ToString());
                                                activos__[i] = saldo;
                                            }
                                            else if (double.Parse(result[HABER].ToString()) > 0)
                                            {
                                                saldo += 0 - double.Parse(result[HABER].ToString());
                                                activos__[i] = saldo;
                                            }
                                            limite = true;
                                            break;
                                        }
                                        else
                                        {
                                            limite = false; 
                                        }
                                    }

                                    if (!limite)
                                    {
                                        if (double.Parse(result[HABER].ToString()) <= 0)
                                        {
                                            addActivos(result[NOMBRE_CUENTA].ToString(),  double.Parse(result[DEBE].ToString()));
                                        }
                                        else if (double.Parse(result[HABER].ToString()) > 0)
                                        {
                                            addActivos(result[NOMBRE_CUENTA].ToString(), 0 - double.Parse(result[DEBE].ToString()));
                                          

                                        }
                                    }
                                }
                            }
                          
                        }
                    }

                    //ingresos = 651651651;
                    conn.Close();
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }


        public void addActivos(string activos_, double activos)
        {

            for(int i =1; i<=Activos_txt.Length; i++)
            {

                if(Activos_txt.Length == i)
                {
                    Array.Resize(ref Activos_txt, i++);
                    Array.Resize(ref activos__, i++);
                }
                Activos_txt[i] = activos_;
                activos__[i] = activos;               
             }
        }

        public void getPasivos(int idLibroDiario)
        {
            try
            {
                conn = Conexion.Conn;

                conn.Open();

                limite = false;

                using (SQLiteCommand command = new SQLiteCommand())
                {
                    string sql = $"SELECT {TABLE_CUENTA}.{NOMBRE_CUENTA}, {TABLE_CUENTA_PARTIDA}.{DEBE}, {TABLE_CUENTA_PARTIDA}.{HABER} FROM {TABLE_CUENTA_PARTIDA} ";
                    sql += $"INNER JOIN {TABLE_CUENTA} ON {TABLE_CUENTA_PARTIDA}.{ID_CUENTA} = {TABLE_CUENTA}.{ID_CUENTA} ";
                    sql += $"INNER JOIN {TABLE_PARTIDA} ON {TABLE_CUENTA_PARTIDA}.{ID_PARTIDA} = {TABLE_PARTIDA}.{ID_PARTIDA} ";
                    sql += $"WHERE  {TABLE_PARTIDA}.{ID_LIBRO_DIARIO} = @idLibroDiario AND {TABLE_CUENTA}.{CODIGO} LIKE  @codigo || '%' ";
                    command.CommandText = sql;
                    command.Connection = Conexion.Conn;
                    command.Parameters.Add(new SQLiteParameter("@codigo", 2));
                    command.Parameters.Add(new SQLiteParameter("@idLibroDiario", idLibroDiario));
                    Pasivos_txt[0] = "Pasivos";
                    pasivos__[0] = 0;
                    using (SQLiteDataReader result = command.ExecuteReader())
                    {
                        if (result.HasRows)
                        {
                            while (result.Read())
                            {
                                if (Pasivos_txt.Length == 1)
                                {
                                    if (double.Parse(result[HABER].ToString()) <= 0)
                                    {
                                        addPasivos(result[NOMBRE_CUENTA].ToString(), double.Parse(result[DEBE].ToString()));

                                    }
                                    else if (double.Parse(result[HABER].ToString()) > 0)
                                    {
                                        addPasivos(result[NOMBRE_CUENTA].ToString(), 0 - double.Parse(result[DEBE].ToString()));
                                    }
                                }
                                else if (Pasivos_txt.Length > 1)
                                {
                                    for (int i = 0; i < Activos_txt.Length; i++)
                                    {

                                        if (Pasivos_txt[i].Equals(result[NOMBRE_CUENTA].ToString()))
                                        {
                                            saldo = activos__[i];

                                            if (double.Parse(result[HABER].ToString()) <= 0)
                                            {
                                                saldo += double.Parse(result[DEBE].ToString());
                                                activos__[i] = saldo;
                                            }
                                            else if (double.Parse(result[HABER].ToString()) > 0)
                                            {
                                                saldo += 0 - double.Parse(result[HABER].ToString());
                                                activos__[i] = saldo;
                                            }
                                            limite = true;
                                            break;
                                        }
                                        else
                                        {
                                            limite = false;
                                        }
                                    }

                                    if (!limite)
                                    {
                                        if (double.Parse(result[HABER].ToString()) <= 0)
                                        {
                                            addPasivos(result[NOMBRE_CUENTA].ToString(), double.Parse(result[DEBE].ToString()));
                                        }
                                        else if (double.Parse(result[HABER].ToString()) > 0)
                                        {
                                            addPasivos(result[NOMBRE_CUENTA].ToString(), 0 - double.Parse(result[DEBE].ToString()));


                                        }
                                    }
                                }
                            }

                        }
                    }

                    //ingresos = 651651651;
                    conn.Close();
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        public void addPasivos(string pasivos_, double pasivos)
        {

            for (int i = 1; i <= Pasivos_txt.Length; i++)
            {
                if (Pasivos_txt.Length == i)
                {
                    Array.Resize(ref Pasivos_txt, i++);
                    Array.Resize(ref pasivos__, i++);
                }
                Activos_txt[i] = pasivos_;
                activos__[i] = pasivos;
            }
        }

        public String[] getActivos_txt()
        {
            return Activos_txt; 
        }
        public double[] getActivos__()
        {
            return activos__;
        }
        public String[] getPasivos_txt()
        {
            return Pasivos_txt;
        }
        public double[] getPasivos__()
        {
            return pasivos__;
        }

    }
}