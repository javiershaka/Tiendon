using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Tiendon.Web.Models;
using MySql.Data.MySqlClient;
using Tiendon.Nucleo.Entidades;

namespace Tiendon.Web.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {



            IList<Producto> lista = new List<Producto>();
            try
            {
                MySqlConnection conexion = new MySqlConnection();
                conexion.ConnectionString = "server=db4free.net; uid=javiershaka; pwd=123456789; database=tiendondb; old guids=true";
                conexion.Open();
                MySqlCommand coman = new MySqlCommand(String.Format("SELECT * FROM usuario"), conexion);
                MySqlDataReader reader = coman.ExecuteReader();
                while (reader.Read())
                {
                    Producto prod = new Producto();
                    prod.Nombre = reader.GetString(1);
                    lista.Add(prod);
                }

                conexion.Close();

            }
            catch (Exception ex)
            {

            }
            return View(lista);
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}