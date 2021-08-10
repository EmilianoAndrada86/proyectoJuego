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
   public class BLLPipati : BLLJuegos
    {
        MPPJuegos oMPPJuego = new MPPJuegos();
        BEJuego oBEJuego;
        public void jugar(int seleccion, BEUsuario Jugador)
        {
           
            Random aux = new Random();
            int pcSeleccion = aux.Next(1, 4);
            switch (seleccion)
            {
                case 1:
                    
                    if (pcSeleccion == 2)
                    {
                        MessageBox.Show("La Maquina Ah Elegido Papel");
                        MessageBox.Show("Te dije que no ganarias Muahahaha");
                        oBEJuego = new BEJuego(1, "Piedra Papel o Tijera", Jugador, new BEUsuario(0, "PC"), new BEUsuario(0, "PC"));
                        oMPPJuego.cargarPartidas(oBEJuego);
                        
                    }
                    if (pcSeleccion == 3) { 
                        MessageBox.Show("La Maquina Ah Elegido Tijeras");
                        MessageBox.Show("Oh no me has derrotado!");
                        oBEJuego = new BEJuego(1, "Piedra Papel o Tijera", Jugador, new BEUsuario(0, "PC"), Jugador);
                        oMPPJuego.cargarPartidas(oBEJuego);
                    }
                    if (pcSeleccion == 1) { 
                        MessageBox.Show("La Maquina Ah Elegido Piedra");
                        MessageBox.Show("La partida ha sido empate");
                        oBEJuego = new BEJuego(1, "Piedra Papel o Tijera", Jugador, new BEUsuario(0, "PC"), new BEUsuario(9999,"Empate"));
                        oMPPJuego.cargarPartidas(oBEJuego);
                    }
                    break;
                case 2:
                    if (pcSeleccion == 2)
                    {
                        MessageBox.Show("La Maquina Ah Elegido Papel");
                        MessageBox.Show("La partida ha sido empate");
                        oBEJuego = new BEJuego(1, "Piedra Papel o Tijera", Jugador, new BEUsuario(0, "PC"), new BEUsuario(9999, "Empate"));
                        oMPPJuego.cargarPartidas(oBEJuego);
                    }
                    if (pcSeleccion == 3)
                    {
                        MessageBox.Show("La Maquina Ah Elegido Tijeras");
                        MessageBox.Show("Te dije que no ganarias Muahahaha");
                        oBEJuego = new BEJuego(1, "Piedra Papel o Tijera", Jugador, new BEUsuario(0, "PC"), new BEUsuario(0, "PC"));
                        oMPPJuego.cargarPartidas(oBEJuego);
                    }
                    if (pcSeleccion == 1)
                    {
                        MessageBox.Show("La Maquina Ah Elegido Piedra");
                        MessageBox.Show("Oh no me has derrotado!");
                        oBEJuego = new BEJuego(1, "Piedra Papel o Tijera", Jugador, new BEUsuario(0, "PC"), Jugador);
                        oMPPJuego.cargarPartidas(oBEJuego);
                    }
                    break;
                case 3:
                    if (pcSeleccion == 2)
                    {
                        MessageBox.Show("La Maquina Ah Elegido Papel");
                        MessageBox.Show("Oh no me has derrotado!");
                        oBEJuego = new BEJuego(1, "Piedra Papel o Tijera", Jugador, new BEUsuario(0, "PC"), Jugador);
                        oMPPJuego.cargarPartidas(oBEJuego);
                    }
                    if (pcSeleccion == 3)
                    {
                        MessageBox.Show("La Maquina Ah Elegido Tijeras");
                        MessageBox.Show("La partida ha sido empate");
                        oBEJuego = new BEJuego(1, "Piedra Papel o Tijera", Jugador, new BEUsuario(0, "PC"), new BEUsuario(9999, "Empate"));
                        oMPPJuego.cargarPartidas(oBEJuego);
                    }
                    if (pcSeleccion == 1)
                    {
                        MessageBox.Show("La Maquina Ah Elegido Piedra");
                        MessageBox.Show("Te dije que no ganarias Muahahaha");
                        oBEJuego = new BEJuego(1, "Piedra Papel o Tijera", Jugador, new BEUsuario(0, "PC"), new BEUsuario(0, "PC"));
                        oMPPJuego.cargarPartidas(oBEJuego);
                    }
                    break;
            }
                

        }


    }
}
