using BE;
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
using System.Text.RegularExpressions;

namespace Presentacio_UI
{
    public partial class mUsuario : Form
    {
        BEUsuario usuarioAmodificar;
        BLLUsuario oBLLUsuario;
        
        public mUsuario(BEUsuario usuario)
        {
            InitializeComponent();
            usuarioAmodificar = usuario;
        }

        private void mUsuario_Load(object sender, EventArgs e)
        {
            textBox1.Text = usuarioAmodificar.codigo.ToString();
            textBox2.Text = usuarioAmodificar.nombreUsuario;
            textBox7.Text = usuarioAmodificar.nombre;
            textBox6.Text = usuarioAmodificar.apellido;
            textBox3.Text = usuarioAmodificar.dni;
            textBox4.Text = usuarioAmodificar.email;
            textBox5.Text = usuarioAmodificar.localidad;
            oBLLUsuario = new BLLUsuario();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string dni = textBox3.Text;
            string email = textBox4.Text;
            bool a = Regex.IsMatch(dni, "^[0-9]{8,8}$") && Regex.IsMatch(email, @"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$");
            if (a)
            {
                try
                {
                    usuarioAmodificar.codigo = Convert.ToInt32(textBox1.Text);
                    usuarioAmodificar.nombreUsuario = textBox2.Text;
                    usuarioAmodificar.nombre = textBox7.Text;
                    usuarioAmodificar.apellido = textBox6.Text;
                    usuarioAmodificar.dni = textBox3.Text;
                    usuarioAmodificar.email = textBox4.Text;
                    usuarioAmodificar.localidad = textBox5.Text;
                    oBLLUsuario.alta_modUsuario(usuarioAmodificar);
                }
                catch (System.FormatException)
                {
                    MessageBox.Show("Los Datos Ingresados Son Incorrecos Vuelva a intentarlo");
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            oBLLUsuario.bajaUsuario(usuarioAmodificar);
            this.MdiParent.Close();
            this.MdiParent.Hide();
            this.Close();
            this.Hide();
            Logueo Formulario = new Logueo();
            Formulario.Show();
        }

        private void mUsuario_FormClosing(object sender, FormClosingEventArgs e)
        {
            foreach (var button in this.MdiParent.Controls.OfType<Button>())
            {
                button.Show();
            }
        }
    }
}
