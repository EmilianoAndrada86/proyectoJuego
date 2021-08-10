using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BE
{
    public class BEUsuario
    {
        public int codigo { get; set; }
        public string nombreUsuario { get; set; }
        public string nombre { get; set; }
        public string apellido { get; set; }
        public string dni { get; set; }
        public string email { get; set; }
        public string localidad { get; set; }

        public BEUsuario() { }

        public BEUsuario(int cod, string nombUsu) { this.codigo = cod; this.nombreUsuario = nombUsu; }

        public BEUsuario(int cod, string nombreU, string nom, string apell, string dni, string mail, string loc)
        {
            this.codigo = cod;
            this.nombreUsuario = nombreU;
            this.nombre = nom;
            this.apellido = apell;
            this.dni = dni;
            this.email = mail;
            this.localidad = loc;
        }



    }
}

   
