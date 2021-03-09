using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Text;
using MySql.Data.MySqlClient;
namespace CLASE3_ARBOLES.Clases.BaseDatos
{
   
        class ClsConexion
        {
            MySqlConnection conexionbasedatos;
            private String cadenaConexion { get; }

            public ClsConexion()
            {
                string servid = "localhost"; //Nombre o ip del servidor de MySQL
                string basedatos = "basedatosjuego";  //Nombre de la base de datos
                string usuario = "root";       //Usuario de acceso a MySQL
                string contrasena = "";        //Contraseña de usuario de acceso a MySQL


                cadenaConexion = "Database=" + basedatos + "; Data Source=" + servid + "; User Id=" + usuario + "; Password=" + contrasena + "";
            }

            public void cerraConexion()
            {
                conexionbasedatos.Close();
            }

            public void abrirConexion()
            {
                conexionbasedatos = new MySqlConnection(cadenaConexion);
                conexionbasedatos.Open();
            }

            



            public DataTable consultandodatosdirectamente(String sqll)
            {
                abrirConexion();
                MySqlDataReader dr;
                MySqlCommand comm = new MySqlCommand(sqll, conexionbasedatos);
                dr = comm.ExecuteReader();

                var dataTable = new DataTable();
                dataTable.Load(dr);
                cerraConexion();
                return dataTable;
            }


            //insertar animales
            public void EjecutaSQLDirecto(String sqll)
            {
                abrirConexion();
                try
                {

                    MySqlCommand comm = new MySqlCommand(sqll, conexionbasedatos);
                    comm.ExecuteReader();
                }
                catch (Exception e)
                {
                    Console.Write(e.Message);
                }
                finally
                {
                    cerraConexion();
                }
            }


        }
}

