using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BE;
using MPP;

namespace Negocio
{
    public class BLLUsuario
    {
        MPPUsuario oMPPUsuario= new MPPUsuario();

        public void alta_modUsuario(BEUsuario usuario)
        {
            
            oMPPUsuario.alta_modificacionUsuario(usuario);
        }
        public void bajaUsuario(BEUsuario usuario)
        {
            oMPPUsuario.bajaUsuario(usuario);
        }
        public List<BEUsuario> listarUsuario()
        {
            
            return oMPPUsuario.listarUsuarios();
        }
        public List<consulta2> jugadoresxJuego(int codigoJuego)
        {
            return oMPPUsuario.jugadoresxJuego(codigoJuego);
        }
    }
}
