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
                            new XElement("time", preset.time)
                        )
                    )
                );
            xml.Save("data.xml");
        }
        public void LoadFromXML()
        {
            if (File.Exists("data.xml"))
            {
                XDocument xml = XDocument.Load("data.xml");

                    preset_list = (
                        from
                        preset in xml.Root.Elements("preset")
                        select new Preset(Convert.ToInt16(preset.Attribute("ID").Value), preset.Element("root_path").Value, preset.Element("source_path").Value,
                        preset.Element("foldersufix").Value, preset.Element("weather").Value, preset.Element("cameraIDa").Value, preset.Element("cameraIDb").Value, preset.Element("description").Value, preset.Element("time").Value)
                        ).ToList<Preset>();


                listBox1.Items.Clear();
                foreach (var item in preset_list)
                {
                    listBox1.Items.Add(item.ID);
                }
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
            preset_list.Add(new Preset(folderBrowserDialog1.SelectedPath, comboBox1.Text, textBox1.Text));
            listBox1.Items.Clear();

            foreach (var item in preset_list)
            {
                listBox1.Items.Add(item.ID);
            }
            SaveToXML();
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
            int selit = listBox1.SelectedIndex;
            setWeather.Text = preset_list[selit].weather;
            setTime.Text = preset_list[selit].time;
            setDescription.Text = preset_list[selit].description;

            set_bn.Enabled = true;
        }

        private void set_bn_Click(object sender, EventArgs e)
        {
            
            int selit = listBox1.SelectedIndex;
            
            preset_list[selit].SetPreset();
            
        }
    }
}
