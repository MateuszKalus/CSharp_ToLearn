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

        public void SetPreset()
        {
            CopyMask(cameraIDa, 1);
            CopyMask(cameraIDb, 1);
        }

        private void CopyMask(string cameraID, int fromTo) //jeśli fromTo == 0, wtedy kopiuje maskę do przechowalni presetów, jeśli ==1, wtedy ustawia preset
                                                                                                                                // (wyjmuje z przechowalni)
        {
   

            string filename = "calibFrame.png";
            string source_path_temp = System.IO.Path.Combine(source_path, cameraID); //ścieżka, do której będę zapisywał CalibFrame z folderu calibration

            
            string root_path_temp = System.IO.Path.Combine(root_path, cameraID); // oraz bezpośrednio do folderu kamery
      

            string root_file = System.IO.Path.Combine(root_path_temp, filename);  // i do pliku
            string source_file = System.IO.Path.Combine(source_path_temp, filename);  //ścieżka do nowego pliku, do "przechowalni" presetów


            DirectoryInfo dir = new DirectoryInfo(source_path_temp);  //tworzę obiekt ścieżki

            if (Directory.Exists(dir.FullName) == false) System.IO.Directory.CreateDirectory(source_path_temp); //sprawdzam, czy folder kamery istnieje,
                                                                                                           //jeśli nie, to tworzę folder

            if (fromTo == 0 ) System.IO.File.Copy(root_file, source_file, true);
            else System.IO.File.Copy(source_file, root_file, true);



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

                MessageBox.Show("1");

                string[] cameraFolders = Directory.GetDirectories(this.root_path);
                MessageBox.Show("2");

                DirectoryInfo dirIDa = new DirectoryInfo(cameraFolders[0]);
                MessageBox.Show("2,5");
                DirectoryInfo dirIDb = new DirectoryInfo(cameraFolders[1]);
                MessageBox.Show("3");
                this.cameraIDa = dirIDa.Name;
                this.cameraIDb = dirIDb.Name;
                MessageBox.Show(cameraIDb);

                SetFoldersufix();

                this.source_path = System.IO.Path.Combine(@"Presets\", foldersufix);

                this.time = $"{dateTime.Hour}:{ dateTime.Minute}:{dateTime.Second}" + "_" + dateTime.ToString("d",
                  CultureInfo.CreateSpecificCulture("de-DE"));

                CopyMask(cameraIDa, 0);
                CopyMask(cameraIDb, 0);
            } 
        }

        public Preset(int ID, string root_path, string source_path, string foldersufix, string weather, string cameraIDa, string cameraIDb, string description, string time) //tworzenie obiektu z XMLa
        {
            //foldersufix = Convert.ToString(dateTime.Day + "." + dateTime.Month + "." + dateTime.Year + "h" + dateTime.Hour + "m" + dateTime.Minute + "s" + dateTime.Second);
            this.cameraIDa = cameraIDa;
            this.cameraIDb = cameraIDb;
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
