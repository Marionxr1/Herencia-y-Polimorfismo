using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using p1bpoo.MisClases;

namespace p1bpoo
{
     public class Vehiculo_combustion : Vehiculo
    {
        private string Combustible { get; }
        private int Cilindros { get; }
        private string Transmision { get; }
        private double repostaje { get; set; }
        private int velocidad = 0;

        public Vehiculo_combustion(int anio, string elColor, string elModelo, string combustible, int cilindros, string transmision, double repostaje) :
            base(anio, elColor, elModelo)
        {
            this.Combustible = combustible;
            this.Cilindros = cilindros;
            this.Transmision = transmision; 
            this.repostaje = repostaje;

        }

        public override void acelerar(int cuanto)
        {
            base.acelerar(cuanto);
            repostaje = repostaje * 0.995;
        }

        public override void frenar(int cuanto)
        {
            base.frenar(cuanto);
        }
    }

}
