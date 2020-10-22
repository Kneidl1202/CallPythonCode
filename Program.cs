using System;

namespace callPythonCode
{
    class Program
    {
        static void Main(string[] args)
        {

        }

        void CallPythonProgramm()
        {
            string path = Environment.CurrentDirectory;
            string command = path + "/" + "main.py";
            System.Diagnostics.Process.Start("CMD.exe", command);
        }

        void CopyFilesToFlashDrive()
        {
            string amount = "amount.txt";
            string originalPage1 = "seite1.txt";
            string originalPage2_1 = "seite2checkboxes.txt";
            string originalPage2_2 = "seite2textboxes.txt";
            string originalPage_3 = "seite3.txt";
            string originalPage_4 = "seite4.txt";
            string originalPage_5 = "seite5.txt";
            string originalPage_6 = "seite6.txt";


        }
    }
}
