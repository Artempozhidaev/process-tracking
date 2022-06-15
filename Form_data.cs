using System;
using System.Data.SqlClient;
using System.Windows.Forms;
using ME = Microsoft.Office.Interop.Excel;

namespace KS_18_var_5
{
    public partial class Form_data : Form
    {
        public bool frm_open = false;
        string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\Kyrsovoy\KS-18_var_5\Database1.mdf;Integrated Security=True";
        ME.Application exApp = new ME.Application();
        ME._Worksheet exSheet;
        ME._Workbook exWorkBook;
        bool sozdano = false;
        public Form_data()
        {
            InitializeComponent();
            frm_open = true;
        }
        private void Form_data_Load(object sender, EventArgs e)
        {
            SqlConnection connect = new SqlConnection(connectionString);
            SqlCommand command = new SqlCommand();
            connect.Open();

            command.CommandText = "SELECT * FROM Table_process";
            command.Connection = connect;
            SqlDataReader r = command.ExecuteReader();

            if (r.HasRows)
            {
                while (r.Read())
                {
                    ListViewItem item = new ListViewItem(r.GetInt32(0).ToString());
                    item.SubItems.Add(r.GetString(1));
                    item.SubItems.Add(r.GetString(2));
                    item.SubItems.Add(r.GetString(3));
                    listView_data.Items.AddRange(new ListViewItem[] { item });
                }
            }

            connect.Close();
        }
        private void button_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void button_clear_Click(object sender, EventArgs e)
        {
            //string sqlExpression = "DELETE FROM Table_process";
            //using (SqlConnection connect = new SqlConnection(connectionString))
            //{
            //    connect.Open();
            //    SqlCommand command = new SqlCommand(sqlExpression, connect);
            //    command.ExecuteNonQuery();
            //    connect.Close();
            //    listView_data.Items.Clear();
            //}
            Form_delete f = new Form_delete();
            f.ShowDialog();
        }
        private void button_refresh_Click(object sender, EventArgs e)
        {
            listView_data.Items.Clear();
            SqlConnection connect = new SqlConnection(connectionString);
            SqlCommand command = new SqlCommand();
            connect.Open();
            command.CommandText = "SELECT * FROM Table_process";
            command.Connection = connect;
            SqlDataReader r = command.ExecuteReader();
            if (r.HasRows)
            {
                while (r.Read())
                {
                    
                    ListViewItem item = new ListViewItem(r.GetInt32(0).ToString());
                    item.SubItems.Add(r.GetString(1));
                    item.SubItems.Add(r.GetString(2));
                    item.SubItems.Add(r.GetString(3));
                    listView_data.Items.AddRange(new ListViewItem[] { item });
                }
            }
            connect.Close();
        }
        private void button_data_to_excel_Click(object sender, EventArgs e)
        {
            if (sozdano == false)
            {
                exWorkBook = exApp.Workbooks.Add();
                exApp.Visible = true;
                sozdano = true;
            }

            int nomer_stolbca = 1;
            exSheet = (ME._Worksheet)exWorkBook.ActiveSheet;
            exSheet.Columns[1].ColumnWidth = 13;
            exSheet.Columns[2].ColumnWidth = 20;
            exSheet.Columns[3].ColumnWidth = 30;
            exSheet.Columns[4].ColumnWidth = 25;

            int nomer_processa_excel = 1;
            exSheet.Cells[nomer_processa_excel, nomer_stolbca] = "№ процесса";
            exSheet.Cells[nomer_processa_excel, nomer_stolbca + 1] = "Имя процесса";
            exSheet.Cells[nomer_processa_excel, nomer_stolbca + 2] = "Время завершения процесса";
            exSheet.Cells[nomer_processa_excel, nomer_stolbca + 3] = "Время работы процесса";
            
            nomer_processa_excel++;
            string asd;
            int count = listView_data.Items.Count;

            for (int i = 0; i < count; i++)
            {
                asd = listView_data.Items[i].SubItems[0].Text.ToString();
                exSheet.Cells[nomer_processa_excel, nomer_stolbca] = asd;
                asd = listView_data.Items[i].SubItems[1].Text.ToString();
                exSheet.Cells[nomer_processa_excel, nomer_stolbca + 1] = asd;
                asd = listView_data.Items[i].SubItems[2].Text.ToString();
                exSheet.Cells[nomer_processa_excel, nomer_stolbca + 2] = asd;
                asd = listView_data.Items[i].SubItems[3].Text.ToString();
                exSheet.Cells[nomer_processa_excel, nomer_stolbca + 3] = asd;
                nomer_processa_excel++;
            }
        }
        private void End_work(object sender, FormClosingEventArgs e)
        {
            frm_open = false;
            exApp.Quit();
        }
    }
}