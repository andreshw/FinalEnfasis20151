using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades = Enfasis20151.Final.Dominio.Entidades;

namespace Enfasis20151.Final.Dominio.Repositorio
{
    public interface IMensaje
    {
        Entidades.Mensaje ObtenerMensaje();
    }
}
