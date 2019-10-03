using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MaskChanger
{
    class Preset
    {
        public static int licznik = 0;
        public int ID { get; set; }
        public string root_path { get; set; }
        public string source_path { get; set; }
        public string weather { get; set; }
        public string description { get; set; }
        public string time { get; set; }
        public string foldersufix { get; set; }
        public string cameraIDa { get; set; }
        public string cameraIDb { get; set; }

        DateTime dateTime = DateTime.Now;
        
       private void SetFoldersufix()
        {
            foldersufix = Convert.ToString(dateTime.Day + "." + dateTime.Month + "." + dateTime.Year + "-" + dateTime.Hour + "h" + dateTime.Minute + "m" + dateTime.Second + "s");

        }



        private void CopyMask()
        {
            string filename = "calibFrame.png";

            source_path = System.IO.Path.Combine(source_path, ""); //ścieżka, do której będę zapisywał CalibFrame z folderu calibration
            //root_path = root_path;
            string root_file = System.IO.Path.Combine(root_path, filename);
            string source_file = System.IO.Path.Combine(source_path, filename);
            System.IO.Directory.CreateDirectory(source_path);
            System.IO.File.Copy(root_file, source_file, true);


        }

        public Preset(string root_path, string weather, string description)  //tworzenie obiektu przez użytkownika
        {
            dateTime.ToString("d", DateTimeFormatInfo.InvariantInfo);


            //MessageBox.Show(foldersufix);
            this.ID = licznik++;
            




            if (source_path == null)
            {
                this.weather = weather;
                this.description = description;

                this.root_path = root_path + @"\calibration";

                string[] cameraFolders = Directory.GetDirectories(this.root_path);

                this.cameraIDa = cameraFolders[0];
                this.cameraIDb = cameraFolders[1];
                MessageBox.Show(cameraIDb);


                SetFoldersufix();

                this.source_path = System.IO.Path.Combine(@"Presets\", foldersufix);
                this.time = $"{dateTime.Hour}:{ dateTime.Minute}:{dateTime.Second}" + "_" + dateTime.ToString("d",
                  CultureInfo.CreateSpecificCulture("de-DE"));

                CopyMask();
            } 
        }

        public Preset(int ID, string root_path, string source_path, string foldersufix, string weather, string description, string time) //tworzenie obiektu z XMLa
        {
            //foldersufix = Convert.ToString(dateTime.Day + "." + dateTime.Month + "." + dateTime.Year + "h" + dateTime.Hour + "m" + dateTime.Minute + "s" + dateTime.Second);
            this.foldersufix = foldersufix;
            this.ID = licznik++;
            this.root_path = root_path;
            this.weather = weather;
            this.description = description;
            this.source_path = source_path;
            this.time = time;
        }
    }
}
