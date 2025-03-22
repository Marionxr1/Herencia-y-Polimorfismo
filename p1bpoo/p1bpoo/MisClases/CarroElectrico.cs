using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace p1bpoo.MisClases
{
    internal class CarroElectrico : Vehiculo
    {
        private int cargaBateria;
        private int limiteVelocidad;
        private bool esHibrido;

        public CarroElectrico(int anio, string elColor, string elModelo, int limiteVelocidad, bool esHibrido) : base (anio, elColor, elModelo)
        {
            cargaBateria = 50;
            this.limiteVelocidad = limiteVelocidad;
            this.esHibrido = esHibrido;
        }

        public override void acelerar(int cuanto)
        {
            base.acelerar(cuanto);
            cargaBateria--;
        }


        public int NivelBateria() { return cargaBateria; }
        public void cargarBateria()
        {
            cargaBateria++;
        }

        public override void frenar(int cuanto)
        {
            base.frenar(cuanto);
        }

    }
}
