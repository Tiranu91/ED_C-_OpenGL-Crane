using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoOpenGLBasicsCS
{
    static class TMatrix
    {

        public static double VektorLaenge(double[] vektor)
        {
            double d = 0.0;

            for (int i = 0; i < vektor.Length; i++)
            {
                d += Math.Pow(vektor[i], 2);
            }
                

            return Math.Sqrt(d);

        }

        public static double[] Verkuerzen(double[] vektor, double newvalue)
        {
            double[] ivektor = InvertiereVektor(vektor);
            double[] verkuerzterVektor = new double[vektor.Length];

            if (newvalue == 1)
                return vektor;
            else if (newvalue > 1)
                for (int i = 0; i < vektor.Length; i++)
                    verkuerzterVektor[i] = newvalue * vektor[i];
            else
                for (int i = 0; i < vektor.Length; i++)
                    verkuerzterVektor[i] = vektor[i] + newvalue * ivektor[i];


            return verkuerzterVektor;
        }

        public static double[] InvertiereVektor(double[] vektor)
        {
            double[] invertierterVektor = new double[vektor.Length];

            for (int i = 0; i < vektor.Length; i++)
            {
                invertierterVektor[i] = -vektor[i];
            }
                

            return invertierterVektor;
        }

        /*
        public static void ToString(double[] vec)
        {
            String str = "( ";
            foreach (double d in vec)
                str += d + " ";
            Console.WriteLine(str + ")");
        }
        */

        public static double[] Rotieren(double[] vektor, double deg)
        {
            if (vektor.Length != 3)
            {
                return null;
            }
                

            double grad = (Math.PI / 180) * deg;

            double[] rotiertervektor = new double[3];
            /*
            rvec[0] = vec[0];
            rvec[1] = 0 + Math.Cos(grad) * vec[1] - Math.Sin(grad) * vec[2];
            rvec[2] = 0 + Math.Sin(grad) * vec[1] + Math.Cos(grad) * vec[2];
            */
            rotiertervektor[0] = Math.Round(Math.Cos(grad) * vektor[0] - Math.Sin(grad) * vektor[1], 2);
            rotiertervektor[1] = Math.Round(Math.Sin(grad) * vektor[0] + Math.Cos(grad) * vektor[1], 2);
            rotiertervektor[2] = vektor[2];
            

            return rotiertervektor;
        }

        public static double ScalarProdukt(double[] v1, double[] v2)
        {
            if (v1.Length != v2.Length)
                return -1.0;

            double val = 0.0;

            for (int i = 0; i < v1.Length; i++)
                val += v1[i] * v2[i];
            return val;
        }

        public static double VectorWinkel3D(double[] v1, double[] v2)
        {
             return (180 * (Math.Acos(ScalarProdukt(v1, v2) / (VektorLaenge(v1) * VektorLaenge(v2))))) / Math.PI;
        }

        public static double VectorWinkel(double[] v1, double[] v2)
        {
            double[] vec1 = { v1[0], v1[1] }, vec2 = { v2[0], v2[1] };

            return (180 * (Math.Acos(ScalarProdukt(vec1, vec2) / (VektorLaenge(vec1) * VektorLaenge(vec2))))) / Math.PI;
        }

        public static int Quadrant(double[] vec)
        {
            if (vec.Length < 2)
                return -1;

            if (vec[0] > 0 && vec[2] > 0)
                return 1;
            else if (vec[0] < 0 && vec[1] > 0)
                return 2;
            else if (vec[0] < 0 && vec[1] < 0)
                return 3;
            else if (vec[0] > 0 && vec[1] < 0)
                return 4;

            return -1;
        }

        public static int RotationDirection(double[] targetVec, double[] startVec)
        {
            double val = startVec[0] * targetVec[1] - startVec[1] * targetVec[0];
            if (val > 0)
                return 1;
            else if (val < 0)
                return -1;
            else
                return 0;
        }

    }

}

