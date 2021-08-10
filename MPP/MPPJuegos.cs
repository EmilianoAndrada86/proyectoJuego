using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using BE;

namespace MPP
{
    public class MPPJuegos
    {
        public void cargarPartidas(BEJuego juego)
        {
            XDocument xmlDoc = XDocument.Load("Partidas.xml");
            xmlDoc.Element("Partidas").Add(new XElement("Partida", new XAttribute("id", generarID(listarPartidas())),
                                                                            new XElement("CodigoJuego", juego.codigo),
                                                                            new XElement("NombreJuego", juego.nombre),
                                                                            new XElement("Jugador1", new XElement("CodigoJugador", juego.listaJugadores[0].codigo), new XElement("NombreJugador", juego.listaJugadores[0].nombreUsuario)),
                                                                            new XElement("Jugador2", new XElement("CodigoJugador", juego.listaJugadores[1].codigo), new XElement("NombreJugador", juego.listaJugadores[1].nombreUsuario)),
                                                                            new XElement("JugadorGanador", new XElement("CodigoJugador", juego.listaJugadores[2].codigo), new XElement("NombreJugador", juego.listaJugadores[2].nombreUsuario))));
            xmlDoc.Save("Partidas.xml");

        }
        private int generarID(List<BEJuego> listaPartidas)
        {

            int id = 1;
            foreach (BEJuego a in listaPartidas)
            {
                id++;
            }
            return id;
        }
        public List<BEJuego> listarPartidas()
        {
            List<BEJuego> lstPartidas = new List<BEJuego>();
            XDocument partidas = XDocument.Load("Partidas.xml");
            var consulta = from Juego in partidas.Descendants("Partida")
                           select Juego;
            foreach (XElement partida in consulta)
            {

                lstPartidas.Add(new BEJuego(Convert.ToInt32(Convert.ToString(partida.Element("CodigoJuego").Value.Trim())),
                                            Convert.ToString(partida.Element("NombreJuego").Value.Trim()),
                                            new BEUsuario(Convert.ToInt32(Convert.ToString(partida.Element("Jugador1").Element("CodigoJugador").Value.Trim())), Convert.ToString(partida.Element("Jugador1").Element("NombreJugador").Value.Trim())),
                                            new BEUsuario(Convert.ToInt32(Convert.ToString(partida.Element("Jugador2").Element("CodigoJugador").Value.Trim())), Convert.ToString(partida.Element("Jugador2").Element("NombreJugador").Value.Trim())),
                                            new BEUsuario(Convert.ToInt32(Convert.ToString(partida.Element("JugadorGanador").Element("CodigoJugador").Value.Trim())), Convert.ToString(partida.Element("JugadorGanador").Element("NombreJugador").Value.Trim()))));
            }


            return lstPartidas;

        }
        public List<consulta1> juegoMasJugado()
        {
            int cantPartidasmax = 0;
            int codigoJuegoMax = 0;
            string nombreJuegoMax = "";
            XDocument xDoc = XDocument.Load("Partidas.xml");
            var consulta = from Partidas in xDoc.Descendants("Partida")
                           select Partidas;
            XDocument xDoc2 = XDocument.Load("Juegos.xml");
            var consulta2 = from Juegos in xDoc2.Descendants("Juego")
                            select new BEJuego
                            {
                                codigo = Convert.ToInt32(Convert.ToString(Juegos.Attribute("id").Value.Trim())),
                                nombre = Convert.ToString(Juegos.Element("Nombre").Value.Trim())
                            };
            List<BEJuego> listaJuegos = consulta2.ToList<BEJuego>();
            List<consulta1> juegoMasJugado = new List<consulta1>();

            foreach(BEJuego x in listaJuegos)
            {
                int cantPartidas = 0;
                foreach(XElement Partida in consulta)
                {
                    if (Partida.Element("CodigoJuego").Value == x.codigo.ToString())
                    {
                        cantPartidas++;
                    }
                }
                if (cantPartidas >= cantPartidasmax)
                {
                    cantPartidasmax = cantPartidas;
                    codigoJuegoMax = x.codigo;
                    nombreJuegoMax = x.nombre;
                }

            }

            juegoMasJugado.Add(new consulta1(codigoJuegoMax, nombreJuegoMax, cantPartidasmax));
            return juegoMasJugado;





        }
        public List<BEJuego> listarJuegos()
        {
            XDocument xDoc2 = XDocument.Load("Juegos.xml");
            var consulta2 = from Juegos in xDoc2.Descendants("Juego")
                            select new BEJuego
                            {
                                codigo = Convert.ToInt32(Convert.ToString(Juegos.Attribute("id").Value.Trim())),
                                nombre = Convert.ToString(Juegos.Element("Nombre").Value.Trim())
                            };
            List<BEJuego> lstJuegos = consulta2.ToList<BEJuego>();
            return lstJuegos;
        }
    
        
    }
}
