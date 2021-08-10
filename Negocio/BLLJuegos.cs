using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BE;
using MPP;

namespace Negocio
{
    public class BLLJuegos
    {
        MPPJuegos oMPPJuegos = new MPPJuegos();
        public List<consulta1> juegoMasJugado()
        {
            return oMPPJuegos.juegoMasJugado();

        }
        public List<BEJuego> listarJuegos()
        {
           return oMPPJuegos.listarJuegos();
        }
    }
}
