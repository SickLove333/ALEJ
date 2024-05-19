using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace PREUBA_2
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();

            Form1 form1 = new Form1();
            form1.Show();
        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {
            //SqlConnection con = new SqlConnection(Properties.Settings.Default.conexion);
            //String query = "select * from **???** where " + comboBox1.Text + " like'%"+textBox1.Text +"%'";
            //SqlDataAdapter ada = new SqlDataAdapter(query, con);

            //con.Open();

            //DataSet data = new DataSet();
            //ada.Fill(data, "***???***");

            //dataGridView1.DataSource = data;
            //dataGridView1.DataMember = "***???***";
        }
    }
}
