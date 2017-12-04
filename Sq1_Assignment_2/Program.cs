using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sq1_Assignment_2
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }

    public class Triangle
    {
        private int sideA;
        private int sideB;

        public Triangle(int a, int b)
        {
            sideA = a;
            sideB = b;


        }

        public int GetSideA()
        {
            return sideA;
        }


    }



}
