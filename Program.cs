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
            string command = "";
            System.Diagnostics.Process.Start("CMD.exe", command);
        }
    }
}
