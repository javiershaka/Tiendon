
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
        ////
        //public ActionResult ObtenerTodos()
        //{
        //    try
        //    {
        //        IList<Usuario> usuarios = new List<Usuario>();
        //        Usuario u = new Usuario();

        //        u.Nombre = "javis Lopez";
        //        u.Cuenta = "javiershaka";
        //        u.Direccion = "Periferico #81";
        //        u.Id = 16656;
        //        u.Telefono = "6222277534";
        //        usuarios.Add(u);



        //        return Json(new { data = usuarios }, JsonRequestBehavior.AllowGet);



        //    }
        //    catch (Exception ex)
        //    {
        //        return RedirectToAction("Error", "Home");
        //    }

        //}
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
                    us.Nombre = reader.GetString(1);
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
    }
}