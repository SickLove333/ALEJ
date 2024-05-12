using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PREUBA_2
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
            // Configuración inicial del TextBox
            textBox1.Text = "Nombre del Reporte";
            textBox1.ForeColor = SystemColors.GrayText; // Color de texto gris
        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {
            if (textBox1.Text == "Nombre del Reporte")
            {
                textBox1.Text = ""; // Borra el texto predeterminado al escribir
                textBox1.ForeColor = SystemColors.WindowText; // Restaura el color de texto predeterminado
            }
        }

        private void textBox1_Enter(object sender, EventArgs e)
        {
            if (textBox1.Text == "Nombre del Reporte")
            {
                textBox1.Text = ""; // Borra el texto predeterminado al hacer clic
                textBox1.ForeColor = SystemColors.WindowText; // Restaura el color de texto predeterminado
            }
        }

        private void textBox1_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBox1.Text))
            {
                textBox1.Text = "Nombre del Reporte";
                textBox1.ForeColor = SystemColors.GrayText; // Cambia el color del texto a gris
            }
        }



        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();

            Form1 form1 = new Form1();
            form1.Show();
        }
    }
}
