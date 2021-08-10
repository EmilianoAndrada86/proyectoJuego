using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using BE;
using Negocio;

namespace Presentacio_UI
{
    public partial class CrearUsuario : Form
    {
        BEUsuario oBEUsuario;
        BLLUsuario oBLLUsuario; 
        public CrearUsuario()
        {
            InitializeComponent();
        }

        private void CrearUsuario_Load(object sender, EventArgs e)
        {
            oBLLUsuario = new BLLUsuario();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string nomUsu = textBox1.Text;
            string dni = textBox3.Text;
            string email = textBox4.Text;
            bool a = Regex.IsMatch(dni, "^[0-9]{8,8}$") && Regex.IsMatch(email, @"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$")&&Regex.IsMatch(nomUsu, "^[a-zA-Z]{1,8}$");
            if (a)
            {
                try
                {
                    oBEUsuario = new BEUsuario(0, textBox1.Text, textBox2.Text, textBox6.Text, textBox3.Text, textBox4.Text, textBox5.Text);
                    oBLLUsuario.alta_modUsuario(oBEUsuario);
                    MessageBox.Show("El Usuario a sido creado con exito");
                    this.Close();
                    
                }
                catch(System.FormatException) { MessageBox.Show("Revise los datos ingresados"); }
            }
            else
            {
                MessageBox.Show("Erro de Ingreso Revise el Formato \n Recuerde\n Nombre Usuario: Maximo 8 Caracteres\n DNI: 8 Numeros \n email: a@a.com");
            }

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void CrearUsuario_FormClosing(object sender, FormClosingEventArgs e)
        {
           
            Logueo formu = new Logueo();
            formu.Show();
        }
    }
}
