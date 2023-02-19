using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Práctica_2___Pr2
{
    internal class Program
    {/// <summary>
     ///  JOSE AMANDO MORA RIVAS 29.634.375  pr2 a2023
     /// </summary>
     /// <param name="args"></param>
        static void Main(string[] args)
        {

            Equilatero equilatero1 = new Equilatero(5, 5, 5);
            Figura figura1 = equilatero1;                       /// triangulo equilatero 
            figura1.GetMostrar();
            Console.WriteLine($"Area del Equilatero : {figura1.GetArea()} Perimetro del equilatero: {figura1.GetPerimetro()}");

            Isosceles isosceles1 = new Isosceles(7, 7, 4);
            Figura figura2 = isosceles1;                            // triangulo isosceles 
            figura2.GetMostrar();
            Console.WriteLine($"Area del Isosceles : {figura2.GetArea()} Perimetro del Isosceles: {figura2.GetPerimetro()}");

            Escaleno escaleno1 = new Escaleno(4, 5, 3);
            Figura figura3 = escaleno1;                      /// triangulo Escaleno 
            figura3.GetMostrar();
            Console.WriteLine($"Area del Escaleno : {figura3.GetArea()} Perimetro del Escaleno: {figura3.GetPerimetro()}");
            Console.ReadLine();
        }
    }
}
