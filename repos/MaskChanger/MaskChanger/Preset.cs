using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MaskChanger
{
    class Preset
    {
        public static int licznik = 0;
        public int ID { get; set; }
        public bool setdaily { get; set; }
        public string root_path { get; set; }
        public string source_path { get; set; }
        public string weather { get; set; }
        public string description { get; set; }
        public string time { get; set; }
        public string foldersufix { get; set; }
        public string cameraIDa { get; set; }
        public string cameraIDb { get; set; }
        private string calibFolderName { get; set; } = @"\calibration";
        private string autoCalibFolderName { get; set; } = @"\AutoCalibration";
        private string presetsFolderName { get; set; } = @"Presets\";

        DateTime dateTime = DateTime.Now;
        
       private void SetFoldersufix()
        {
            foldersufix = Convert.ToString(dateTime.Day + "." + dateTime.Month + "." + dateTime.Year + "-" + dateTime.Hour + "h" + dateTime.Minute + "m" + dateTime.Second + "s");

        }

        private void DeleteAutoCalibFolder()
        {
            string autocalib_path = root_path.Remove((root_path.Count())- calibFolderName.Count(), calibFolderName.Count()) + autoCalibFolderName;
            MessageBox.Show(autocalib_path);
            if (Directory.Exists(autocalib_path)) Directory.Delete(autocalib_path, true);

        }

        private void RestartTriCam()
        {

            foreach (Process p in Process.GetProcessesByName("FlightScope.Golf.TriCamApp"))
            {
                p.CloseMainWindow();
            }
        }

        public void SetPreset()
        {
            DeleteAutoCalibFolder();
            CopyMask(cameraIDa, 1);
            CopyMask(cameraIDb, 1);
            RestartTriCam();
        }

        private void CopyMask(string cameraID, int fromTo) //jeśli fromTo == 0, wtedy kopiuje maskę do przechowalni presetów, jeśli ==1, wtedy ustawia preset
                                                                                                                                // (wyjmuje z przechowalni)
        {
   

            string[] filename =  { "calibFrame.png", "mask.png", "motion_global.png" };


            string source_path_temp = System.IO.Path.Combine(source_path, cameraID); //ścieżka, do której będę zapisywał CalibFrame z folderu calibration

            
            string root_path_temp = System.IO.Path.Combine(root_path, cameraID); // oraz bezpośrednio do folderu kamery

            foreach (var name in filename)
            {
                string root_file = System.IO.Path.Combine(root_path_temp, name);  // i do pliku
                string source_file = System.IO.Path.Combine(source_path_temp, name);  //ścieżka do nowego pliku, do "przechowalni" presetów


                DirectoryInfo dir = new DirectoryInfo(source_path_temp);  //tworzę obiekt ścieżki

                if (Directory.Exists(dir.FullName) == false) System.IO.Directory.CreateDirectory(source_path_temp); //sprawdzam, czy folder kamery istnieje,
                                                                                                                    //jeśli nie, to tworzę folder

                if (fromTo == 0) System.IO.File.Copy(root_file, source_file, true);
                else System.IO.File.Copy(source_file, root_file, true);
            }
            



        }

        public Preset(string root_path, string weather, string description)  //tworzenie obiektu przez użytkownika
        {
            dateTime.ToString("d", DateTimeFormatInfo.InvariantInfo);
            this.setdaily = false;

            this.ID = licznik++;
            




            if (source_path == null)
            {
                this.weather = weather;
                this.description = description;

                this.root_path = root_path + calibFolderName;

                string[] cameraFolders = Directory.GetDirectories(this.root_path);


                DirectoryInfo dirIDa = new DirectoryInfo(cameraFolders[0]);

                DirectoryInfo dirIDb = new DirectoryInfo(cameraFolders[1]);

                this.cameraIDa = dirIDa.Name;
                this.cameraIDb = dirIDb.Name;

                SetFoldersufix();

                this.source_path = System.IO.Path.Combine(presetsFolderName, foldersufix);

                this.time = $"{dateTime.Hour}:{ dateTime.Minute}:{dateTime.Second}" + "_" + dateTime.ToString("d",
                  CultureInfo.CreateSpecificCulture("de-DE"));

                CopyMask(cameraIDa, 0);
                CopyMask(cameraIDb, 0);
            } 
        }

        public Preset(int ID, string root_path, string source_path, string foldersufix, string weather, string cameraIDa, string cameraIDb, string description, string time, bool setdaily) //tworzenie obiektu z XMLa
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
            this.setdaily = setdaily;
        }


    }
}
