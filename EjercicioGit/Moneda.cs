using System;
using System.Collections.Generic;
using System.Text;

namespace EjercicioGit
{
    public class Moneda
    {
        private double Dolar;

        public Moneda(double dolar)
        {
            Dolar = dolar;
        }

        public void Convertir_A_Lempiras()
        {
            double total = Dolar * 26.39;
            Console.WriteLine($"Cantidad de dolares {Dolar}");
            Console.WriteLine($"Cantidad en Lempiras: {total} L");
        }

        public void Convertir_A_Euros()
        {
            double euros = Dolar * 0.84;
            Console.WriteLine($"Cantidad en Euros: {euros} €");
        }
    }
}
