using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP_POLIMORTISMO_EJERCICIO_FIGURAS
{
    internal class Rectangulo : Figura
    {
        #region "atributos"
        private double _base;
        private double _altura;
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

        #endregion

        #region "métodos"
        public override double Perimetro()
        {
            double perimetro = 2 * (_base + _altura);

            return perimetro;
        }

        public override double Area()
        {
            double area = (_base * _altura);

            return area;
        }

        public override string ToString()
        {
            string cadena = $"Base: {_base} - Altura: {_altura}";

            return cadena;
        }
        #endregion

        #region "constructores"
        public Rectangulo(double Base, double Altura)
        {
            if (Base > 0)
            {
                _base = Base;
            }

            if (Altura > 0)
            {
                _altura = Altura;
            }
        }
        #endregion
    }
}
