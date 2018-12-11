using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MySql.Data.MySqlClient;

namespace Tiendon.Web.Models
{
    public class Conexion
    {
        public MySqlConnection conexion = new MySqlConnection();

        public Object Conectarsql()
        {
            conexion.ConnectionString = "server=db4free.net; uid=javiershaka; pwd=123456789; database=tiendondb; old guids=true";
            try
            {
                conexion.Open();

            }
            catch (Exception e)
            {

            }

            return conexion;

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