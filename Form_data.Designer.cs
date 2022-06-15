
namespace KS_18_var_5
{
    partial class Form_data
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.button_clear = new System.Windows.Forms.Button();
            this.button_data_to_excel = new System.Windows.Forms.Button();
            this.button_close = new System.Windows.Forms.Button();
            this.button_refresh = new System.Windows.Forms.Button();
            this.listView_data = new System.Windows.Forms.ListView();
            this.column_number = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.column_name_proc = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.column_endtime = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.column_time_for_proc = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // button_clear
            // 
            this.button_clear.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button_clear.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button_clear.Location = new System.Drawing.Point(434, 12);
            this.button_clear.Name = "button_clear";
            this.button_clear.Size = new System.Drawing.Size(100, 23);
            this.button_clear.TabIndex = 1;
            this.button_clear.Text = "Очистить";
            this.button_clear.UseVisualStyleBackColor = true;
            this.button_clear.Click += new System.EventHandler(this.button_clear_Click);
            // 
            // button_data_to_excel
            // 
            this.button_data_to_excel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button_data_to_excel.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button_data_to_excel.Location = new System.Drawing.Point(434, 70);
            this.button_data_to_excel.Name = "button_data_to_excel";
            this.button_data_to_excel.Size = new System.Drawing.Size(100, 35);
            this.button_data_to_excel.TabIndex = 2;
            this.button_data_to_excel.Text = "Записать в таблицу";
            this.button_data_to_excel.UseVisualStyleBackColor = true;
            this.button_data_to_excel.Click += new System.EventHandler(this.button_data_to_excel_Click);
            // 
            // button_close
            // 
            this.button_close.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button_close.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button_close.Location = new System.Drawing.Point(434, 414);
            this.button_close.Name = "button_close";
            this.button_close.Size = new System.Drawing.Size(100, 23);
            this.button_close.TabIndex = 3;
            this.button_close.Text = "Закрыть";
            this.button_close.UseVisualStyleBackColor = true;
            this.button_close.Click += new System.EventHandler(this.button_close_Click);
            // 
            // button_refresh
            // 
            this.button_refresh.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button_refresh.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button_refresh.Location = new System.Drawing.Point(434, 41);
            this.button_refresh.Name = "button_refresh";
            this.button_refresh.Size = new System.Drawing.Size(100, 23);
            this.button_refresh.TabIndex = 4;
            this.button_refresh.Text = "Обновить";
            this.button_refresh.UseVisualStyleBackColor = true;
            this.button_refresh.Click += new System.EventHandler(this.button_refresh_Click);
            // 
            // listView_data
            // 
            this.listView_data.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listView_data.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listView_data.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.column_number,
            this.column_name_proc,
            this.column_endtime,
            this.column_time_for_proc});
            this.listView_data.FullRowSelect = true;
            this.listView_data.GridLines = true;
            this.listView_data.HideSelection = false;
            this.listView_data.Location = new System.Drawing.Point(12, 12);
            this.listView_data.Name = "listView_data";
            this.listView_data.Size = new System.Drawing.Size(410, 426);
            this.listView_data.TabIndex = 8;
            this.listView_data.UseCompatibleStateImageBehavior = false;
            this.listView_data.View = System.Windows.Forms.View.Details;
            // 
            // column_number
            // 
            this.column_number.Text = "№";
            this.column_number.Width = 35;
            // 
            // column_name_proc
            // 
            this.column_name_proc.Text = "Название процесса";
            this.column_name_proc.Width = 125;
            // 
            // column_endtime
            // 
            this.column_endtime.Text = "Время завершения";
            this.column_endtime.Width = 120;
            // 
            // column_time_for_proc
            // 
            this.column_time_for_proc.Text = "Испол. процес. время";
            this.column_time_for_proc.Width = 130;
            // 
            // Form_data
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(544, 450);
            this.Controls.Add(this.listView_data);
            this.Controls.Add(this.button_refresh);
            this.Controls.Add(this.button_close);
            this.Controls.Add(this.button_data_to_excel);
            this.Controls.Add(this.button_clear);
            this.Name = "Form_data";
            this.Text = "Данные из БД";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.End_work);
            this.Load += new System.EventHandler(this.Form_data_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button button_clear;
        private System.Windows.Forms.Button button_data_to_excel;
        private System.Windows.Forms.Button button_close;
        private System.Windows.Forms.Button button_refresh;
        private System.Windows.Forms.ListView listView_data;
        private System.Windows.Forms.ColumnHeader column_number;
        private System.Windows.Forms.ColumnHeader column_name_proc;
        private System.Windows.Forms.ColumnHeader column_endtime;
        private System.Windows.Forms.ColumnHeader column_time_for_proc;
    }
}