using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BE;

namespace Presentacio_UI
{
    public partial class Menu_Principal : Form
    {
        BEUsuario usuarioJuego;
        public Menu_Principal(BEUsuario usuario)
        {
            InitializeComponent();
            usuarioJuego = usuario;
        }

        private void Menu_Principal_Load(object sender, EventArgs e)
        {

            if (usuarioJuego == null)
            {
                MessageBox.Show("Error Ingrese Usuario");
                Application.Exit();
            }
            else
            {
                textBox6.Text = usuarioJuego.nombreUsuario;
            }
            
                
        
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            PiPaTi juegos = new PiPaTi(usuarioJuego);
            juegos.MdiParent = this;
            juegos.Show();
            ocultarBotones();

            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Tateti juego = new Tateti(usuarioJuego);
            juego.MdiParent = this;
            juego.Show();
            ocultarBotones();
            
        }
        private void ocultarBotones()
        {
            button1.Hide();
            button2.Hide();
        }
        public void mostrarBotones()
        {
            button1.Show();
            button2.Show();
        }

        private void modificarDatosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ocultarBotones();
            mUsuario formulario = new mUsuario(usuarioJuego);
            formulario.MdiParent = this;
            formulario.Show();

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void consultasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ocultarBotones();
            Consultas formulario = new Consultas();
            formulario.MdiParent = this;
            formulario.Show();
        }

        private void Menu_Principal_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
