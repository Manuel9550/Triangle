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
        private double angleA;
        private double angleB;

        public Triangle(int a, int b, double aa, double ab)
        {
            sideA = a;
            sideB = b;
            angleA = aa;
            angleB = ab;


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
            result = Math.Sqrt(Math.Pow(sideA, 2) + Math.Pow(sideB, 2));


            return result;
        }
        
        public double GetArea()
        {
            return Math.Abs( 0.5 * GetSideA() * GetSideB());
        }

        public double GetAngleA()
        {
            return angleA;
        }

        public double GetAngleB()
        {
            return angleB;
        }

        public double GetUnknownAngle()
        {
            double result = 180.0 - GetAngleA() - GetAngleB();

            if (result <= 0)
            {
                // return an error code
                result = -1;
            }
            return result;
        }

    }

    



}
