using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using System.Reflection.Emit;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {   
            // ejercicio 1 evaluar si no es una tecla de control o un caracter
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                //nos permite no permitir el acceso de esas teclas
                e.Handled = true;
                label1.Text = "Solo se permiten numeros";

            }
            else
            {
                label1.Text = "";
            }
        }


        //Ejercicio 2 Crear un programa en Windows Form que
        //permite cambiar el color de fondo de un label
        //automáticamente cada vez que el usuario pasa

        private void Form1_MouseEnter(object sender, EventArgs e)
        {

        }

        private void label2_MouseEnter(object sender, EventArgs e)
        {
            label2.BackColor = Color.Red;
        }

        private void label2_MouseLeave(object sender, EventArgs e)
        {
            label2.BackColor = Color.Blue;
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("Solo se permiten caracteres");
            }
        }


        //ejercicio tres validacion de corrreo electronico

        private void textBox3_MouseLeave(object sender, EventArgs e)
        {
            string email = Validaciones.Text;

            if (!emailValido(email)) 
            {
                MessageBox.Show("El correo Electronico no es valido");
            }
        }

        private bool emailValido(string email)
        {
            try 
            
            {
                var addr = new System.Net.Mail.MailAddress(email);
                return addr.Address == email;
            }

            catch { return false; }
        }
    }
}
