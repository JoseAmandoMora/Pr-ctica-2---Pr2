using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Práctica_2___Pr2
{
    public class Triangulo : Figura
    {
        private protected double _lado1;
        private protected double _lado2;
        private protected double _lado3;

        //      ATRIBUTOS QUE VAN A HEREDAR  EQUILATERO , ISOSCELES Y ESCALENO DE  LA CLASE DE TRIANGULO    
        public virtual double lado1(double Lado1)
        {
            _lado1 = Lado1;
            return _lado1;
        }
        public virtual double lado2(double Lado2)
        {
            _lado2 = Lado2;
            return _lado2;

        }
        public virtual double lado3(double Lado3)
        {
            _lado3 = Lado3;
            return _lado3;
        }
        public double Lado1 { get; set; }
        public double Lado2 { get; set; }
        public double Lado3 { get; set; }

        // metodo que heredan equilatero , isosceles y escaleno
    }
}
