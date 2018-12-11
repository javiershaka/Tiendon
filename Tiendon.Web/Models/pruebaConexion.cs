using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MySql.Data.MySqlClient;

namespace Tiendon.Web.Models
{
    public class pruebaConexion
    {
        private MySqlConnection conexion = new MySqlConnection();
        String cp = "";
        public String Conectarsql()
        {
            conexion.ConnectionString = "server=localhost ; database=xemletbd; uid=root; pwd=javiershaka;";
            try
            {
                conexion.Open();
                 cp = "se conecto";
                Console.Write(""+cp);
            }
            catch(Exception e)
            {
                cp = "no se conecto";
            }

            return cp;

        }
        public void cerrarConexion()
        {
            try
            {
                if (conexion.State == System.Data.ConnectionState.Open)
                {
                    conexion.Close();
                }
            }
            catch (Exception e)
            {
                
            }

        }
        

    }

    
}