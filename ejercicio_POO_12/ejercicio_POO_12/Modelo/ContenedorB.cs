using ejercicio_POO_12.Modelo.Eventos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio_POO_12.Modelo
{
   public class ContenedorB : Contenedor
    {

        public override double Peso
        {
            get { return _peso; }
            set
            {


                base.Peso = value * 1.1;






            }
        }

    }
}
