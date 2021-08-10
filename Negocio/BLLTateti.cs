using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MPP;
using BE;

namespace Negocio
{
    public class BLLTateti : BLLJuegos
    {
        MPPJuegos oMPPJuego = new MPPJuegos();
        public bool chequearEmpate(int[]estado)
        {
            foreach(int a in estado)
            {
                if (a == 0)
                {
                    return false;
                }
            }
            return true;
        }
        public bool chequearVictoria(int[] estado)
        {
            if (estado[0] == 1 && estado[1] == 1 && estado[2] == 1)
            {
                MessageBox.Show("Las x Han Ganado");
                return true;
            }
            if (estado[3] == 1 && estado[4] == 1 && estado[5] == 1)
            {
                MessageBox.Show("Las x Han Ganado");
                return true;
            }
            if (estado[6] == 1 && estado[7] == 1 && estado[8] == 1)
            {
                MessageBox.Show("Las x Han Ganado");
                return true;
            }
            if (estado[0] == 1 && estado[3] == 1 && estado[6] == 1)
            {
                MessageBox.Show("Las x Han Ganado");
                return true;
            }
            if (estado[1] == 1 && estado[4] == 1 && estado[7] == 1)
            {
                MessageBox.Show("Las x Han Ganado");
                return true;
            }
            if (estado[2] == 1 && estado[5] == 1 && estado[8] == 1)
            {
                MessageBox.Show("Las x Han Ganado");
                return true;
            }
            if (estado[0] == 1 && estado[4] == 1 && estado[8] == 1)
            {
                MessageBox.Show("Las x Han Ganado");
                return true;
            }
            if (estado[2] == 1 && estado[4] == 1 && estado[6] == 1)
            {
                MessageBox.Show("Las x Han Ganado");
                return true;
            }
            if (estado[0] == 2 && estado[1] == 2 && estado[2] == 2)
            {
                MessageBox.Show("Las O Han Ganado");
                return true;
            }
            if (estado[3] == 2 && estado[4] == 2 && estado[5] == 2)
            {
                MessageBox.Show("Las 0 Han Ganado");
                return true;
            }
            if (estado[6] == 2 && estado[7] == 2 && estado[8] == 2)
            {
                MessageBox.Show("Las 0 Han Ganado");
                return true;
            }
            if (estado[0] == 2 && estado[3] == 2 && estado[6] == 2)
            {
                MessageBox.Show("Las 0 Han Ganado");
                return true;
            }
            if (estado[1] == 2 && estado[4] == 2 && estado[7] == 2)
            {
                MessageBox.Show("Las 0 Han Ganado");
                return true;
            }
            if (estado[2] == 2 && estado[5] == 2 && estado[8] == 2)
            {
                MessageBox.Show("Las 0 Han Ganado");
                return true;
            }
            if (estado[0] == 2 && estado[4] == 2 && estado[8] == 2)
            {
                MessageBox.Show("Las 0 Han Ganado");
                return true;
            }
            if (estado[2] == 2 && estado[4] == 2 && estado[6] == 2)
            {
                MessageBox.Show("Las 0 Han Ganado");
                return true;
            }

            return false;
        }
        public int jugarPC(int[] estados, int lados,BEJuego juego)
        {
            bool cambiado = true;
            int aux2=0;
            while (cambiado)
            {
                Random aux = new Random();
                aux2 = aux.Next(0, 8);
                if (estados[aux2] == 0)
                {
                    estados[aux2] = lados;
                    if (chequearVictoria(estados))
                    {
                        juego.listaJugadores.Add( new BEUsuario(0, "PC"));
                        MessageBox.Show("La pc ha ganado");
                        oMPPJuego.cargarPartidas(juego);
                        return aux2+10;
                    }
                    else { return aux2; }
                    

                }
            }
           
            return aux2;
        }
        public bool jugarJugador(int[] estados, int lado,int posicion,BEJuego juego)
        {
            estados[posicion] = lado;
            if (chequearVictoria(estados)) { MessageBox.Show("Felicitaciones has Ganado");juego.listaJugadores.Add(juego.listaJugadores[0]) ; oMPPJuego.cargarPartidas(juego) ; return true; }
            if (chequearEmpate(estados)){ MessageBox.Show("La partida ah sido empatad"); juego.listaJugadores.Add(new BEUsuario(9999, "Empate"));oMPPJuego.cargarPartidas(juego);return true; }
            return false;
        }

    }
}
