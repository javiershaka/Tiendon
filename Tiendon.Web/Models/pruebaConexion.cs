﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MySql.Data.MySqlClient;

namespace Tiendon.Web.Models
{
    public class pruebaConexion
    {
        public MySqlConnection conexion = new MySqlConnection();
    
        public String Conectarsql()
        {
            conexion.ConnectionString = "server=localhost ; database=xemletbd; uid=root; pwd=javiershaka;";
            try
            {
                conexion.Open();
               
            }
            catch(Exception e)
            {
                
            }

            return conexion.ToString();

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