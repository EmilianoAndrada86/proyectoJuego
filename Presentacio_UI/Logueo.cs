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
    public partial class Logueo : Form
    {
        BLLUsuario oBLLUsuario;
        public Logueo()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Logueo_Load(object sender, EventArgs e)
        {
            oBLLUsuario = new BLLUsuario();
            this.comboBox1.DataSource = oBLLUsuario.listarUsuario();
            this.comboBox1.DisplayMember = "nombreUsuario";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            Menu_Principal Formulario = new Menu_Principal(comboBox1.SelectedItem as BEUsuario);
            this.Hide();
            Formulario.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            CrearUsuario Formulario = new CrearUsuario();
            this.Hide();
            Formulario.Show();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Logueo_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
