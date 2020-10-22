using System;
using System.IO;


namespace callPythonCode
{
    class Program
    {
        static void Main(string[] args)
        {

        }

        void CallPythonProgramm()
        {
            System.Diagnostics.Process.Start("CMD.exe", "python3 main.py");
        }

        void CopyFilesToFlashDrive(string savePath)
        {
            string[] files = new string[8] { "amount.txt", "seite1.txt", "seite2checkboxes.txt", "seite2textboxes.txt", "seite3.txt", "seite4.txt", "seite5.txt", "seite6.txt" };

            try
            {
                foreach (string item in files)
                {
                    File.Move(item, savePath + "/" + item);
                }
            }
            catch (Exception ex) { Console.WriteLine(ex); }
        }

        void ReadFilesFromFlashDrive(string readPath)
        {
            Console.WriteLine("Sind Sie sicher, dass Sie die bereits existierenden Daten Überschreiben wollen? Wenn ja geben Sie ja ein und drücken Enter. Sonst drücken Sie eine beliebige Taste.");
            if (Console.ReadLine() == "ja")
            {
                string[] files = new string[8] { "amount.txt", "seite1.txt", "seite2checkboxes.txt", "seite2textboxes.txt", "seite3.txt", "seite4.txt", "seite5.txt", "seite6.txt" };

                try
                {
                    foreach (string item in files)
                    {
                        File.Move(readPath + "/" + item, item);
                    }
                }
                catch (Exception ex) { Console.WriteLine(ex); }
            }
            else
            {
                Console.WriteLine("Der Überschreibvorgang wurde abgebrochen.");
            }
        }
    }
}
