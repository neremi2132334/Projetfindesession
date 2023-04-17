using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculatrice2._0
{
    partial class Calculateur
    {
        //Fonction Addition
        public double Addition(int x, int y)
        {
            double total = x + y;
            return total;
        }

        //Fonction Soustraction
        public double Soustraction(int x, int y)
        {
            double total = x - y;
            return total;
        }

        //Fonction Divsion
        public double Diviser(int x, int y)
        {
            double total = x / y;
            return total;
        }

        //Fonction Multiplication
        public double Multiplier(int x, int y)
        {
            double total = x * y;
            return total;
        }


        //Fonction Log
        public double Exposant(int x, int y)
        {
            double z;
            z = Math.Pow(x, y);
            return z;
        }

        //Fonction Log
        public double Log(int x, int y)
        {
            double total = Math.Log(x,y);
            return total;
        }




    }
}
