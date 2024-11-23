using System;
using System.Data;
using System.Windows.Forms;
using System.Data.SqlClient;


namespace WinFormsApp_SQL
{
    public partial class Form1 : Form
    {
        private static readonly string connectionString = @"Data Source=.\\SQLEXPRESS;Initial Catalog=BdSQLserver;Integrated Security=True";
        private static SqlConnection cnx = new SqlConnection(connectionString);
        private static SqlCommand cmd = new SqlCommand();
        private static SqlDataAdapter adapter = new SqlDataAdapter(cmd);
        public Form1() 
        { 
            InitializeComponent(); 
            InitializeSqlComponents(); 
        }
        private void InitializeSqlComponents()
        {
            cmd.Connection = cnx; 
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void Typbtn_Click(object sender, EventArgs e)
        {

        }

        private void titbtn_Click(object sender, EventArgs e)
        {

        }


        private void btnselect_Click(object sender, EventArgs e)
        {
            cnx.Open();
            cmd.CommandText = "select * from Livre";
            cmd.Connection = cnx;
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            cnx.Close();

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            cnx.Open();
            cmd.Connection = cnx;
            cmd.CommandText = "UPDATE Livre SET NOM = @Nom WHERE IdLivre = @IdLivre";
            cmd.ExecuteNonQuery();
            cnx.Close();
        }

        private void btndelete_Click(object sender, EventArgs e)
        {
            cnx.Open();
            cmd.Connection = cnx;
            cmd.CommandText = "DELETE FROM Livre WHERE IdLivre = @IdLivre";
            cmd.ExecuteNonQuery();
            cnx.Close();

        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            cnx.Open();
            cmd.Connection = cnx;
            cmd.CommandText = "INSERT INTO Livre (IdLivre, Nom) VALUES (@IdLivre, @Nom)";
            cmd.ExecuteNonQuery();
            cnx.Close();
        }
    }
}

