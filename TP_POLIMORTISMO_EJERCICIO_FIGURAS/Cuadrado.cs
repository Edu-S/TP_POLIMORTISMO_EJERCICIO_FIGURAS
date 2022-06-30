using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP_POLIMORTISMO_EJERCICIO_FIGURAS
{
    internal class Cuadrado : Rectangulo
    {
        #region "atributos"
        private double _lado;
        #endregion

        #region "propiedades"
        public double lado
        {
            get { return _lado; }
            set { _lado = value; }
        }
        #endregion

        #region "consultas"
        public double getLado()
        {
            return _lado;
        }
        #endregion

        #region "métodos"
        public override double Perimetro()
        {
            double perimetro = _lado * 4;

            return perimetro;
        }

        public override double Area()
        {
            double area = (Math.Pow(_lado, 2));

            return area;
        }

        public override string ToString()
        {
            string cadena = "Lado: " + _lado + " - " + base.ToString();
            return cadena;
        }
        #endregion

        #region "constructores"
        public Cuadrado(double lado) : base(lado, lado)
        {
            if (lado > 0)
            {
                _lado = lado;
            }
        }
        #endregion
    }
}
