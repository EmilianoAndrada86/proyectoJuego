using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Negocio;
using BE;

namespace Presentacio_UI
{
    public partial class PiPaTi : Form
    {
        BLLPipati juego;
        BEUsuario jugador;

        public PiPaTi(BEUsuario aux)
        {
            InitializeComponent();
            jugador = aux;
        }

        private void PiPaTi_Load(object sender, EventArgs e)
        {
            juego = new BLLPipati();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            juego.jugar(1,jugador);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            juego.jugar(2,jugador);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            juego.jugar(3,jugador);
        }

        private void PiPaTi_FormClosing(object sender, FormClosingEventArgs e)
        {
            foreach(var button in this.MdiParent.Controls.OfType<Button>())
            {
                button.Show();
            }
        }
    }
}
