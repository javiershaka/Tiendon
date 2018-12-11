using Tiendon.Nucleo.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MySql.Data.MySqlClient;


namespace Tiendon.Web.Controllers
{
    public class ProductoController : Controller
    {
        // GET: Producto
        public ActionResult Index()

        {
            IList<Producto> lis = new List<Producto>();
            try
            {
                MySqlConnection conexion = new MySqlConnection();
                conexion.ConnectionString = "server=db4free.net; uid=javiershaka; pwd=123456789; database=tiendondb; old guids=true";
                conexion.Open();
                MySqlCommand coman = new MySqlCommand(String.Format("SELECT * FROM producto"), conexion);
                MySqlDataReader reader = coman.ExecuteReader();
                while (reader.Read())
                {
                    Producto prod = new Producto();
                    prod.Id = reader.GetString(0);
                    prod.Nombre = reader.GetString(1);
                    prod.Descripcion = reader.GetString(2);
                    prod.Precio = reader.GetString(3);
                    prod.Talla = reader.GetString(4);
                    prod.Genero = reader.GetString(5);
                    prod.stok = reader.GetString(6);
                    prod.Ubicacion = reader.GetString(7);
                    lis.Add(prod);
                }

                conexion.Close();

            }
            catch (Exception ex)
            {

            }
            return View(lis);
        }
        public ActionResult Nuevo()
        {
            return View();
        }
    }
}