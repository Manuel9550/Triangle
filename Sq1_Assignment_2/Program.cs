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

        public int GetSideB()
        {
            return sideB;
        }

        public double GetHypotenuse()
        {
            double result = 0.0;
            int sideA = GetSideA();
            int sideB = GetSideB();

            // now getting the result of the hypotenuse from the two sides.
            Math.Sqrt(Math.Pow(sideA, 2) + Math.Pow(sideB, 2));


            return result;
        }

    }

    



}
