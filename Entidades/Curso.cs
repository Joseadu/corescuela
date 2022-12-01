using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CorEscuela.Entidades
{
    public class Curso
    {
        // ATRIBUTOS
        public string UniqueId { get; private set; }
        public string Nombre { get; set; }
        public TiposJornada Jornada { get; set; }


        // CONSTRUCTOR
        public Curso()
        {
            UniqueId = Guid.NewGuid().ToString();
        }
    }
}