namespace optim
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.weeks = new System.Windows.Forms.Label();
            this.days = new System.Windows.Forms.Label();
            this.hours = new System.Windows.Forms.Label();
            this.seconds = new System.Windows.Forms.Label();
            this.mins = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.calendar = new System.Windows.Forms.DateTimePicker();
            this.webBrowser1 = new System.Windows.Forms.WebBrowser();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(521, 204);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.calendar);
            this.tabPage1.Controls.Add(this.mins);
            this.tabPage1.Controls.Add(this.label6);
            this.tabPage1.Controls.Add(this.seconds);
            this.tabPage1.Controls.Add(this.hours);
            this.tabPage1.Controls.Add(this.days);
            this.tabPage1.Controls.Add(this.weeks);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(513, 178);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Таймер";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.webBrowser1);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(513, 178);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Гугл";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.textBox1);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(513, 178);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "txt";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // tabPage4
            // 
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Size = new System.Drawing.Size(513, 178);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Угадай число";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Недель";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(94, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Дней";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(167, 55);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Часов";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(275, 55);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "Секунд";
            // 
            // weeks
            // 
            this.weeks.AutoSize = true;
            this.weeks.Location = new System.Drawing.Point(9, 77);
            this.weeks.Name = "weeks";
            this.weeks.Size = new System.Drawing.Size(35, 13);
            this.weeks.TabIndex = 3;
            this.weeks.Text = "label5";
            // 
            // days
            // 
            this.days.AutoSize = true;
            this.days.Location = new System.Drawing.Point(93, 77);
            this.days.Name = "days";
            this.days.Size = new System.Drawing.Size(35, 13);
            this.days.TabIndex = 3;
            this.days.Text = "label5";
            // 
            // hours
            // 
            this.hours.AutoSize = true;
            this.hours.Location = new System.Drawing.Point(167, 77);
            this.hours.Name = "hours";
            this.hours.Size = new System.Drawing.Size(35, 13);
            this.hours.TabIndex = 3;
            this.hours.Text = "label5";
            // 
            // seconds
            // 
            this.seconds.AutoSize = true;
            this.seconds.Location = new System.Drawing.Point(275, 77);
            this.seconds.Name = "seconds";
            this.seconds.Size = new System.Drawing.Size(35, 13);
            this.seconds.TabIndex = 3;
            this.seconds.Text = "label5";
            // 
            // mins
            // 
            this.mins.AutoSize = true;
            this.mins.Location = new System.Drawing.Point(226, 77);
            this.mins.Name = "mins";
            this.mins.Size = new System.Drawing.Size(35, 13);
            this.mins.TabIndex = 5;
            this.mins.Text = "label5";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(226, 55);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(46, 13);
            this.label6.TabIndex = 4;
            this.label6.Text = "Минуты";
            // 
            // calendar
            // 
            this.calendar.Location = new System.Drawing.Point(346, 6);
            this.calendar.Name = "calendar";
            this.calendar.Size = new System.Drawing.Size(167, 20);
            this.calendar.TabIndex = 6;
            // 
            // webBrowser1
            // 
            this.webBrowser1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.webBrowser1.Location = new System.Drawing.Point(3, 3);
            this.webBrowser1.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser1.Name = "webBrowser1";
            this.webBrowser1.ScriptErrorsSuppressed = true;
            this.webBrowser1.Size = new System.Drawing.Size(507, 172);
            this.webBrowser1.TabIndex = 0;
            this.webBrowser1.Url = new System.Uri("http://google.com", System.UriKind.Absolute);
            this.webBrowser1.WebBrowserShortcutsEnabled = false;
            // 
            // textBox1
            // 
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox1.Location = new System.Drawing.Point(0, 0);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(513, 20);
            this.textBox1.TabIndex = 0;
            this.textBox1.UseWaitCursor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(521, 204);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.Label seconds;
        private System.Windows.Forms.Label hours;
        private System.Windows.Forms.Label days;
        private System.Windows.Forms.Label weeks;
        private System.Windows.Forms.Label mins;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker calendar;
        private System.Windows.Forms.WebBrowser webBrowser1;
        private System.Windows.Forms.TextBox textBox1;
    }
}

