using System;
using System.Drawing;

namespace EjercicioPolimorfismo
{
    public class Program
    {
        static void Main(string[] args)
        {

            Figura figura1 = new Circulo(8);
            Figura figura2 = new Rectangulo(2, 7);


            Console.WriteLine("Área del círculo: " + figura1.CalcularArea());
            Console.WriteLine("Área del rectángulo: " + figura2.CalcularArea());
        }
    }

}

