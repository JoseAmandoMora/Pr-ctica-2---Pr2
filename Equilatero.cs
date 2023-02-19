using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Práctica_2___Pr2
{
    class Equilatero : Triangulo    // lado1 , lado2 y lado3 pertenecen a este tipo de triangulo con todos los lados igual
    {
        private double _altura;
        //listo

        public Equilatero(double Lado1, double Lado2, double Lado3)
        {
            _lado1 = Lado1;
            _lado2 = Lado2;
            _lado3 = Lado3;
            _altura = (Math.Sqrt(3) * _lado1 / 2);
        }
        public override double GetArea()
        {
            return _lado1 * _altura / 2;
        }
        public override double GetPerimetro()
        {
            return _lado1 + _lado2 + _lado3;
        }
    }
}
