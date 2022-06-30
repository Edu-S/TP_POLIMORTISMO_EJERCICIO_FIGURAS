using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP_POLIMORTISMO_EJERCICIO_FIGURAS
{
    internal class Triangulo : Figura
    {
        #region "atributos"
        private double _base;
        private double _altura;
        private double _lado1;
        private double _lado2;
        #endregion

        #region "propiedades"
        public double Base
        {
            get { return _base; }
            set { _base = value; }
        }

        public double Altura
        {
            get { return _altura; }
            set { _altura = value; }
        }

        public double Lado1
        {
            get { return _lado1; }
            set { _lado1 = value; }
        }

        public double Lado2
        {
            get { return _lado2; }
            set { _lado2 = value; }
        }
        #endregion

        #region "consultas"
        public double getBase()
        {
            return _base;
        }

        public double getAltura()
        {
            return _altura;
        }

        public double getLado1()
        {
            return _lado1;
        }

        public double getLado2()
        {
            return _lado2;
        }
        #endregion

        #region "métodos"
        public static bool LadosValidos(double lado1, double lado2, double lado3)
        {
            return (lado1 + lado2) > lado3 && (lado1 + lado3) > lado2 && (lado2 + lado3) > lado1;
        }

        public override double Perimetro()
        {
            double perimetro = _base + _lado1 + _lado2;
            return perimetro;
        }

        public override double Area()
        {
            double semip = Perimetro() / 2;
            double area = Math.Sqrt(semip * (semip - _base) * (semip - Lado1) * (semip - Lado2));

            return area;
        }

        public override string ToString()
        {
            string cadena = "Base: " + _base.ToString("F2") + " - Altura: " + _altura.ToString("F2") + " - Lado 1: " + _lado1.ToString("F2") + " - Lado 2: " + _lado2.ToString("F2");
            return cadena;
        }
        #endregion

        #region "constructores"
        public Triangulo(double lado1, double lado2, double lado3)
        {
            if(lado1 != 0 && lado2 != 0 && lado3 != 0)
            {
                if(lado1 > lado2 && lado1 > lado3)
                {
                    _base = lado1;
                    Lado1 = lado2;
                    Lado2 = lado3;
                }
                else if(lado2 > lado3)
                {
                    _base = lado2;
                    Lado1 = lado1;
                    Lado2 = lado3;
                }
                else
                {
                    _base = lado3;
                    Lado1 = lado1;
                    Lado2 = lado2;
                }

                _altura = Area() * 2 / _base;
            }
        }

        public Triangulo(double Base, double Altura, double lado1, double lado2)
        {
            if (Base > 0)
            {
                _base = Base;
            }

            if (lado1 > 0)
            {
                _lado1 = lado1;
            }

            if (lado2 > 0)
            {
                _lado2 = lado2;
            }

            if(Altura > 0)
            {
                _altura = Altura;
            }
        }
        #endregion
    }
}
