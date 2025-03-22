using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using p1bpoo.MisClases;

namespace p1bpoo
{
    public class Camion:Vehiculo
    {
        private int Tonelaje { get; }
        private int Ejes { get; }
        private string Frenos { get; }

        public Camion(int anio, string elColor, string elModelo, int tonelaje, int ejes, string frenos) :
            base(anio, elColor, elModelo)
        {
            this.Tonelaje = tonelaje;
            this.Ejes = ejes;
            this.Frenos = frenos;

        }

        public override void acelerar(int cuanto)
        {
            base.acelerar(cuanto);
           
        }

        public override void frenar(int cuanto)
        {
            base.frenar(cuanto);
        }
    }
}
