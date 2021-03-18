using ejercicio_POO_12.Modelo.Eventos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio_POO_12.Modelo
{
   public abstract class Contenedor
    {
        public int Codigo { get; set; }
        public string Denominacion { get; set; }
        public DateTime FechaDeIngreso { get; set; }
        protected double _peso;
        public event EventHandler ContenerPesoSuperiorA4000EventArgs;
        public Cliente Cliente { get; set; }

        public virtual double Peso
        {
            get { return _peso; }
            set {
                  _peso = value;
                if (_peso > 4000 && ContenerPesoSuperiorA4000EventArgs != null)

                {

                    PesoSuperiorA4000Eventargs args = new PesoSuperiorA4000Eventargs();
                    args.Contenedor = this;
                    args.Cliente = Cliente;

                    ContenerPesoSuperiorA4000EventArgs(this, args);
                }




            }
        }






    }
}
