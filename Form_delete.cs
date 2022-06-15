using System;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace KS_18_var_5
{
    public partial class Form_delete : Form
    {
        string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\Kyrsovoy\KS-18_var_5\Database1.mdf;Integrated Security=True";

        public Form_delete()
        {
            InitializeComponent();
        }

        private void button_OK_Click(object sender, EventArgs e)
        {
            string sqlExpression = "DELETE FROM Table_process";
            using (SqlConnection connect = new SqlConnection(connectionString))
            {
                connect.Open();
                SqlCommand command = new SqlCommand(sqlExpression, connect);
                command.ExecuteNonQuery();
                connect.Close();
            }
            this.Close();
        }

        private void button_cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
