using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_calcolatrice
{
    internal static class CalcoliHelper
    {
        public static int Somma (int a,  int b)
        {
            return a + b;
        }
        public static double Somma(double a, double b)
        {
            return a + b;
        }
        public static int Differenza(int a, int b)
        {
            return a - b;
        }
        public static double Differenza(double a, double b)
        {
            return a - b;
        }
        public static int  Moltiplicazione(int a, int b)
        {
            return a * b;
        }
        public static double Moltiplicazione(double a, double b)
        {
            return a * b;
        }
        public static int Assoluto(int a)
        {
            if (a >= 0)
                return a;
            return -a;
        }
        public static double Assoluto(double a)
        {
            if (a >= 0)
                return a;
            return -a;
        }
        public static int Minimo(int a, int b)
        {
            if (a <= b)
                return a;
            return b;
        }
        public static double Minimo(double a, double b)
        {
            if (a <= b)
                return a;
            return b;
        }
        public static int Massimo(int a, int b)
        {
            if (a >= b)
                return a;
            return b;
        }
        public static double Massimo(double a, double b)
        {
            if (a >= b)
                return a;
            return b;
        }
        public static int Potenza(int baseP, int esp)
        {
            if (esp == 0)
                return 1;
            else if (baseP == 0)
                return 0;
            else if (esp > 0)
            {
                int risultato = baseP;
                for(int i = 1; i < esp; i++)
                    risultato *= baseP;
                return risultato;
            }
            else
            {
                int risultato = 1;
                for (int i = 1; i < esp; i++)
                    risultato /= baseP;
                return risultato;
            }
        }
    }
}
