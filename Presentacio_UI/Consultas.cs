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
using Negocio;

namespace Presentacio_UI
{
    public partial class Consultas : Form
    {
        BLLJuegos oBLLJuegos = new BLLJuegos();
        BLLUsuario oBLLUsuario = new BLLUsuario();
        public Consultas()
        {
            InitializeComponent();
        }

        private void Consultas_Load(object sender, EventArgs e)
        {
            
            this.comboBox1.DataSource = oBLLJuegos.listarJuegos();
            this.comboBox1.DisplayMember = "nombre";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
     
            
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = oBLLJuegos.juegoMasJugado(); 

        }

        private void button2_Click(object sender, EventArgs e)
        {
            dataGridView2.DataSource = null;
            BEJuego aux = comboBox1.SelectedItem as BEJuego;
            dataGridView2.DataSource = oBLLUsuario.jugadoresxJuego(aux.codigo);
        }

        private void Consultas_FormClosing(object sender, FormClosingEventArgs e)
        {
            foreach (var button in this.MdiParent.Controls.OfType<Button>())
            {
                button.Show();
            }
        }
    }
}
