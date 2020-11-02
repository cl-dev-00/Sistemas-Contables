﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;
using System.IO;
using System.Windows.Forms;

namespace SistemasContables.DataBase
{

    public class Conexion
    {
        public string connectionString { get; set; }
        private string connection;

        private SQLiteConnection conn;
        public SQLiteConnection Conn
        {
            get
            {
                return this.conn;
            }
            set
            {
                this.conn = value;
            }
        }

        public void getConnection()
        {
            connection = @"Data Source=./database.db; Version=3";
            connectionString = connection;
        }

        public Conexion()
        {
            try
            {
                getConnection();
                conn = new SQLiteConnection(connectionString);

                conn.Open();
                conn.Close();

                MessageBox.Show("Exito");

            } catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            /*

            if (!File.Exists("./database.db"))
            {
                SQLiteConnection.CreateFile("./database.bd");
                getConnection();

                using(SQLiteConnection Connect = new SQLiteConnection(connection))
                {
                    SQLiteCommand command = new SQLiteCommand();
                    Connect.Open();

                    string sql = @"CREATE TABLE user(id Integer(11), username Text(25))";

                    command.CommandText = sql;
                    command.Connection = Connect;
                    command.ExecuteNonQuery();

                    Connect.Close();
                }
                
            } else
            {
                MessageBox.Show("Error Conexion a la base de datos");
            } */
        }

    }
}