using System;
using System.Collections.Generic;
using System.Text;

namespace EjercicioGit
{
    public class Masa
    {
        private double ValorMasaKg;

        public Masa(double masa)
        {
            ValorMasaKg = masa;
        }

        public void ConversionGramos()
        {
            double valor = ValorMasaKg / 1000;
            Console.WriteLine($"Conversion a Gramos: {valor} g");
        }
    }


}
