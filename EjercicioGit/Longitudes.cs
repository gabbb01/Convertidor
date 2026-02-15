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
            Console.WriteLine($"Total en centimetros: {centimetros} cm");
        }

        public void ConversionKm()
        {
            double km = Metros / 1000;
            Console.WriteLine($"Total en kilometros: {km} km");
        }
    }
}
