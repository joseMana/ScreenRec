using System;
using System.IO;
using System.Threading.Tasks;
using System.Windows.Forms;
using ScreenRecorderLib;

namespace ScreenRec
{
    internal class Program
    {
        static void Main(string[] args)
        {
            InitializeForm(new Form1());
            Console.ReadLine();
        }
       
        private static void InitializeForm(Form form)
        {
            if (form is Form1)
            {
                Application.Run(form);
            }
        }
    }
}
