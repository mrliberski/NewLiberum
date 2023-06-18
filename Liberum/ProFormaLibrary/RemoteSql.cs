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

namespace ProFormaUI
{
    public partial class RemoteSql : Form
    {
        public RemoteSql()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            try
            {
                string connectionStringx = "Data Source=srv1017.hstgr.io:3306;Initial Catalog=u696846326_Liberum;User id=u696846326_LiberumUser;Pwd=Antolin406";
                using (SqlConnection connection = new SqlConnection(connectionStringx))
                {
                    connection.Open();
                    using (SqlCommand command = new SqlCommand("INSERT INTO Invoices (InvoiceNumber) VALUES (@InvoiceNumber)", connection))
                    {
                        command.Parameters.AddWithValue("@InvoiceNumber", int.Parse(textBox1.Text));
                        command.ExecuteNonQuery();
                    }
                }
                label1.Text = string.Empty;
                MessageBox.Show("OK");
            }
            catch (Exception ex)
            {
                textBox1.Text = string.Empty;
                MessageBox.Show(ex.Message);
            }

        }

        private void eh()
        {
            // Connection string for the remote SQL Server
            string connectionString = "Data Source=remoteServerName;Initial Catalog=databaseName;Uid=userName;Password=password";

            // SQL query to insert a new record
            string query = "INSERT INTO YourTableName (Column1, Column2) VALUES (@Value1, @Value2)";

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    // Open the connection
                    connection.Open();

                    // Create a SqlCommand object with the query and connection
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        // Set the parameter values for the new record
                        command.Parameters.AddWithValue("@Value1", "Value1");
                        command.Parameters.AddWithValue("@Value2", "Value2");

                        // Execute the query
                        int rowsAffected = command.ExecuteNonQuery();

                        Console.WriteLine("Rows affected: " + rowsAffected);
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }
        }
    }


}
