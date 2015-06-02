using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Enfasis20151.Final.Repositorio.Implementacion
{
    public class Contexto : DbContext
    {
        public DbSet<Mensaje> Mensajes { get; set; }
    }
}
