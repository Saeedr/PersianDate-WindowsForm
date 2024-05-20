namespace TestPrj
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.button1 = new System.Windows.Forms.Button();
            this.persianDateTimePicker2 = new FreeControls.PersianDateTimePicker();
            this.persianDateTimePicker3 = new FreeControls.PersianDateTimePicker();
            this.persianMonthCalendar1 = new FreeControls.PersianMonthCalendar();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(13, 354);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 28);
            this.button1.TabIndex = 3;
            this.button1.Text = "Set Now";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // persianDateTimePicker2
            // 
            this.persianDateTimePicker2.BackColor = System.Drawing.Color.White;
            this.persianDateTimePicker2.Font = new System.Drawing.Font("B Yekan", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.persianDateTimePicker2.Location = new System.Drawing.Point(13, 44);
            this.persianDateTimePicker2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.persianDateTimePicker2.Name = "persianDateTimePicker2";
            this.persianDateTimePicker2.ShowTime = false;
            this.persianDateTimePicker2.Size = new System.Drawing.Size(175, 25);
            this.persianDateTimePicker2.TabIndex = 5;
            this.persianDateTimePicker2.Text = "persianDateTimePicker2";
            this.persianDateTimePicker2.Value = ((FreeControls.PersianDate)(resources.GetObject("persianDateTimePicker2.Value")));
            // 
            // persianDateTimePicker3
            // 
            this.persianDateTimePicker3.BackColor = System.Drawing.Color.White;
            this.persianDateTimePicker3.Font = new System.Drawing.Font("B Yekan", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.persianDateTimePicker3.Location = new System.Drawing.Point(13, 15);
            this.persianDateTimePicker3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.persianDateTimePicker3.Name = "persianDateTimePicker3";
            this.persianDateTimePicker3.ShowTime = true;
            this.persianDateTimePicker3.Size = new System.Drawing.Size(188, 25);
            this.persianDateTimePicker3.TabIndex = 6;
            this.persianDateTimePicker3.Text = "persianDateTimePicker3";
            this.persianDateTimePicker3.Value = ((FreeControls.PersianDate)(resources.GetObject("persianDateTimePicker3.Value")));
            this.persianDateTimePicker3.Visible = false;
            // 
            // persianMonthCalendar1
            // 
            this.persianMonthCalendar1.BackColor = System.Drawing.Color.White;
            this.persianMonthCalendar1.Font = new System.Drawing.Font("B Yekan", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.persianMonthCalendar1.Location = new System.Drawing.Point(13, 122);
            this.persianMonthCalendar1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.persianMonthCalendar1.MarkColor = System.Drawing.Color.Green;
            this.persianMonthCalendar1.MaximumSize = new System.Drawing.Size(325, 212);
            this.persianMonthCalendar1.MinimumSize = new System.Drawing.Size(325, 212);
            this.persianMonthCalendar1.Name = "persianMonthCalendar1";
            this.persianMonthCalendar1.ShowToday = true;
            this.persianMonthCalendar1.Size = new System.Drawing.Size(325, 212);
            this.persianMonthCalendar1.TabIndex = 7;
            this.persianMonthCalendar1.Text = "persianMonthCalendar1";
            this.persianMonthCalendar1.TitleBackColor = System.Drawing.SystemColors.ActiveCaption;
            this.persianMonthCalendar1.TitleForeColor = System.Drawing.Color.White;
            this.persianMonthCalendar1.Value = ((FreeControls.PersianDate)(resources.GetObject("persianMonthCalendar1.Value")));
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(235, 46);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 8;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(345, 399);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.persianMonthCalendar1);
            this.Controls.Add(this.persianDateTimePicker3);
            this.Controls.Add(this.persianDateTimePicker2);
            this.Controls.Add(this.button1);
            this.Font = new System.Drawing.Font("B Yekan", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private FreeControls.PersianDateTimePicker persianDateTimePicker2;
        private FreeControls.PersianDateTimePicker persianDateTimePicker3;
        private FreeControls.PersianMonthCalendar persianMonthCalendar1;
        private System.Windows.Forms.Button button2;





    }
}

