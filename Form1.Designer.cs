
namespace KS_18_var_5
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.button_start_tracking = new System.Windows.Forms.Button();
            this.button_stop_tracking = new System.Windows.Forms.Button();
            this.button_select_excel = new System.Windows.Forms.Button();
            this.label_status = new System.Windows.Forms.Label();
            this.listView_ = new System.Windows.Forms.ListView();
            this.column_number = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.column_name_proc = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.column_endtime = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.column_time_for_proc = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.button_open_form_data = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button_start_tracking
            // 
            this.button_start_tracking.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.button_start_tracking.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button_start_tracking.Location = new System.Drawing.Point(12, 275);
            this.button_start_tracking.Name = "button_start_tracking";
            this.button_start_tracking.Size = new System.Drawing.Size(100, 35);
            this.button_start_tracking.TabIndex = 0;
            this.button_start_tracking.Text = "Start tracking";
            this.button_start_tracking.UseVisualStyleBackColor = true;
            this.button_start_tracking.Click += new System.EventHandler(this.button_start_tracking_Click);
            // 
            // button_stop_tracking
            // 
            this.button_stop_tracking.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.button_stop_tracking.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button_stop_tracking.Location = new System.Drawing.Point(12, 316);
            this.button_stop_tracking.Name = "button_stop_tracking";
            this.button_stop_tracking.Size = new System.Drawing.Size(100, 35);
            this.button_stop_tracking.TabIndex = 1;
            this.button_stop_tracking.Text = "Stop tracking";
            this.button_stop_tracking.UseVisualStyleBackColor = true;
            this.button_stop_tracking.Click += new System.EventHandler(this.button_stop_clear_Click);
            // 
            // button_select_excel
            // 
            this.button_select_excel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button_select_excel.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button_select_excel.Location = new System.Drawing.Point(322, 316);
            this.button_select_excel.Name = "button_select_excel";
            this.button_select_excel.Size = new System.Drawing.Size(100, 35);
            this.button_select_excel.TabIndex = 4;
            this.button_select_excel.Text = "Записать в таблицу";
            this.button_select_excel.UseVisualStyleBackColor = true;
            this.button_select_excel.Click += new System.EventHandler(this.button_select_excel_Click);
            // 
            // label_status
            // 
            this.label_status.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label_status.AutoSize = true;
            this.label_status.Location = new System.Drawing.Point(118, 286);
            this.label_status.Name = "label_status";
            this.label_status.Size = new System.Drawing.Size(63, 13);
            this.label_status.TabIndex = 6;
            this.label_status.Text = "label_status";
            this.label_status.Visible = false;
            // 
            // listView_
            // 
            this.listView_.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.listView_.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listView_.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.column_number,
            this.column_name_proc,
            this.column_endtime,
            this.column_time_for_proc});
            this.listView_.FullRowSelect = true;
            this.listView_.GridLines = true;
            this.listView_.HideSelection = false;
            this.listView_.Location = new System.Drawing.Point(12, 12);
            this.listView_.Name = "listView_";
            this.listView_.Size = new System.Drawing.Size(410, 257);
            this.listView_.TabIndex = 7;
            this.listView_.UseCompatibleStateImageBehavior = false;
            this.listView_.View = System.Windows.Forms.View.Details;
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
            // button_open_form_data
            // 
            this.button_open_form_data.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button_open_form_data.Location = new System.Drawing.Point(322, 275);
            this.button_open_form_data.Name = "button_open_form_data";
            this.button_open_form_data.Size = new System.Drawing.Size(100, 35);
            this.button_open_form_data.TabIndex = 8;
            this.button_open_form_data.Text = "Открыть БД";
            this.button_open_form_data.UseVisualStyleBackColor = true;
            this.button_open_form_data.Click += new System.EventHandler(this.button_open_form_data_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(434, 363);
            this.Controls.Add(this.button_open_form_data);
            this.Controls.Add(this.listView_);
            this.Controls.Add(this.button_select_excel);
            this.Controls.Add(this.button_stop_tracking);
            this.Controls.Add(this.button_start_tracking);
            this.Controls.Add(this.label_status);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Подсчет завершения процессов";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.End_work);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_start_tracking;
        private System.Windows.Forms.Button button_stop_tracking;
        private System.Windows.Forms.Button button_select_excel;
        private System.Windows.Forms.Label label_status;
        private System.Windows.Forms.ListView listView_;
        private System.Windows.Forms.ColumnHeader column_number;
        private System.Windows.Forms.ColumnHeader column_name_proc;
        private System.Windows.Forms.ColumnHeader column_endtime;
        private System.Windows.Forms.ColumnHeader column_time_for_proc;
        private System.Windows.Forms.Button button_open_form_data;
    }
}

