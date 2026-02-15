using System;
using System.Collections.Generic;
using System.Text;

namespace EjercicioGit
{
    public class Longitudes
    {
        private double Metros;


        public Longitudes(double metros)
        {
            Metros = metros;
        }

        public void ConversionCm()
        {
            double centimetros = Metros * 100;
            Console.WriteLine($"Total en centimetros: {centimetros}");
        }
    }
}
