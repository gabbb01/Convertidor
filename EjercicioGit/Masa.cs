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
            Console.WriteLine($"Cantidad de kg {ValorMasaKg}");
            Console.WriteLine($"Conversion a Gramos: {valor} g");
        }

        public void ConversionLibras()
        {
            double libras = ValorMasaKg * 2.205;
            Console.WriteLine($"Conversion a Libras: {libras} lb");
        }
    }

}
