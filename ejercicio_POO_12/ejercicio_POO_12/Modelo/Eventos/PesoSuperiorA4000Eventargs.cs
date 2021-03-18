using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio_POO_12.Modelo.Eventos
{
    public class PesoSuperiorA4000Eventargs : EventArgs
    {
        public Contenedor Contenedor { get; set; }
        public Cliente Cliente { get; set; }

    }
}
