using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using BE;

namespace MPP
{
    public class MPPUsuario
    {
        public void alta_modificacionUsuario(BEUsuario usuario)
        {
            if (usuario.codigo != 0)
            {
                XDocument doc = XDocument.Load("Usuarios.xml");
                var consulta = from Usuario in doc.Descendants("Usuario")
                               where Usuario.Attribute("id").Value == usuario.codigo.ToString()
                               select Usuario;
                foreach (XElement modificar in consulta)
                {
                    modificar.Element("Nombre").Value = usuario.nombre;
                    modificar.Element("Apellido").Value = usuario.apellido;
                    modificar.Element("DNI").Value = usuario.dni;
                    modificar.Element("Email").Value = usuario.email;
                    modificar.Element("localidad").Value = usuario.localidad;
                }
                doc.Save("Usuarios.xml");

            }
            else
            {
                if (existeUsuario(usuario.nombreUsuario)){MessageBox.Show("Error usuario existente");}
                else
                {
                    XDocument xmlDoc = XDocument.Load("Usuarios.xml");
                    xmlDoc.Element("Usuarios").Add(new XElement("Usuario", new XAttribute("id", generarID(listarID())),
                                                                           new XAttribute("estado","0"),
                                                                           new XElement("NombreUsuario", usuario.nombreUsuario),
                                                                           new XElement("Nombre", usuario.nombre),
                                                                           new XElement("Apellido", usuario.apellido),
                                                                           new XElement("DNI", usuario.dni),
                                                                           new XElement("Email", usuario.email),
                                                                           new XElement("localidad", usuario.localidad)));
                    xmlDoc.Save("Usuarios.xml");
                }
            }
            
        }

        public void bajaUsuario(BEUsuario usuario)
        {
            XDocument doc = XDocument.Load("Usuarios.xml");
            var consulta = from Usuario in doc.Descendants("Usuario")
                           where Usuario.Attribute("id").Value == usuario.codigo.ToString()
                           select Usuario;
            foreach(XElement modificar in consulta)
            {
                modificar.Attribute("estado").Value = "1";
            }
            doc.Save("Usuarios.xml");
        }

        private int generarID(List<BEUsuario> listaUsuarios)
        {
            
            int id=1;
            foreach(BEUsuario a in listaUsuarios)
            {
                id++;
            }
            return id;
        }
        
        public List<BEUsuario> listarUsuarios()
        {
            var consulta = from Usuario in XElement.Load("Usuarios.xml").Elements("Usuario")
                           where Usuario.Attribute("estado").Value == "0"
                           select new BEUsuario
                           {
                               codigo = Convert.ToInt32(Convert.ToString(Usuario.Attribute("id").Value).Trim()),
                               nombreUsuario = Convert.ToString(Usuario.Element("NombreUsuario").Value.Trim()),
                               nombre = Convert.ToString(Usuario.Element("Nombre").Value).Trim(),
                               apellido= Convert.ToString(Usuario.Element("Apellido").Value).Trim(),
                               dni = Convert.ToString(Usuario.Element("DNI").Value).Trim(),
                               email = Convert.ToString(Usuario.Element("Email").Value).Trim(),
                               localidad = Convert.ToString(Usuario.Element("localidad").Value).Trim()

                           };
            List<BEUsuario> lstUsuarios = consulta.ToList<BEUsuario>();
            return lstUsuarios;
        }
       
        public bool existeUsuario(string NombreUsuario)
        {
            BEUsuario aux = buscarUsuario(NombreUsuario);
            if (aux.codigo != 0)
            {
                return true;
            }
            else return false;
            
        }
        
        public BEUsuario buscarUsuario(string nombreUsuario)
        {
            var consulta = from Usuario in XElement.Load("Usuarios.xml").Elements("Usuario")
                           where (string)Usuario.Element("NombreUsuario") == nombreUsuario.ToString().Trim()
                           select new BEUsuario
                           {
                               codigo=Convert.ToInt32(Convert.ToString(Usuario.Attribute("id").Value.Trim())),
                               nombreUsuario = Convert.ToString(Usuario.Element("NombreUsuario").Value.Trim()),
                               nombre= Convert.ToString(Usuario.Element("Nombre").Value.Trim()),
                               apellido = Convert.ToString(Usuario.Element("Apellido").Value.Trim()),
                               dni = Convert.ToString(Usuario.Element("DNI").Value.Trim()),
                               email = Convert.ToString(Usuario.Element("Email").Value.Trim()),
                               localidad=Convert.ToString(Usuario.Element("localidad").Value.Trim())

                           };
            List<BEUsuario> aux = consulta.ToList<BEUsuario>();
            if (aux.Count > 0) { return aux[0]; }
            else { return new BEUsuario(); }
            
        }
        
        public List<consulta2> jugadoresxJuego(int codigoJuego)
        {
            XDocument xDoc = XDocument.Load("Partidas.xml");
            var consulta = from partida in xDoc.Descendants("Partida")
                           where partida.Element("CodigoJuego").Value == codigoJuego.ToString()
                           select partida;

            List<consulta2> estadisticaxJugador = new List<consulta2>();

            foreach(XElement a in consulta)
            {
                if (estadisticaxJugador.Exists(x => x.codigoJugador.ToString() == a.Element("Jugador1").Element("CodigoJugador").Value))
                {
                    if (a.Element("Jugador1").Element("CodigoJugador").Value == a.Element("JugadorGanador").Element("CodigoJugador").Value)
                    {
                        estadisticaxJugador.Find(x => x.codigoJugador.ToString() == a.Element("Jugador1").Element("CodigoJugador").Value).cantGanadas++;
                    }
                    else
                    {
                        if (a.Element("JugadorGanador").Element("CodigoJugador").Value == 9999.ToString())
                        {
                            estadisticaxJugador.Find(x => x.codigoJugador.ToString() == a.Element("Jugador1").Element("CodigoJugador").Value).cantEmpatadas++;
                        }
                        else
                        {
                            estadisticaxJugador.Find(x => x.codigoJugador.ToString() == a.Element("Jugador1").Element("CodigoJugador").Value).cantPerdidas++;
                        }
                    }
                }
                else
                {
                    consulta2 aux = new consulta2();
                    aux.codigoJugador = Convert.ToInt32(Convert.ToString(a.Element("Jugador1").Element("CodigoJugador").Value));
                    aux.nombreJugador = Convert.ToString(a.Element("Jugador1").Element("NombreJugador").Value);
                    estadisticaxJugador.Add(aux);
                    if (a.Element("Jugador1").Element("CodigoJugador").Value == a.Element("JugadorGanador").Element("CodigoJugador").Value)
                    {
                        estadisticaxJugador.Find(x => x.codigoJugador.ToString() == a.Element("Jugador1").Element("CodigoJugador").Value).cantGanadas++;
                    }
                    else
                    {
                        if (a.Element("JugadorGanador").Element("CodigoJugador").Value == 9999.ToString())
                        {
                            estadisticaxJugador.Find(x => x.codigoJugador.ToString() == a.Element("Jugador1").Element("CodigoJugador").Value).cantEmpatadas++;
                        }
                        else
                        {
                            estadisticaxJugador.Find(x => x.codigoJugador.ToString() == a.Element("Jugador1").Element("CodigoJugador").Value).cantPerdidas++;
                        }
                    }
                }
            }
                return estadisticaxJugador;
        }

        public List<BEUsuario> listarID()
        {
            var consulta = from Usuario in XElement.Load("Usuarios.xml").Elements("Usuario")
                           select new BEUsuario
                           {
                               codigo = Convert.ToInt32(Convert.ToString(Usuario.Attribute("id").Value).Trim()),
                               nombreUsuario = Convert.ToString(Usuario.Element("NombreUsuario").Value.Trim()),
                               nombre = Convert.ToString(Usuario.Element("Nombre").Value).Trim(),
                               apellido = Convert.ToString(Usuario.Element("Apellido").Value).Trim(),
                               dni = Convert.ToString(Usuario.Element("DNI").Value).Trim(),
                               email = Convert.ToString(Usuario.Element("Email").Value).Trim(),
                               localidad = Convert.ToString(Usuario.Element("localidad").Value).Trim()

                           };
            List<BEUsuario> lstUsuarios = consulta.ToList<BEUsuario>();
            return lstUsuarios;
        }
    }
}
