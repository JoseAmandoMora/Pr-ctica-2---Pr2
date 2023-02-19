using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Práctica_2___Pr2
{
    public class Figura
    {
        private double _area;
        private double _perimetro;

        public double Area { get; set; }
        public double Perimetro { get; set; }

        public virtual double GetArea()
        {
            return _area;
        }// metodo que hereda Triangulo de Figura 

        public virtual double GetPerimetro()
        {
            return _perimetro;

        }// metodo que hereda Trinagulo de Figura 

        public virtual void GetMostrar()
        {
            Console.WriteLine($"triangulo es");
        }
    }
}
