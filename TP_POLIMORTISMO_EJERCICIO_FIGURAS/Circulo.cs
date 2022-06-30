using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP_POLIMORTISMO_EJERCICIO_FIGURAS
{
    internal class Circulo : Figura
    {
        #region "atributos"
        private double _radio;
        #endregion

        #region "propiedades"
        public double Radio
        {
            get { return _radio; }
            set { _radio = value; }
        }
        #endregion

        #region "consultas"
        public double getRadio()
        {
            return _radio;
        }
        public override double Perimetro()
        {
            double perimetro = 2 * _radio * Math.PI;

            return perimetro;
        }

        public override double Area()
        {
            double area = Math.PI * (Math.Pow(_radio, 2));
            return area;
        }

        public override string ToString()
        {
            string cadena = $"Radio: {_radio}";

            return cadena;
        }
        #endregion

        #region "constructores"
        public Circulo(double radio)
        {
            if (radio > 0)
            {
                _radio = radio;
            }
        }
        #endregion
    }
}
