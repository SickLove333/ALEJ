using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Diagnostics;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace PREUBA_2
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            // Configuración inicial del TextBox
            txtName.Text = "Nombre del Reporte";
            txtName.ForeColor = SystemColors.GrayText; // Color de texto gris
        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {
            if (txtName.Text == "Nombre del Reporte")
            {
                txtName.Text = ""; // Borra el texto predeterminado al escribir
                txtName.ForeColor = SystemColors.WindowText; // Restaura el color de texto predeterminado
            }
        }

        private void textBox1_Enter(object sender, EventArgs e)
        {
            if (txtName.Text == "Nombre del Reporte")
            {
                txtName.Text = ""; // Borra el texto predeterminado al hacer clic
                txtName.ForeColor = SystemColors.WindowText; // Restaura el color de texto predeterminado
            }
        }

        private void textBox1_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtName.Text))
            {
                txtName.Text = "Nombre del Reporte";
                txtName.ForeColor = SystemColors.GrayText; // Cambia el color del texto a gris
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

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            Form4 form4 = new Form4();
            form4.Show();
            this.Hide();
        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            if (txtName.Text.Trim().Equals("") || txtFile.Text.Trim().Equals(""))
            {
                MessageBox.Show("El nombre es obligatorio");
                return;
            }

            byte[] file = null;
            Stream myStream = openFileDialog1.OpenFile();
            using (MemoryStream ms = new MemoryStream())
            {
                myStream.CopyTo(ms);
                file = ms.ToArray();
            }

            //https://www.youtube.com/watch?v=2Ipd3FIgais&t=240s&ab_channel=hdeleon.net
            /*using (model.pruebaEntities db = new model.pruebaEntities())
            {
                model.document oDocument = new model.document();
                oDocument.name = txtName.Text.Trim();
                oDocument.doc = file;
                oDocument.realName = openFileDialog1.SafeFileName;

                db.document.Add(oDocument);
                db.SaveChanges();
            }

            Refresh();
        }

        private void Refresh()
        {

            using (model.pruebaEntities db = new model.pruebaEntities())
            {
                var lst = from d in db.document
                          select new { d.id, d.name };
                dgvLista.DataSource = lst.ToList();
            }
        }

       
    */
        }

        private void button12_Click(object sender, EventArgs e)
        {
            openFileDialog2.InitialDirectory = "c:\\";
            openFileDialog2.FileName = "Todos los archivos (*.*)|*.*";
            openFileDialog2.FilterIndex = 1;
            openFileDialog2.RestoreDirectory = true;

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                txtFile2.Text = openFileDialog1.FileName;
            }
        }

        private void button11_Click(object sender, EventArgs e)
        {
            
        }

        private void button11_Click_1(object sender, EventArgs e)
        {
            openFileDialog1.InitialDirectory = "c:\\";
            openFileDialog1.FileName = "Todos los archivos (*.*)|*.*";
            openFileDialog1.FilterIndex = 1;
            openFileDialog1.RestoreDirectory = true;

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                txtFile.Text = openFileDialog1.FileName;
            }
        }
    }
}

    namespace model
{
    class pruebaEntities
    {
    }
}

