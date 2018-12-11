

using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;


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
            

            return View();
        }
      
        public ActionResult Registro()
        {
            return View();
        }
    }
}