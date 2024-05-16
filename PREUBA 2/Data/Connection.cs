using MySql.Data.MySqlClient;

namespace PREUBA_2.Data;

internal class Connection
{
    MySqlConnection conex = new MySqlConnection();

    static string server = "35.167.145.215";
    static string database = "db_h_san_bernabe";
    static string user = "u_poo";
    static string password = "qoY&-i9IZi";
    
    string connectionString = "server="+server+"; user="+user+"; password="+password+"; database="+database+";";

    public MySqlConnection openConn()
    {
        try
        {
            conex.ConnectionString = connectionString;
            conex.Open();
            MessageBox.Show("Se conectó a la base de datos");
        }
        catch (Exception e)
        {
            MessageBox.Show("No se conectó a la base de datos. Error: "+e.ToString());
            //Console.WriteLine(e);
            //throw;
        }

        return conex;
    }

    public void closeConn()
    {
        conex.Close();
    }
}