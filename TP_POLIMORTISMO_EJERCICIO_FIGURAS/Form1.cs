using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TP_POLIMORTISMO_EJERCICIO_FIGURAS
{
    public partial class fPrincipal : Form
    {
        #region Estructuras
        #endregion

        #region Variables Globales
        Figura[] aFiguras;
        int ultimo, tope;
        #endregion

        #region Métodos Propios
        private int PosicionCirculo(ref Figura[] alista, int ult, int subindice)
        {
            int indice = -1;
            if (ult != -1)
            {
                do
                    if (alista[++indice].GetType() == typeof(Circulo))
                        subindice--;
                while (indice < ult && subindice >= 0);
            }
            return indice;
        }

        private int PosicionCuadrado(ref Figura[] alista, int ult, int subindice)
        {
            int indice = -1;
            if (ult != -1)
            {
                do
                    if (alista[++indice].GetType() == typeof(Cuadrado))
                        subindice--;
                while (indice < ult && subindice >= 0);
            }
            return indice;
        }

        private int PosicionRectangulo(ref Figura[] alista, int ult, int subindice)
        {
            int indice = -1;
            if(ult != -1)
            {
                do
                    if (alista[++indice].GetType() == typeof(Rectangulo))
                        subindice--;
                while (indice < ult && subindice >= 0) ;
            }
            return indice;
        }

        private int PosicionTriangulo(ref Figura[] alista, int ult, int subindice)
        {
            int indice = -1;
            if(ult != -1)
            {
                do
                    if (alista[++indice].GetType() == typeof(Triangulo))
                        subindice--;
                while (indice < ult && subindice >= 0) ;
            }
            return indice;
        }

        private void RedimensionarArreglo(ref Figura[] alista, int ult, ref int total, int valor)
        {
            Figura[] aCopia = alista;
            total += valor;
            alista = new Figura[total];

            for(int indice = 0; indice <= ult; indice++)
                alista[indice] = aCopia[indice];
        }

        private void Listar()
        {
            lbFiguras.Items.Clear();

            for (int indice = 0; indice <= ultimo; indice++)
                if (rbCirculo.Checked && aFiguras[indice].GetType() == typeof(Circulo) || rbCuadrado.Checked && aFiguras[indice].GetType() == typeof(Cuadrado) || rbRectangulo.Checked && aFiguras[indice].GetType() == typeof(Rectangulo) || rbTriangulo.Checked && aFiguras[indice].GetType() == typeof(Triangulo))
                    lbFiguras.Items.Add(aFiguras[indice].ToString());
        }

        private void ActualizarPantalla()
        {
            Listar();

            LCantidadListado.Text = lbFiguras.Items.Count.ToString();
            LCantidadFiguras.Text = (ultimo + 1).ToString();
        }
        #endregion

        #region Eventos
        public fPrincipal()
        {
            InitializeComponent();

            tope = 20;
            aFiguras = new Figura[tope];
            ultimo = -1;
        }

        private void bAgregar_Click(object sender, EventArgs e)
        {
            double valor1 = (tDato1.Text.Trim() != "") ? Convert.ToDouble(tDato1.Text.Trim()) : 0;
            double valor2 = (tDato2.Text.Trim() != "") ? Convert.ToDouble(tDato2.Text.Trim()) : 0;
            double valor3 = (tDato3.Text.Trim() != "") ? Convert.ToDouble(tDato3.Text.Trim()) : 0;

            if (tDato1.Text.Trim() == "")
            {
                MessageBox.Show("Debe ingresar un valor", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                tDato1.Focus();
            }
            else if (valor1 <= 0)
            {
                MessageBox.Show("El valor ingresado tiene que ser mayor a cero", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                tDato1.Focus();
            }
            else
            {
                if (ultimo + 1 == tope)
                    RedimensionarArreglo(ref aFiguras, ultimo, ref tope, 5);

                if (rbCirculo.Checked)
                {
                    aFiguras[++ultimo] = new Circulo(valor1);
                    ActualizarPantalla();

                    tDato1.Clear();
                }
                else if (rbCuadrado.Checked)
                {
                    aFiguras[++ultimo] = new Cuadrado(valor1);
                    ActualizarPantalla();

                    tDato1.Clear();
                }
                else if (tDato2.Text.Trim() == "")
                {
                    MessageBox.Show("Debe ingresar un valor", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    tDato2.Focus();
                }
                else if (valor2 <= 0)
                {
                    MessageBox.Show("El valor ingresado tiene que ser mayor a cero", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    tDato2.Focus();
                }
                else if (rbRectangulo.Checked)
                {
                    aFiguras[++ultimo] = new Rectangulo(valor1, valor2);
                    ActualizarPantalla();

                    tDato1.Clear();
                    tDato2.Clear();
                }
                else if (tDato3.Text.Trim() == "")
                {
                    MessageBox.Show("Debe ingresar un valor", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    tDato3.Focus();
                }
                else if (valor3 <= 0)
                {
                    MessageBox.Show("El valor ingresado tiene que ser mayor a cero", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    tDato3.Focus();
                }
                else
                {
                    if (!Triangulo.LadosValidos(valor1, valor2, valor3))
                    {
                        MessageBox.Show("No se cumple la desigualdad triangular","Error",MessageBoxButtons.OK,MessageBoxIcon.Stop);
                        tDato1.Focus();
                    }
                    else
                    {
                        aFiguras[++ultimo] = new Triangulo(valor1, valor2, valor3);
                        ActualizarPantalla();

                        tDato1.Clear();
                        tDato2.Clear();
                        tDato3.Clear();
                    }
                }
            }
        }

        private void bArea_Click(object sender, EventArgs e)
        {
            int indice_lista = lbFiguras.SelectedIndex;
            int indice;

            if (indice_lista == -1)
                MessageBox.Show("No se selecciono ningún elemento de la lista","Aviso",MessageBoxButtons.OK,MessageBoxIcon.Warning);
            else
            {
                indice = (rbCirculo.Checked) ? PosicionCirculo(ref aFiguras, ultimo, indice_lista) : (rbCuadrado.Checked) ? PosicionCuadrado(ref aFiguras, ultimo, indice_lista) : (rbRectangulo.Checked) ? PosicionRectangulo(ref aFiguras, ultimo, indice_lista) : PosicionTriangulo(ref aFiguras, ultimo, indice_lista);
                MessageBox.Show("El área es de: " + aFiguras[indice].Area().ToString("F2"), "Área", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void bPerimetro_Click(object sender, EventArgs e)
        {
            int indice_lista = lbFiguras.SelectedIndex;
            int indice;

            if (indice_lista == -1)
                MessageBox.Show("No se selecciono ningún elemento de la lista", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else
            {
                indice = (rbCirculo.Checked) ? PosicionCirculo(ref aFiguras, ultimo, indice_lista) : (rbCuadrado.Checked) ? PosicionCuadrado(ref aFiguras, ultimo, indice_lista) : (rbRectangulo.Checked) ? PosicionRectangulo(ref aFiguras, ultimo, indice_lista) : PosicionTriangulo(ref aFiguras, ultimo, indice_lista);
                MessageBox.Show("El perímetro es de: " + aFiguras[indice].Perimetro().ToString("F2"),"Perímetro",MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
        }

        private void rbCirculo_CheckedChanged(object sender, EventArgs e)
        {
            if (rbCirculo.Checked)
            {
                gbIngreso.Text = rbCirculo.Text;

                lDato1.Text = "Radio: ";
                tDato1.Focus();

                LEtiquetaListado.Text = "Cantidad de " + rbCirculo.Text + "s: ";
                LCantidadListado.Location = new Point(LEtiquetaListado.Location.X + LEtiquetaListado.Size.Width, LCantidadListado.Location.Y);

                ActualizarPantalla();
            }
            else
            {
                lDato2.Visible = false;
                tDato2.Visible = false;

                lDato3.Visible = false;
                tDato3.Visible = false;
            }
        }

        private void rbCuadrado_CheckedChanged(object sender, EventArgs e)
        {
            if (rbCuadrado.Checked)
            {
                gbIngreso.Text = rbCuadrado.Text;

                lDato1.Text = "Lado: ";
                tDato1.Focus();

                LEtiquetaListado.Text = "Cantidad de " + rbCuadrado.Text + "s: ";
                LCantidadListado.Location = new Point(LEtiquetaListado.Location.X + LEtiquetaListado.Size.Width, LCantidadListado.Location.Y);

                ActualizarPantalla();
            }
            else
            {
                lDato2.Visible = false;
                tDato2.Visible = false;

                lDato3.Visible = false;
                tDato3.Visible = false;
            }
        }

        private void rbTriangulo_CheckedChanged(object sender, EventArgs e)
        {
            if (rbTriangulo.Checked)
            {
                gbIngreso.Text = rbTriangulo.Text;

                lDato1.Text = "Lado 1: ";
                lDato2.Text = "Lado 2: ";
                lDato3.Text = "Lado 3: ";

                tDato1.Focus();

                lDato2.Visible = true;
                tDato2.Visible = true;

                lDato3.Visible = true;
                tDato3.Visible = true;

                LEtiquetaListado.Text = "Cantidad de " + rbTriangulo.Text + "s: ";
                LCantidadListado.Location = new Point(LEtiquetaListado.Location.X + LEtiquetaListado.Size.Width, LCantidadListado.Location.Y);

                ActualizarPantalla();
            }
            else
            {
                lDato2.Visible = false;
                tDato2.Visible = false;

                lDato3.Visible = false;
                tDato3.Visible = false;
            }
        }

        private void rbRectangulo_CheckedChanged(object sender, EventArgs e)
        {
            if (rbRectangulo.Checked)
            {
                gbIngreso.Text = rbRectangulo.Text;

                lDato1.Text = "Base: ";
                lDato2.Text = "Altura: ";

                tDato1.Focus();

                lDato2.Visible = true;
                tDato2.Visible = true;

                LEtiquetaListado.Text = "Cantidad de " + rbRectangulo.Text + "s: ";
                LCantidadListado.Location = new Point(LEtiquetaListado.Location.X + LEtiquetaListado.Size.Width, LCantidadListado.Location.Y);

                ActualizarPantalla();
            }
            else
            {
                lDato2.Visible = false;
                tDato2.Visible = false;

                lDato3.Visible = false;
                tDato3.Visible = false;
            }
        }

        private void ValorNumerico_KeyPress(object sender, KeyPressEventArgs e)
        {
            char caracter = (char)e.KeyChar;
            e.Handled = !Char.IsNumber(caracter) && caracter != ((char)Keys.Delete) && caracter != ((char)Keys.Back) && caracter != ',';
        }

        private void bCerrar_Click(object sender, EventArgs e)
        {
            DialogResult respuesta = MessageBox.Show("¿Está seguro que quiere cerrar la aplicación?","Confirmar",MessageBoxButtons.YesNo,MessageBoxIcon.Question);
            if (respuesta == DialogResult.Yes)
                Close();
        }
        #endregion
    }
}
