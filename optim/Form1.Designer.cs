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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.calendar = new System.Windows.Forms.DateTimePicker();
            this.mins = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.seconds = new System.Windows.Forms.Label();
            this.hours = new System.Windows.Forms.Label();
            this.days = new System.Windows.Forms.Label();
            this.weeks = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.webBrowser1 = new System.Windows.Forms.WebBrowser();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.textBox = new System.Windows.Forms.TextBox();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripDropDownButton2 = new System.Windows.Forms.ToolStripDropDownButton();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripDropDownButton1 = new System.Windows.Forms.ToolStripDropDownButton();
            this.arialToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.impactToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.comicSansMSToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.raz = new System.Windows.Forms.ToolStripComboBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.toolStrip1.SuspendLayout();
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
            // calendar
            // 
            this.calendar.Location = new System.Drawing.Point(346, 6);
            this.calendar.Name = "calendar";
            this.calendar.Size = new System.Drawing.Size(167, 20);
            this.calendar.TabIndex = 6;
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
            // seconds
            // 
            this.seconds.AutoSize = true;
            this.seconds.Location = new System.Drawing.Point(275, 77);
            this.seconds.Name = "seconds";
            this.seconds.Size = new System.Drawing.Size(35, 13);
            this.seconds.TabIndex = 3;
            this.seconds.Text = "label5";
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
            // days
            // 
            this.days.AutoSize = true;
            this.days.Location = new System.Drawing.Point(93, 77);
            this.days.Name = "days";
            this.days.Size = new System.Drawing.Size(35, 13);
            this.days.TabIndex = 3;
            this.days.Text = "label5";
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
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(275, 55);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "Секунд";
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
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(94, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Дней";
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
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.textBox);
            this.tabPage3.Controls.Add(this.toolStrip1);
            this.tabPage3.Controls.Add(this.comboBox1);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(513, 178);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "txt";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // textBox
            // 
            this.textBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox.Location = new System.Drawing.Point(0, 25);
            this.textBox.Multiline = true;
            this.textBox.Name = "textBox";
            this.textBox.Size = new System.Drawing.Size(513, 153);
            this.textBox.TabIndex = 3;
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripDropDownButton2,
            this.toolStripDropDownButton1,
            this.raz});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(513, 25);
            this.toolStrip1.TabIndex = 2;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripDropDownButton2
            // 
            this.toolStripDropDownButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripDropDownButton2.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.toolStripMenuItem2,
            this.toolStripMenuItem3});
            this.toolStripDropDownButton2.Image = ((System.Drawing.Image)(resources.GetObject("toolStripDropDownButton2.Image")));
            this.toolStripDropDownButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripDropDownButton2.Name = "toolStripDropDownButton2";
            this.toolStripDropDownButton2.Size = new System.Drawing.Size(59, 22);
            this.toolStripDropDownButton2.Text = "Шрифт";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(156, 22);
            this.toolStripMenuItem1.Text = "Arial";
            this.toolStripMenuItem1.Click += new System.EventHandler(this.toolStripMenuItem1_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(156, 22);
            this.toolStripMenuItem2.Text = "Impact";
            this.toolStripMenuItem2.Click += new System.EventHandler(this.toolStripMenuItem2_Click);
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(156, 22);
            this.toolStripMenuItem3.Text = "Comic Sans MS";
            this.toolStripMenuItem3.Click += new System.EventHandler(this.toolStripMenuItem3_Click);
            // 
            // toolStripDropDownButton1
            // 
            this.toolStripDropDownButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripDropDownButton1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.arialToolStripMenuItem,
            this.impactToolStripMenuItem,
            this.comicSansMSToolStripMenuItem});
            this.toolStripDropDownButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripDropDownButton1.Image")));
            this.toolStripDropDownButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripDropDownButton1.Name = "toolStripDropDownButton1";
            this.toolStripDropDownButton1.Size = new System.Drawing.Size(46, 22);
            this.toolStripDropDownButton1.Text = "Цвет";
            // 
            // arialToolStripMenuItem
            // 
            this.arialToolStripMenuItem.Name = "arialToolStripMenuItem";
            this.arialToolStripMenuItem.Size = new System.Drawing.Size(123, 22);
            this.arialToolStripMenuItem.Text = "Зеленый";
            this.arialToolStripMenuItem.Click += new System.EventHandler(this.arialToolStripMenuItem_Click_1);
            // 
            // impactToolStripMenuItem
            // 
            this.impactToolStripMenuItem.Name = "impactToolStripMenuItem";
            this.impactToolStripMenuItem.Size = new System.Drawing.Size(123, 22);
            this.impactToolStripMenuItem.Text = "Красный";
            this.impactToolStripMenuItem.Click += new System.EventHandler(this.impactToolStripMenuItem_Click);
            // 
            // comicSansMSToolStripMenuItem
            // 
            this.comicSansMSToolStripMenuItem.Name = "comicSansMSToolStripMenuItem";
            this.comicSansMSToolStripMenuItem.Size = new System.Drawing.Size(123, 22);
            this.comicSansMSToolStripMenuItem.Text = "Черный";
            this.comicSansMSToolStripMenuItem.Click += new System.EventHandler(this.comicSansMSToolStripMenuItem_Click);
            // 
            // raz
            // 
            this.raz.Name = "raz";
            this.raz.Size = new System.Drawing.Size(121, 25);
            this.raz.TextUpdate += new System.EventHandler(this.raz_TextUpdate);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "123"});
            this.comboBox1.Location = new System.Drawing.Point(0, 0);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 1;
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
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
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
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.Label seconds;
        private System.Windows.Forms.Label hours;
        private System.Windows.Forms.Label days;
        private System.Windows.Forms.Label weeks;
        private System.Windows.Forms.Label mins;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker calendar;
        private System.Windows.Forms.WebBrowser webBrowser1;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripDropDownButton toolStripDropDownButton1;
        private System.Windows.Forms.ToolStripMenuItem arialToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem impactToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem comicSansMSToolStripMenuItem;
        private System.Windows.Forms.TextBox textBox;
        private System.Windows.Forms.ToolStripDropDownButton toolStripDropDownButton2;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem3;
        private System.Windows.Forms.ToolStripComboBox raz;
    }
}

