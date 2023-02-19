using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Práctica_2___Pr2
{
    public class Isosceles : Triangulo   // lado4 , lado5 y lado6 pertenecen a este tipo de triangulo con dos los lados iguales y uno diferente 
    {
        private double _b;
        private double _a;
        private protected double _hipotenusa;
        private protected double _cateto;
        private protected double _altura;
        public double B { get; set; }
        public double A { get; set; }
        public double Altura { get; set; }
        public double Cateto { get; set; }


        public Isosceles(double Lado1, double Lado2, double Lado3)
        {
            _lado1 = Lado1;
            _lado2 = Lado2;
            _lado3 = Lado3;
            _a = _lado1;
            _b = _lado3;

            if (_lado1 > _lado2 && _lado1 == _lado3)
            {
                _hipotenusa = _lado1;
                _cateto = (_lado2 / 2);
            }
            else
            {
                _hipotenusa = _lado2;
                _cateto = (_lado1 / 2);
            }

            _altura = (Math.Sqrt(((_hipotenusa) * (_hipotenusa)) - ((_cateto) * (_cateto))));

            if (_lado1 == _lado2 || _lado1 == _lado3)
            {
                _a = _lado1;
            }
            else
            {
                _b = _lado1;
                _a = _lado2;
            }

        }
        public override double GetArea()    // FORMULA PARA EL AREA (b*(LA RAIZCUADRADA DE A´2 - B´2/4 )/2
        {
            return ((_b * _altura) / 2);
        }
        public override double GetPerimetro()    // PERIMETRO 
        {
            return (2 * (_a) + _b);
        }

    }
}
