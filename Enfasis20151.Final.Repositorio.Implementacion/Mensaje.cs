using Enfasis20151.Final.Dominio.Repositorio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades = Enfasis20151.Final.Dominio.Entidades;

namespace Enfasis20151.Final.Repositorio.Implementacion
{
     class Mensaje : IMensaje
    {
        public Entidades.Mensaje ObtenerMensajes()
        {
            Entidades.Mensaje mensaje = new Entidades.Mensaje()
            {
                Id = 1,
                TextoMensaje = "Felicidades, ganaste el examen final!"
            };
            return mensaje;
        }
    }
}
