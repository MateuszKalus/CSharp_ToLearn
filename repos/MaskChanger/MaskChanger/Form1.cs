using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace MaskChanger
{
    public partial class Form1 : Form
    {
        List<Preset> preset_list = new List<Preset>();

        public void SaveToXML()
        {

            XDocument xml = new XDocument(
                new XDeclaration("1.0", "utf-8", "yes"),
                new XComment("Saved presets:"),
                    new XElement("presets",
                        from preset in preset_list
                        select new XElement("preset",
                            new XAttribute("ID", preset.ID),
                            new XElement("weather", preset.weather),
                            new XElement("root_path", preset.root_path),
                            new XElement("source_path", preset.source_path),
                            new XElement("foldersufix", preset.foldersufix),
                            new XElement("cameraIDa", preset.cameraIDa),
                            new XElement("cameraIDb", preset.cameraIDb),
                            new XElement("description", preset.description),
                            new XElement("time", preset.time),
                            new XAttribute("setDaily", preset.setdaily)
                        )
                    )
                );
            xml.Save("data.xml");
        }
        public void LoadFromXML()
        {
            try
            {
                if (File.Exists("data.xml"))
                {
                    XDocument xml = XDocument.Load("data.xml");

                    preset_list = (
                        from
                        preset in xml.Root.Elements("preset")
                        select new Preset(Convert.ToInt16(preset.Attribute("ID").Value), preset.Element("root_path").Value, preset.Element("source_path").Value,
                        preset.Element("foldersufix").Value, preset.Element("weather").Value, preset.Element("cameraIDa").Value, preset.Element("cameraIDb").Value,
                        preset.Element("description").Value, preset.Element("time").Value, Convert.ToBoolean(preset.Attribute("setDaily").Value))
                        ).ToList<Preset>();

                    RefreshListBox();

                }
            }
            catch (Exception except)
            {

            }
            
        }

        public void RefreshListBox()
        {
            listBox1.Items.Clear();
            foreach (var item in preset_list)
            {
                listBox1.Items.Add(item.ID);
            }
        }

        public Form1()
        {
            InitializeComponent();
            signs_lbl.Text = Convert.ToString(textBox1.Text.Count()) + "/" + textBox1.MaxLength;
            string[] weather_list = new string[] { "Cloudy", "Sunny", "Rainy" };

            comboBox1.Items.AddRange(weather_list);
            LoadFromXML();

            System.Threading.Thread.CurrentThread.CurrentCulture =
            System.Globalization.CultureInfo.CreateSpecificCulture("th-TH");

            if (File.Exists("path.txt"))
            {
                string s = File.ReadAllText(@"path.txt");
                string[] path_file = s.Split(';');

                if(path_file[0]=="1")
                {
                    folderpath_lbl.Text = path_file[1];
                    alwaysuse_checkbox.Checked = true;
                    folderBrowserDialog1.SelectedPath = folderpath_lbl.Text;
                }
                else
                {
                    alwaysuse_checkbox.Checked = false;
                }
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            signs_lbl.Text = Convert.ToString(textBox1.Text.Count()) + "/" + textBox1.MaxLength;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                preset_list.Add(new Preset(folderBrowserDialog1.SelectedPath, comboBox1.Text, textBox1.Text));
                listBox1.Items.Clear();

                foreach (var item in preset_list)
                {
                    listBox1.Items.Add(item.ID);
                }
                SaveToXML();
                MessageBox.Show("A new preset has been added. To use it, go to the \"Set\" tab.", "New preset");
            }
            catch (Exception except)
            {
                MessageBox.Show("Path to Hole<no> not set!");
            }

            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            folderBrowserDialog1.ShowDialog();
            folderpath_lbl.Text = Convert.ToString(folderBrowserDialog1.SelectedPath);
        }

        private void folderBrowserDialog1_HelpRequest(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            try
            {
                int selit = listBox1.SelectedIndex;
                setWeather.Text = preset_list[selit].weather;
                setTime.Text = preset_list[selit].time;
                setDescription.Text = preset_list[selit].description;
                setdaily_bn.Checked = preset_list[selit].setdaily;

                set_bn.Enabled = true;
            }
            catch (Exception ee)
            {

            }
        }

        private void set_bn_Click(object sender, EventArgs e)
        {
            
            int selit = listBox1.SelectedIndex;
            
            preset_list[selit].SetPreset();

            
        }
        private void ClearSetTab()
        {
            setTime.Text = null;
            setWeather.Text = null;
            setDescription.Text = null;
            setdaily_bn.Checked = false;
        }

        private void delete_bn_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Do you want to delete this preset?", "", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                int selit = listBox1.SelectedIndex;
                if (Directory.Exists(preset_list[selit].source_path)) Directory.Delete(preset_list[selit].source_path, true);
                preset_list.RemoveAt(selit);
                                
                RefreshListBox();
                SaveToXML();

                ClearSetTab();
            }
        }

        private void SaveCheckedChoice(int i)
        {
            if (i == 1)
            {
                string s = "1;" + folderpath_lbl.Text;
                File.WriteAllText("path.txt", s);
            }
            else
            {
                string s = "0;" + folderpath_lbl.Text;
                File.WriteAllText("path.txt", s);
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            

            if (alwaysuse_checkbox.Checked == true)
            {
                SaveCheckedChoice(1);
            }
            else
            {
                SaveCheckedChoice(0);
            }
        }

        private void setdaily_bn_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                if (setdaily_bn.Checked == true) preset_list[listBox1.SelectedIndex].setdaily = true;
                else preset_list[listBox1.SelectedIndex].setdaily = false;
                SaveToXML();
            }
            catch (Exception ee)
            {
                //MessageBox.Show(ee.Source);
            }
        }

        private void zegar_Tick(object sender, EventArgs e)
        {
            DateTime timecomp = DateTime.Now;
            

            foreach (var preset in preset_list)
            {
                string[] time = preset.time.Split(':');

                if (preset.setdaily == true && timecomp.Hour == Convert.ToInt32(time[0]) && timecomp.Minute == Convert.ToInt32(time[1]))
                {
                    //MessageBox.Show("ZMIENIONO PRESET");
                    preset.SetPreset();

                }

            }
        }
    }
}
