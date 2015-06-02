using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Enfasis20151.Final.Dominio.Entidades;
using Enfasis20151.Final.Dominio.Repositorio;
using Enfasis20151.Final.Repositorio.Implementacion;


namespace Enfasis20151.Final.Web.Controllers
{
    public class MensajeController : Controller
    {
        private Dominio.Repositorio.IMensaje _repositorioMensaje;

        public MensajeController()
        {
            _repositorioMensaje = new Mensaje();
        }
        // GET: Mensaje
        public ActionResult VerMensaje()
        {

            Mensaje mensaje = _repositorioMensaje.ObtenerMensaje();
            return View(mensaje);
        }
    }
}