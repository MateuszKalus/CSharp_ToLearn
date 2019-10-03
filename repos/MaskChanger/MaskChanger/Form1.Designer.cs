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
            this.Set_page = new System.Windows.Forms.TabPage();
            this.tabControl1.SuspendLayout();
            this.Save_page.SuspendLayout();
            this.Set_page.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(6, 20);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(192, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Save actual preset";
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
            this.textBox1.Size = new System.Drawing.Size(284, 92);
            this.textBox1.TabIndex = 5;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // signs_lbl
            // 
            this.signs_lbl.AutoSize = true;
            this.signs_lbl.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.signs_lbl.Location = new System.Drawing.Point(248, 235);
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
            this.button2.Size = new System.Drawing.Size(121, 23);
            this.button2.TabIndex = 7;
            this.button2.Text = "Set calibration folder";
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
            // Set_page
            // 
            this.Set_page.Controls.Add(this.listBox1);
            this.Set_page.Location = new System.Drawing.Point(4, 22);
            this.Set_page.Name = "Set_page";
            this.Set_page.Padding = new System.Windows.Forms.Padding(3);
            this.Set_page.Size = new System.Drawing.Size(400, 408);
            this.Set_page.TabIndex = 1;
            this.Set_page.Text = "Set";
            this.Set_page.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(438, 453);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.tabControl1.ResumeLayout(false);
            this.Save_page.ResumeLayout(false);
            this.Save_page.PerformLayout();
            this.Set_page.ResumeLayout(false);
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
    }
}

