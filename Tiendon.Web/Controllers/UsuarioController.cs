
using Tiendon.Nucleo.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MySql.Data.MySqlClient;


namespace Tiendon.Web.Controllers
{

    public class UsuarioController : Controller

    {
     
        

        // GET: Usuario
        public ActionResult Index()

        {
            IList<Usuario> lista = new List<Usuario>();
            try
            {
                MySqlConnection conexion = new MySqlConnection();
                conexion.ConnectionString = "server=db4free.net; uid=javiershaka; pwd=123456789; database=tiendondb; old guids=true";
                conexion.Open();    
                MySqlCommand coman = new MySqlCommand(String.Format("SELECT * FROM usuario"), conexion);
                MySqlDataReader reader = coman.ExecuteReader();
                while (reader.Read())
                {
                    Usuario us = new Usuario();
                    us.Id = reader.GetString(0);
                    us.Correo = reader.GetString(1);
                    us.Password = reader.GetString(2);
                    us.Nombre = reader.GetString(3);
                    us.Edad = reader.GetInt16(4);
                    us.Sexo = reader.GetString(5);
                    us.Direccion = reader.GetString(6);
                    lista.Add(us);
                }

                conexion.Close();

            }
            catch(Exception ex)
            {

            }
            return View(lista);
        }
      
        public ActionResult Registro()
        {
            return View();
        }
        public ActionResult Login()
        {
            return View();
        }
    }
}