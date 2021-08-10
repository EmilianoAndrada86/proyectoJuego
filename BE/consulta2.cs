using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE
{
    public class consulta2
    {
        public int codigoJugador { get; set; }
        public string nombreJugador { get; set; }
        public int cantGanadas { get; set; }
        public int cantEmpatadas { get; set; }
        public int cantPerdidas { get; set; }

        public consulta2() { }

        public consulta2(int cj, string nj)
        {
            this.codigoJugador = cj;
            this.nombreJugador = nj;
            this.cantGanadas = 0;
            this.cantEmpatadas = 0;
            this.cantPerdidas = 0;
        }
    }
}
