using MySql.Data.MySqlClient;
using PREUBA_2.Data;

namespace PREUBA_2
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

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.Show();
            this.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Form3 form3 = new Form3();
            form3.Show();
            this.Hide();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button10_Click(object sender, EventArgs e)
        {

        }

        private void button9_Click(object sender, EventArgs e)
        {
            Form4 form4 = new Form4();
            form4.Show();
            this.Hide();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            //Form4 form4 = new Form4();
            //form4.Show();
            //this.Hide();

            // Esto es para probar si la conexión a la db es exitosa
            /*
            Data.Connection objConnection = new Data.Connection();
            objConnection.openConn();
            */
            
            // Ejemplo para guardar datos de un paciente

            int idEmpleado = 1;
            string nombre = "Juán";
            string apellidoPaterno = "Pérez";
            string apellidoMaterno = "López";
            int edad = 24;
            int sexo = 1; // (1 = Masculino, 2 = Femenino)
            string email = "jperez@email.com";
            string password = "jperez123";

            try
            {
                Connection objConnection = new Connection();
                String query = $"CALL sp_put_paciente({idEmpleado}, '{nombre}', '{apellidoPaterno}', '{apellidoMaterno}', '{edad}', '{sexo}', '{email}', '{password}');";
                MySqlCommand command = new MySqlCommand(query, objConnection.openConn());
                MySqlDataReader reader = command.ExecuteReader();
                MessageBox.Show("Se guardó el paciente");
                while (reader.Read())
                {
                    
                }
                objConnection.closeConn();
            }
            catch (Exception exception)
            {
                MessageBox.Show("Ocurrió un error: "+exception.ToString());
            }



        }
    }
}
