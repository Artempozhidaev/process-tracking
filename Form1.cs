using System;
using System.Management;
using System.Windows.Forms;
using System.Data.SqlClient;
using ME = Microsoft.Office.Interop.Excel;

namespace KS_18_var_5
{
    public partial class Form1 : Form
    {
        ME.Application exApp = new ME.Application();
        ME._Worksheet exSheet;
        ME._Workbook exWorkBook;
        ManagementEventWatcher w = new ManagementEventWatcher("SELECT * FROM __InstanceCreationEvent WITHIN 4 WHERE TargetInstance ISA 'Win32_NTLogEvent'");
        WqlEventQuery query = new WqlEventQuery("__InstanceCreationEvent", new TimeSpan(0, 0, 1), "TargetInstance isa \"Win32_NTLogEvent\"");
        int nomer_processa = 1;
        int nomer_processa_db = 0;
        int nomer_stolbca = 1;
        DateTime dt = new DateTime();
        DateTime dt_ = new DateTime();
        bool sozdano = false;
        public Form1()
        {
            InitializeComponent();
        }
        public void EventArrived1(Object sender, EventArrivedEventArgs e)// Получаем объект Event и отображаем его
        {
            dt = DateTime.Now;
            ManagementBaseObject mo = e.NewEvent;
            string A = (string)(((ManagementBaseObject)mo["TargetInstance"])["TimeGenerated"]);
            string name_logfile = (string)((ManagementBaseObject)mo["TargetInstance"])["Logfile"];
            string text = (string)((ManagementBaseObject)mo["TargetInstance"])["Massage"];
            dt_ = ManagementDateTimeConverter.ToDateTime(A);
            string datat = (dt - dt_).ToString();

            string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\Kyrsovoy\KS-18_var_5\Database1.mdf;Integrated Security=True";

            string sel_count = "SELECT COUNT (*) FROM Table_process";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                SqlCommand command = new SqlCommand(sel_count, connection);
                nomer_processa_db = (int)command.ExecuteScalar();
                connection.Close();
            }

            nomer_processa_db++;
            string sqlExpression = "INSERT INTO Table_process VALUES (" + nomer_processa_db + ", '" + name_logfile + "', '" + dt_.ToString() + "', '" + text + "');";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                SqlCommand command = new SqlCommand(sqlExpression, connection);
                command.ExecuteNonQuery();
                connection.Close();
            }

            ListViewItem item = new ListViewItem(nomer_processa.ToString(), 0);
            item.SubItems.Add(name_logfile);
            item.SubItems.Add(dt.ToString());
            item.SubItems.Add(datat);

            Invoke((MethodInvoker)delegate () { listView_.Items.AddRange(new ListViewItem[] { item }); });
            nomer_processa++;
        }
        private void button_start_tracking_Click(object sender, EventArgs e)
        {
            w = new ManagementEventWatcher(query);
            w.EventArrived += new EventArrivedEventHandler(EventArrived1);
            w.Start();

            label_status.Text = "Tracking Deletion Process started";
            label_status.Visible = true;
        }
        private void button_stop_clear_Click(object sender, EventArgs e)
        {
            w.Stop();
            label_status.Text = "Tracking Deletion Process stoped";
        }
        private void button_select_excel_Click(object sender, EventArgs e)
        {
            if (sozdano == false)
            {
                exWorkBook = exApp.Workbooks.Add();
                exApp.Visible = true;
                sozdano = true;
            }
            exSheet = (ME._Worksheet)exWorkBook.ActiveSheet;
            string asd;

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

            int count = listView_.Items.Count;
            for (int i = 0; i < count; i++)
            {
                asd = listView_.Items[i].SubItems[0].Text.ToString();
                exSheet.Cells[nomer_processa_excel, nomer_stolbca] = asd;
                asd = listView_.Items[i].SubItems[1].Text.ToString();
                exSheet.Cells[nomer_processa_excel, nomer_stolbca + 1] = asd;
                asd = listView_.Items[i].SubItems[2].Text.ToString();
                exSheet.Cells[nomer_processa_excel, nomer_stolbca + 2] = asd;
                asd = listView_.Items[i].SubItems[3].Text.ToString();
                exSheet.Cells[nomer_processa_excel, nomer_stolbca + 3] = asd;
                nomer_processa_excel++;
            }
        }
        private void End_work(object sender, FormClosingEventArgs e)
        {
            exApp.Quit();
        }
        private void button_open_form_data_Click(object sender, EventArgs e)
        {
            Form_data Frm_data = new Form_data();
            Frm_data.Show();
        }
    }
}