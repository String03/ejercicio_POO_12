using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio_POO_12.Modelo
{
   public abstract class Cliente
    {

        public int Legajo { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string RazonSocial { get; set; }
        public List<Contenedor> Contenedores { get; set; } = new List<Contenedor>();

        public override string ToString()
        {
            return Legajo.ToString();
        }
    }

  

}
