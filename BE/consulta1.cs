using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE
{
    public class consulta1
    {
        public int codigo { get; set; }
        public string nombreJuego { get; set; }
        public int cantidadPartidas { get; set; }

        public consulta1() { }

        public consulta1(int cod, string nj, int cp)
        {
            this.codigo = cod;
            this.nombreJuego = nj;
            this.cantidadPartidas = cp;
        }
    }
}
