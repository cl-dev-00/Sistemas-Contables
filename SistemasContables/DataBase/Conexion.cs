using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;
using System.IO;
using System.Windows.Forms;

// Para establecer la conexion a la database se utilizo Singleton Pattern

namespace SistemasContables.DataBase
{

    public class Conexion
    {
        private const string dataConnection = @"Data Source=./database.db; PRAGMA foreign_keys=ON; UTF8Encoding=True; Version=3";

        static private SQLiteConnection conn = null;
        static public SQLiteConnection Conn
        {
            get
            {

                if(conn == null)
                {
                    conn = new SQLiteConnection(dataConnection);

                    if (!File.Exists("./database.db"))
                    {
                        CreateDataBase();
                    }

                }

                return conn;
            }
        }

        public Conexion()
        {
            
        }

        static private void CreateDataBase() {

            SQLiteConnection.CreateFile("./database.db");

            conn.Open();

            using(SQLiteCommand command = new SQLiteCommand())
            {
                string sql = @"PRAGMA foreign_keys = ON;";

                sql += "CREATE TABLE librodiario(";
                sql += "n_libro INTEGER PRIMARY KEY AUTOINCREMENT,";
                sql += "periodo text(200)";
                sql += ");";

                sql += "CREATE TABLE plantilla(";
                sql += "idPlantilla INTEGER PRIMARY KEY AUTOINCREMENT,";
                sql += "nombrePlantilla TEXT(200),";
                sql += "cuentaDefault TEXT(200),";
                sql += "tipoIVA TEXT(100)";
                sql += ");";

                sql += "CREATE TABLE cuenta(";
                sql += "idCuenta INTEGER PRIMARY KEY AUTOINCREMENT,";
                sql += "codigo INTEGER(10),";
                sql += "nivel INTEGER(10),";
                sql += "nombreCuenta TEXT(100),";
                sql += "tipoSaldo TEXT(100)";
                sql += ");";

                sql += "CREATE TABLE partida(";
                sql += "idPartida INTEGER PRIMARY KEY AUTOINCREMENT,";
                sql += "fecha TEXT(100),";
                sql += "concepto TEXT,";
                sql += "n_partida INTEGER,";
                sql += "n_libro INTEGER,";
                sql += "FOREIGN KEY(n_libro) REFERENCES librodiario(n_libro) ";
                sql += "ON DELETE CASCADE ";
                sql += "ON UPDATE CASCADE";
                sql += ");";

                sql += "CREATE TABLE cuenta_en_plantilla(";
                sql += "idCuentaEnPlantilla INTEGER PRIMARY KEY AUTOINCREMENT,";
                sql += "idCuenta INTEGER,";
                sql += "debe TEXT(50),";
                sql += "haber TEXT(50),";
                sql += "idPlantilla INTEGER,";
                sql += "FOREIGN KEY(idCuenta) REFERENCES cuenta(idCuenta) ";
                sql += "ON DELETE CASCADE ";
                sql += "ON UPDATE CASCADE ";
                sql += "FOREIGN KEY(idPlantilla) REFERENCES plantilla(idPlantilla) ";
                sql += "ON DELETE CASCADE ";
                sql += "ON UPDATE CASCADE";
                sql += ");";

                sql += "CREATE TABLE cuenta_partida(";
                sql += "id_cuenta_partida INTEGER PRIMARY KEY AUTOINCREMENT,";
                sql += "idCuenta INTEGER,";
                sql += "idPartida INTEGER,";
                sql += "debe REAL,";
                sql += "haber REAL,";
                sql += "FOREIGN KEY(idCuenta) REFERENCES cuenta(idCuenta) ";
                sql += "ON DELETE CASCADE ON UPDATE CASCADE ";
                sql += "FOREIGN KEY(idPartida) REFERENCES plantilla(idPartida) ";
                sql += "ON DELETE CASCADE ON UPDATE CASCADE";
                sql += ");";


                command.CommandText = sql;
                command.Connection = conn;
                command.ExecuteNonQuery();

            }

            conn.Close();

        }

    }
}
