using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE
{
    public class BEJuego
    {
        public int codigo { get; set; }
        public string nombre { get; set; }
        public List<BEUsuario> listaJugadores;
    
        public BEJuego() { listaJugadores = new List<BEUsuario>(); }

        public BEJuego(int cod, string nom)
        {
            this.codigo = cod;
            this.nombre = nom;
            listaJugadores = new List<BEUsuario>();
        }
        public BEJuego(int cod, string nom, BEUsuario jugador1, BEUsuario jugador2, BEUsuario jugadorGanar)
        {
            this.codigo = cod;
            this.nombre = nom;
            listaJugadores = new List<BEUsuario>();
            listaJugadores.Add(jugador1);
            listaJugadores.Add(jugador2);
            listaJugadores.Add(jugadorGanar);
        }
    }

    
}
