using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Práctica_2___Pr2
{
    class Escaleno : Triangulo // lado7 , lado8 y lado9 pertenecen a este tipo de triangulo con todos los lados diferentes
    {
        private double semiperimetro;

        public double Semipetrimetro { get; set; }


        public Escaleno(double Lado1, double Lado2, double Lado3)
        {
            _lado1 = Lado1;
            _lado2 = Lado2;
            _lado3 = Lado3;
            semiperimetro = (_lado1 + _lado2 + _lado3) / 2; //calculo el semiperimetro para saber el area de un escaleno 
        }

        public override double GetArea()    // calculo del area
        {
            return (Math.Sqrt(semiperimetro * ((semiperimetro - _lado1) * (semiperimetro - _lado2) * (semiperimetro - _lado3))));
        }

        public override double GetPerimetro()
        {
            return (_lado1 + _lado2 + _lado3);
        }
    }
}
