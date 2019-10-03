using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ObjectsFormTest
{
    public partial class Form1 : Form
    {
        List<Ksiazka> lista_ksiazek = new List<Ksiazka>();
        List<PictureBox> listaboxow = new List<PictureBox>();

        public Form1()
        {
            InitializeComponent();
            pictureBox1.ImageLocation = @"..\..\Resources\green.png";

        }

        private void label1_Click(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            listView1.Items.Clear();
            lista_ksiazek.Add(new Ksiazka(tytulTx.Text, autorTx.Text, Convert.ToInt32(rokTx.Text), Convert.ToDouble(cenaTx.Text)));

            foreach (var ksiazka in lista_ksiazek)
            {
                ListViewItem item = new ListViewItem(ksiazka.Tytul);
                item.SubItems.Add(ksiazka.Autor);
                item.SubItems.Add(Convert.ToString(ksiazka.Rok));
                item.SubItems.Add(Convert.ToString(ksiazka.Cena));
                item.SubItems.Add(Convert.ToString(ksiazka.Id));

                listView1.Items.Add(item);
            }
            /*
            ListViewItem item = new ListViewItem(Convert.ToString(Ksiazka.licznikId));

            item.SubItems.Add(tytulTx.Text);
            item.SubItems.Add(autorTx.Text);
            item.SubItems.Add(cenaTx.Text);
            item.SubItems.Add(rokTx.Text);

            listView1.Items.Add(item);
            */


        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            //var indeks = listView1.Items.IndexOf(listView1.SelectedItems[0]);
            
            tytulTx.Text = Convert.ToString(lista_ksiazek[0].Tytul);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            

            lista_ksiazek.RemoveAt(listView1.Items.IndexOf(listView1.SelectedItems[0]));
            listView1.Items.Remove(listView1.SelectedItems[0]);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {            
  
            

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            listaboxow.Add(new PictureBox());

            if (listaboxow.Count != 1)
            {

                listaboxow[listaboxow.Count-1].Image = global::ObjectsFormTest.Properties.Resources.green;
                listaboxow[listaboxow.Count - 1].Location = new System.Drawing.Point(listaboxow[listaboxow.Count-2].Location.X, listaboxow[listaboxow.Count-2].Location.Y + 30);
                listaboxow[listaboxow.Count - 1].Name = "pictureBox2";
                listaboxow[listaboxow.Count - 1].Size = new System.Drawing.Size(21, 21);
                listaboxow[listaboxow.Count - 1].TabIndex = 11;
                listaboxow[listaboxow.Count - 1].TabStop = false;
                //box.Click += new System.EventHandler(this.pictureBox1_Click);
                Controls.Add(listaboxow[listaboxow.Count - 1]);
            } else
            {
                listaboxow[0].Image = global::ObjectsFormTest.Properties.Resources.green;
                listaboxow[0].Location = new System.Drawing.Point(pictureBox1.Location.X, pictureBox1.Location.Y + 30);
                listaboxow[0].Name = "pictureBox2";
                listaboxow[0].Size = new System.Drawing.Size(21, 21);
                listaboxow[0].TabIndex = 11;
                listaboxow[0].TabStop = false;
                //box.Click += new System.EventHandler(this.pictureBox1_Click);
                Controls.Add(listaboxow[0]);
            }

            
        }
    }
}
