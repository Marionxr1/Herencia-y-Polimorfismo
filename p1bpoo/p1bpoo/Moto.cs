using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using p1bpoo.MisClases;

namespace p1bpoo
{
    internal class Moto:Vehiculo
    {
        private string Tipo { get; }
        private int Tiempos { get; }
        private int Cubicaje { get; }

        public Moto(int anio, string elColor, string elModelo, string tipo, int tiempos, int cubicaje) :
            base(anio, elColor, elModelo)
        {
            this.Tipo = tipo;
            this.Tiempos = tiempos;
            this.Cubicaje = cubicaje;

        }

        public override void acelerar(int cuanto)
        {
            base.acelerar(cuanto * 2);
            
        }

        public override void frenar(int cuanto)
        {
            base.frenar(cuanto);
        }
    }
}
