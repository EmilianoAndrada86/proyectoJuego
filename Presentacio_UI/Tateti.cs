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
    public partial class Tateti : Form
    {
        BLLTateti juego;
        BEUsuario jugador;
        BEJuego jugar;
        Random aux = new Random();
        int[] estado;
        int ladoJugador;
        int ladoPC;
        public Tateti(BEUsuario usuario)
        {
            InitializeComponent();
            jugador = usuario;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            mostrarImagen(0, ladoJugador);
            if (juego.jugarJugador(estado, ladoJugador, 0,jugar))
            {
                resetearJuego();
                
            }
            else
            {
                int aux = juego.jugarPC(estado, ladoPC,jugar);
                if (aux > 10)
                {
                    mostrarImagen(aux - 10, ladoPC);
                    resetearJuego();
                }
                else { mostrarImagen(aux, ladoPC); }
                

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            mostrarImagen(1, ladoJugador);
            if (juego.jugarJugador(estado, ladoJugador, 1,jugar))
            {
                resetearJuego();
                //arreglos xml
            }
            else
            {
                int aux = juego.jugarPC(estado, ladoPC,jugar);
                if (aux > 10)
                {
                    mostrarImagen(aux - 10, ladoPC);
                    resetearJuego();
                }
                else { mostrarImagen(aux, ladoPC); }
            }
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox13_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox14_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox22_Click(object sender, EventArgs e)
        {

        }

        private void Tateti_Load(object sender, EventArgs e)
        {
            juego = new BLLTateti();
            ocultarImagenes();
            ladoJugador = aux.Next(1, 3);
            if (ladoJugador == 1) { ladoPC = 2; }
            else { ladoPC = 1; }
            estado = new int[9];
            for (int i = 0; i < estado.Length; i++)
            {
                estado[i] = 0;
            }
            jugar = new BEJuego(2, "Ta Te Ti");
            jugar.listaJugadores.Add(jugador);
            jugar.listaJugadores.Add(new BEUsuario(0, "PC"));
        }
        private void ocultarImagenes()
        {
            pictureBox5.Hide();
            pictureBox6.Hide();
            pictureBox7.Hide();
            pictureBox8.Hide();
            pictureBox9.Hide();
            pictureBox10.Hide();
            pictureBox11.Hide();
            pictureBox12.Hide();
            pictureBox13.Hide();
            pictureBox14.Hide();
            pictureBox15.Hide();
            pictureBox16.Hide();
            pictureBox17.Hide();
            pictureBox18.Hide();
            pictureBox19.Hide();
            pictureBox20.Hide();
            pictureBox21.Hide();
            pictureBox22.Hide();
        }
        private void mostrarImagen(int lugar, int lados)
        {
            switch (lugar)
            {
                case 0:
                    button1.Hide();
                    if (lados == 1)
                    {
                        pictureBox5.Show();
                    }
                    else { pictureBox14.Show(); }
                    break;
                case 1:
                    button2.Hide();
                    if (lados == 1)
                    {
                        pictureBox6.Show();
                    }
                    else { pictureBox15.Show(); }
                    break;
                case 2:
                    button3.Hide();
                    if (lados == 1)
                    {
                        pictureBox7.Show();
                    }
                    else { pictureBox16.Show(); }
                    break;
                case 3:
                    button4.Hide();
                    if (lados == 1)
                    {
                        pictureBox8.Show();
                    }
                    else { pictureBox17.Show(); }
                    break;
                case 4:
                    button5.Hide();
                    if (lados == 1)
                    {
                        pictureBox9.Show();
                    }
                    else { pictureBox18.Show(); }
                    break;
                case 5:
                    button6.Hide();
                    if (lados == 1)
                    {
                        pictureBox10.Show();
                    }
                    else { pictureBox19.Show(); }
                    break;
                case 6:
                    button7.Hide();
                    if (lados == 1)
                    {
                        pictureBox11.Show();
                    }
                    else { pictureBox20.Show(); }
                    break;
                case 7:
                    button8.Hide();
                    if (lados == 1)
                    {
                        pictureBox12.Show();
                    }
                    else { pictureBox21.Show(); }
                    break;
                case 8:
                    button9.Hide();
                    if (lados == 1)
                    {
                        pictureBox13.Show();
                    }
                    else { pictureBox22.Show(); }
                    break;
                default:
                    break;
            }

        }

        private void button3_Click(object sender, EventArgs e)
        {
            mostrarImagen(2, ladoJugador);
            if (juego.jugarJugador(estado, ladoJugador, 2,jugar))
            {
                resetearJuego();
                //arreglos xml
            }
            else
            {
                int aux = juego.jugarPC(estado, ladoPC, jugar);
                if (aux > 10)
                {
                    mostrarImagen(aux - 10, ladoPC);
                    resetearJuego();
                }
                else { mostrarImagen(aux, ladoPC); }
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            mostrarImagen(3, ladoJugador);
            if (juego.jugarJugador(estado, ladoJugador, 3, jugar))
            {
                resetearJuego();
                //arreglos xml
            }
            else
            {
                int aux = juego.jugarPC(estado, ladoPC, jugar);
                if (aux > 10)
                {
                    mostrarImagen(aux - 10, ladoPC);
                    resetearJuego();
                }
                else { mostrarImagen(aux, ladoPC); }
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            mostrarImagen(4, ladoJugador);
            if (juego.jugarJugador(estado, ladoJugador, 4, jugar))
            {
                resetearJuego();
                //arreglos xml
            }
            else
            {
                int aux = juego.jugarPC(estado, ladoPC, jugar);
                if (aux > 10)
                {
                    mostrarImagen(aux - 10, ladoPC);
                    resetearJuego();
                }
                else { mostrarImagen(aux, ladoPC); }
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            mostrarImagen(5, ladoJugador);
            if (juego.jugarJugador(estado, ladoJugador, 5, jugar))
            {
                resetearJuego();
                
            }
            else
            {
                int aux = juego.jugarPC(estado, ladoPC, jugar);
                if (aux > 10)
                {
                    mostrarImagen(aux - 10, ladoPC);
                    resetearJuego();
                }
                else { mostrarImagen(aux, ladoPC); }
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            mostrarImagen(6, ladoJugador);
            if (juego.jugarJugador(estado, ladoJugador, 6, jugar))
            {
                resetearJuego();
                
            }
            else
            {
                int aux = juego.jugarPC(estado, ladoPC, jugar);
                if (aux > 10)
                {
                    mostrarImagen(aux - 10, ladoPC);
                    resetearJuego();
                }
                else { mostrarImagen(aux, ladoPC); }
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            mostrarImagen(7, ladoJugador);
            if (juego.jugarJugador(estado, ladoJugador, 7, jugar))
            {
                resetearJuego();
                //arreglos xml
            }
            else
            {
                int aux = juego.jugarPC(estado, ladoPC, jugar);
                if (aux > 10)
                {
                    mostrarImagen(aux - 10, ladoPC);
                    resetearJuego();
                }
                else { mostrarImagen(aux, ladoPC); }
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            mostrarImagen(8, ladoJugador);
            if (juego.jugarJugador(estado, ladoJugador, 8, jugar))
            {
                resetearJuego();
                
            }
            else
            {
                int aux = juego.jugarPC(estado, ladoPC, jugar);
                if (aux > 10)
                {
                    mostrarImagen(aux - 10, ladoPC);
                    resetearJuego();
                }
                else { mostrarImagen(aux, ladoPC); }
            }
        }
        private void resetearJuego()
        {
            ladoJugador = aux.Next(1, 3);
            if (ladoJugador == 1) { ladoPC = 2; }
            else { ladoPC = 1; }
            ocultarImagenes();
            for (int i = 0; i < estado.Length; i++)
            {
                estado[i] = 0;
            }
            button1.Show();
            button2.Show();
            button3.Show();
            button4.Show();
            button5.Show();
            button6.Show();
            button7.Show();
            button8.Show();
            button9.Show();

        }

        private void Tateti_FormClosing(object sender, FormClosingEventArgs e)
        {
            foreach (var button in this.MdiParent.Controls.OfType<Button>())
            {
                button.Show();
            }
        }
    }
}
