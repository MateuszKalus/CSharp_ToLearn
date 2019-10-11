namespace MaskChanger
{
    partial class Form1
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.button1 = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.weather_label = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.signs_lbl = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.folderpath_lbl = new System.Windows.Forms.Label();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.Save_page = new System.Windows.Forms.TabPage();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.folderpath_lbl2 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.alwaysuse_checkbox = new System.Windows.Forms.CheckBox();
            this.Set_page = new System.Windows.Forms.TabPage();
            this.setdaily_bn = new System.Windows.Forms.CheckBox();
            this.delete_bn = new System.Windows.Forms.Button();
            this.set_bn = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.setDescription = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.setTime = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.setWeather = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.zegar = new System.Windows.Forms.Timer(this.components);
            this.tabControl1.SuspendLayout();
            this.Save_page.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.Set_page.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(6, 20);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(192, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Save new preset";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(6, 47);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(141, 355);
            this.listBox1.TabIndex = 1;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(6, 82);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 2;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // weather_label
            // 
            this.weather_label.AutoSize = true;
            this.weather_label.Location = new System.Drawing.Point(3, 66);
            this.weather_label.Name = "weather_label";
            this.weather_label.Size = new System.Drawing.Size(51, 13);
            this.weather_label.TabIndex = 3;
            this.weather_label.Text = "Weather:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 123);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Description:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // textBox1
            // 
            this.textBox1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.textBox1.Location = new System.Drawing.Point(6, 140);
            this.textBox1.MaxLength = 200;
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox1.Size = new System.Drawing.Size(284, 82);
            this.textBox1.TabIndex = 5;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // signs_lbl
            // 
            this.signs_lbl.AutoSize = true;
            this.signs_lbl.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.signs_lbl.Location = new System.Drawing.Point(248, 225);
            this.signs_lbl.Name = "signs_lbl";
            this.signs_lbl.Size = new System.Drawing.Size(42, 13);
            this.signs_lbl.TabIndex = 6;
            this.signs_lbl.Text = "0 / 500";
            this.signs_lbl.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(6, 254);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(200, 23);
            this.button2.TabIndex = 7;
            this.button2.Text = "Set \"Hole<number> folder";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // folderpath_lbl
            // 
            this.folderpath_lbl.AutoSize = true;
            this.folderpath_lbl.Location = new System.Drawing.Point(3, 280);
            this.folderpath_lbl.Name = "folderpath_lbl";
            this.folderpath_lbl.Size = new System.Drawing.Size(38, 13);
            this.folderpath_lbl.TabIndex = 8;
            this.folderpath_lbl.Text = "NONE";
            this.folderpath_lbl.TextChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            this.folderpath_lbl.Click += new System.EventHandler(this.folderpath_lbl_Click);
            // 
            // folderBrowserDialog1
            // 
            this.folderBrowserDialog1.HelpRequest += new System.EventHandler(this.folderBrowserDialog1_HelpRequest);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.Save_page);
            this.tabControl1.Controls.Add(this.Set_page);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(408, 434);
            this.tabControl1.TabIndex = 9;
            // 
            // Save_page
            // 
            this.Save_page.Controls.Add(this.pictureBox3);
            this.Save_page.Controls.Add(this.pictureBox2);
            this.Save_page.Controls.Add(this.folderpath_lbl2);
            this.Save_page.Controls.Add(this.button3);
            this.Save_page.Controls.Add(this.alwaysuse_checkbox);
            this.Save_page.Controls.Add(this.button1);
            this.Save_page.Controls.Add(this.folderpath_lbl);
            this.Save_page.Controls.Add(this.comboBox1);
            this.Save_page.Controls.Add(this.button2);
            this.Save_page.Controls.Add(this.weather_label);
            this.Save_page.Controls.Add(this.signs_lbl);
            this.Save_page.Controls.Add(this.label1);
            this.Save_page.Controls.Add(this.textBox1);
            this.Save_page.Location = new System.Drawing.Point(4, 22);
            this.Save_page.Name = "Save_page";
            this.Save_page.Padding = new System.Windows.Forms.Padding(3);
            this.Save_page.Size = new System.Drawing.Size(400, 408);
            this.Save_page.TabIndex = 0;
            this.Save_page.Text = "Save";
            this.Save_page.UseVisualStyleBackColor = true;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(212, 314);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(30, 30);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 13;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Visible = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(212, 254);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(30, 30);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 12;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Visible = false;
            // 
            // folderpath_lbl2
            // 
            this.folderpath_lbl2.AutoSize = true;
            this.folderpath_lbl2.Location = new System.Drawing.Point(3, 340);
            this.folderpath_lbl2.Name = "folderpath_lbl2";
            this.folderpath_lbl2.Size = new System.Drawing.Size(38, 13);
            this.folderpath_lbl2.TabIndex = 11;
            this.folderpath_lbl2.Text = "NONE";
            this.folderpath_lbl2.TextChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            this.folderpath_lbl2.Click += new System.EventHandler(this.folderpath_lbl2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(6, 314);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(200, 23);
            this.button3.TabIndex = 10;
            this.button3.Text = "Set \"FlightScope.Golf.TriCamApp.exe\"";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // alwaysuse_checkbox
            // 
            this.alwaysuse_checkbox.AutoSize = true;
            this.alwaysuse_checkbox.Checked = true;
            this.alwaysuse_checkbox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.alwaysuse_checkbox.Location = new System.Drawing.Point(6, 385);
            this.alwaysuse_checkbox.Name = "alwaysuse_checkbox";
            this.alwaysuse_checkbox.Size = new System.Drawing.Size(136, 17);
            this.alwaysuse_checkbox.TabIndex = 9;
            this.alwaysuse_checkbox.Text = "always use these paths";
            this.alwaysuse_checkbox.UseVisualStyleBackColor = true;
            this.alwaysuse_checkbox.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // Set_page
            // 
            this.Set_page.Controls.Add(this.setdaily_bn);
            this.Set_page.Controls.Add(this.delete_bn);
            this.Set_page.Controls.Add(this.set_bn);
            this.Set_page.Controls.Add(this.label4);
            this.Set_page.Controls.Add(this.setDescription);
            this.Set_page.Controls.Add(this.label3);
            this.Set_page.Controls.Add(this.setTime);
            this.Set_page.Controls.Add(this.label2);
            this.Set_page.Controls.Add(this.setWeather);
            this.Set_page.Controls.Add(this.listBox1);
            this.Set_page.Controls.Add(this.pictureBox1);
            this.Set_page.Location = new System.Drawing.Point(4, 22);
            this.Set_page.Name = "Set_page";
            this.Set_page.Padding = new System.Windows.Forms.Padding(3);
            this.Set_page.Size = new System.Drawing.Size(400, 408);
            this.Set_page.TabIndex = 1;
            this.Set_page.Text = "Set";
            this.Set_page.UseVisualStyleBackColor = true;
            // 
            // setdaily_bn
            // 
            this.setdaily_bn.AutoSize = true;
            this.setdaily_bn.Location = new System.Drawing.Point(269, 85);
            this.setdaily_bn.Name = "setdaily_bn";
            this.setdaily_bn.Size = new System.Drawing.Size(64, 17);
            this.setdaily_bn.TabIndex = 11;
            this.setdaily_bn.Text = "set daily";
            this.setdaily_bn.UseVisualStyleBackColor = true;
            this.setdaily_bn.CheckedChanged += new System.EventHandler(this.setdaily_bn_CheckedChanged);
            // 
            // delete_bn
            // 
            this.delete_bn.BackColor = System.Drawing.Color.Transparent;
            this.delete_bn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.delete_bn.Cursor = System.Windows.Forms.Cursors.Default;
            this.delete_bn.Location = new System.Drawing.Point(154, 287);
            this.delete_bn.Name = "delete_bn";
            this.delete_bn.Size = new System.Drawing.Size(75, 23);
            this.delete_bn.TabIndex = 9;
            this.delete_bn.Text = "Delete";
            this.delete_bn.UseVisualStyleBackColor = false;
            this.delete_bn.Click += new System.EventHandler(this.delete_bn_Click);
            // 
            // set_bn
            // 
            this.set_bn.Enabled = false;
            this.set_bn.Location = new System.Drawing.Point(294, 288);
            this.set_bn.Name = "set_bn";
            this.set_bn.Size = new System.Drawing.Size(75, 23);
            this.set_bn.TabIndex = 8;
            this.set_bn.Text = "SET";
            this.set_bn.UseVisualStyleBackColor = true;
            this.set_bn.Click += new System.EventHandler(this.set_bn_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(150, 92);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Description:";
            // 
            // setDescription
            // 
            this.setDescription.Location = new System.Drawing.Point(153, 108);
            this.setDescription.Multiline = true;
            this.setDescription.Name = "setDescription";
            this.setDescription.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.setDescription.Size = new System.Drawing.Size(216, 170);
            this.setDescription.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(266, 48);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(33, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Time:";
            // 
            // setTime
            // 
            this.setTime.Enabled = false;
            this.setTime.Location = new System.Drawing.Point(269, 64);
            this.setTime.Name = "setTime";
            this.setTime.Size = new System.Drawing.Size(100, 20);
            this.setTime.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(150, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Weather:";
            // 
            // setWeather
            // 
            this.setWeather.Enabled = false;
            this.setWeather.Location = new System.Drawing.Point(153, 64);
            this.setWeather.Name = "setWeather";
            this.setWeather.Size = new System.Drawing.Size(100, 20);
            this.setWeather.TabIndex = 2;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(151, 284);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(81, 29);
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            // 
            // zegar
            // 
            this.zegar.Enabled = true;
            this.zegar.Interval = 60000;
            this.zegar.Tick += new System.EventHandler(this.zegar_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(438, 453);
            this.Controls.Add(this.tabControl1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "MaskChanger v0.31";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.Save_page.ResumeLayout(false);
            this.Save_page.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.Set_page.ResumeLayout(false);
            this.Set_page.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label weather_label;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label signs_lbl;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label folderpath_lbl;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage Save_page;
        private System.Windows.Forms.TabPage Set_page;
        private System.Windows.Forms.CheckBox alwaysuse_checkbox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox setDescription;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox setTime;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox setWeather;
        private System.Windows.Forms.Button set_bn;
        private System.Windows.Forms.Button delete_bn;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.CheckBox setdaily_bn;
        private System.Windows.Forms.Timer zegar;
        private System.Windows.Forms.Label folderpath_lbl2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}

