
namespace TP_POLIMORTISMO_EJERCICIO_FIGURAS
{
    partial class fPrincipal
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.bAgregar = new System.Windows.Forms.Button();
            this.gbIngreso = new System.Windows.Forms.GroupBox();
            this.lDato3 = new System.Windows.Forms.Label();
            this.lDato2 = new System.Windows.Forms.Label();
            this.lDato1 = new System.Windows.Forms.Label();
            this.gbFiguras = new System.Windows.Forms.GroupBox();
            this.rbRectangulo = new System.Windows.Forms.RadioButton();
            this.rbTriangulo = new System.Windows.Forms.RadioButton();
            this.rbCuadrado = new System.Windows.Forms.RadioButton();
            this.rbCirculo = new System.Windows.Forms.RadioButton();
            this.lbFiguras = new System.Windows.Forms.ListBox();
            this.bArea = new System.Windows.Forms.Button();
            this.bPerimetro = new System.Windows.Forms.Button();
            this.bCerrar = new System.Windows.Forms.Button();
            this.LEtiquetaListado = new System.Windows.Forms.Label();
            this.label = new System.Windows.Forms.Label();
            this.LCantidadFiguras = new System.Windows.Forms.Label();
            this.LCantidadListado = new System.Windows.Forms.Label();
            this.tDato1 = new System.Windows.Forms.TextBox();
            this.tDato2 = new System.Windows.Forms.TextBox();
            this.tDato3 = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.gbIngreso.SuspendLayout();
            this.gbFiguras.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.bAgregar);
            this.panel1.Controls.Add(this.gbIngreso);
            this.panel1.Controls.Add(this.gbFiguras);
            this.panel1.Location = new System.Drawing.Point(13, 10);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(439, 166);
            this.panel1.TabIndex = 2;
            // 
            // bAgregar
            // 
            this.bAgregar.Location = new System.Drawing.Point(360, 130);
            this.bAgregar.Name = "bAgregar";
            this.bAgregar.Size = new System.Drawing.Size(75, 23);
            this.bAgregar.TabIndex = 2;
            this.bAgregar.Text = "Agregar";
            this.bAgregar.UseVisualStyleBackColor = true;
            this.bAgregar.Click += new System.EventHandler(this.bAgregar_Click);
            // 
            // gbIngreso
            // 
            this.gbIngreso.Controls.Add(this.tDato3);
            this.gbIngreso.Controls.Add(this.tDato2);
            this.gbIngreso.Controls.Add(this.tDato1);
            this.gbIngreso.Controls.Add(this.lDato3);
            this.gbIngreso.Controls.Add(this.lDato2);
            this.gbIngreso.Controls.Add(this.lDato1);
            this.gbIngreso.Location = new System.Drawing.Point(179, 5);
            this.gbIngreso.Name = "gbIngreso";
            this.gbIngreso.Size = new System.Drawing.Size(175, 116);
            this.gbIngreso.TabIndex = 1;
            this.gbIngreso.TabStop = false;
            this.gbIngreso.Text = "Círculo";
            // 
            // lDato3
            // 
            this.lDato3.AutoSize = true;
            this.lDato3.Location = new System.Drawing.Point(9, 64);
            this.lDato3.Name = "lDato3";
            this.lDato3.Size = new System.Drawing.Size(43, 13);
            this.lDato3.TabIndex = 2;
            this.lDato3.Text = "Lado 2:";
            this.lDato3.Visible = false;
            // 
            // lDato2
            // 
            this.lDato2.AutoSize = true;
            this.lDato2.Location = new System.Drawing.Point(9, 43);
            this.lDato2.Name = "lDato2";
            this.lDato2.Size = new System.Drawing.Size(37, 13);
            this.lDato2.TabIndex = 1;
            this.lDato2.Text = "Altura:";
            this.lDato2.Visible = false;
            // 
            // lDato1
            // 
            this.lDato1.AutoSize = true;
            this.lDato1.Location = new System.Drawing.Point(9, 22);
            this.lDato1.Name = "lDato1";
            this.lDato1.Size = new System.Drawing.Size(41, 13);
            this.lDato1.TabIndex = 0;
            this.lDato1.Text = "Radio: ";
            // 
            // gbFiguras
            // 
            this.gbFiguras.Controls.Add(this.rbRectangulo);
            this.gbFiguras.Controls.Add(this.rbTriangulo);
            this.gbFiguras.Controls.Add(this.rbCuadrado);
            this.gbFiguras.Controls.Add(this.rbCirculo);
            this.gbFiguras.Location = new System.Drawing.Point(9, 3);
            this.gbFiguras.Name = "gbFiguras";
            this.gbFiguras.Size = new System.Drawing.Size(159, 150);
            this.gbFiguras.TabIndex = 0;
            this.gbFiguras.TabStop = false;
            this.gbFiguras.Text = "Figura";
            // 
            // rbRectangulo
            // 
            this.rbRectangulo.AutoSize = true;
            this.rbRectangulo.Location = new System.Drawing.Point(10, 120);
            this.rbRectangulo.Name = "rbRectangulo";
            this.rbRectangulo.Size = new System.Drawing.Size(80, 17);
            this.rbRectangulo.TabIndex = 3;
            this.rbRectangulo.Text = "Rectángulo";
            this.rbRectangulo.UseVisualStyleBackColor = true;
            this.rbRectangulo.CheckedChanged += new System.EventHandler(this.rbRectangulo_CheckedChanged);
            // 
            // rbTriangulo
            // 
            this.rbTriangulo.AutoSize = true;
            this.rbTriangulo.Location = new System.Drawing.Point(11, 88);
            this.rbTriangulo.Name = "rbTriangulo";
            this.rbTriangulo.Size = new System.Drawing.Size(69, 17);
            this.rbTriangulo.TabIndex = 2;
            this.rbTriangulo.Text = "Triángulo";
            this.rbTriangulo.UseVisualStyleBackColor = true;
            this.rbTriangulo.CheckedChanged += new System.EventHandler(this.rbTriangulo_CheckedChanged);
            // 
            // rbCuadrado
            // 
            this.rbCuadrado.AutoSize = true;
            this.rbCuadrado.Location = new System.Drawing.Point(11, 56);
            this.rbCuadrado.Name = "rbCuadrado";
            this.rbCuadrado.Size = new System.Drawing.Size(71, 17);
            this.rbCuadrado.TabIndex = 1;
            this.rbCuadrado.Text = "Cuadrado";
            this.rbCuadrado.UseVisualStyleBackColor = true;
            this.rbCuadrado.CheckedChanged += new System.EventHandler(this.rbCuadrado_CheckedChanged);
            // 
            // rbCirculo
            // 
            this.rbCirculo.AutoSize = true;
            this.rbCirculo.Checked = true;
            this.rbCirculo.Location = new System.Drawing.Point(11, 24);
            this.rbCirculo.Name = "rbCirculo";
            this.rbCirculo.Size = new System.Drawing.Size(59, 17);
            this.rbCirculo.TabIndex = 0;
            this.rbCirculo.TabStop = true;
            this.rbCirculo.Text = "Círculo";
            this.rbCirculo.UseVisualStyleBackColor = true;
            this.rbCirculo.CheckedChanged += new System.EventHandler(this.rbCirculo_CheckedChanged);
            // 
            // lbFiguras
            // 
            this.lbFiguras.FormattingEnabled = true;
            this.lbFiguras.Location = new System.Drawing.Point(22, 182);
            this.lbFiguras.Name = "lbFiguras";
            this.lbFiguras.Size = new System.Drawing.Size(345, 134);
            this.lbFiguras.TabIndex = 1;
            // 
            // bArea
            // 
            this.bArea.Location = new System.Drawing.Point(373, 187);
            this.bArea.Name = "bArea";
            this.bArea.Size = new System.Drawing.Size(75, 23);
            this.bArea.TabIndex = 2;
            this.bArea.Text = "&Area";
            this.bArea.UseVisualStyleBackColor = true;
            this.bArea.Click += new System.EventHandler(this.bArea_Click);
            // 
            // bPerimetro
            // 
            this.bPerimetro.Location = new System.Drawing.Point(373, 216);
            this.bPerimetro.Name = "bPerimetro";
            this.bPerimetro.Size = new System.Drawing.Size(75, 23);
            this.bPerimetro.TabIndex = 3;
            this.bPerimetro.Text = "&Perímetro";
            this.bPerimetro.UseVisualStyleBackColor = true;
            this.bPerimetro.Click += new System.EventHandler(this.bPerimetro_Click);
            // 
            // bCerrar
            // 
            this.bCerrar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.bCerrar.Location = new System.Drawing.Point(373, 328);
            this.bCerrar.Name = "bCerrar";
            this.bCerrar.Size = new System.Drawing.Size(75, 23);
            this.bCerrar.TabIndex = 4;
            this.bCerrar.Text = "&Cerrar";
            this.bCerrar.UseVisualStyleBackColor = true;
            this.bCerrar.Click += new System.EventHandler(this.bCerrar_Click);
            // 
            // LEtiquetaListado
            // 
            this.LEtiquetaListado.AutoSize = true;
            this.LEtiquetaListado.Location = new System.Drawing.Point(19, 323);
            this.LEtiquetaListado.Name = "LEtiquetaListado";
            this.LEtiquetaListado.Size = new System.Drawing.Size(112, 13);
            this.LEtiquetaListado.TabIndex = 5;
            this.LEtiquetaListado.Text = "Cantidad de Círculos: ";
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Location = new System.Drawing.Point(19, 342);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(104, 13);
            this.label.TabIndex = 6;
            this.label.Text = "Cantidad de Figuras:";
            // 
            // LCantidadFiguras
            // 
            this.LCantidadFiguras.AutoSize = true;
            this.LCantidadFiguras.Location = new System.Drawing.Point(124, 342);
            this.LCantidadFiguras.Name = "LCantidadFiguras";
            this.LCantidadFiguras.Size = new System.Drawing.Size(13, 13);
            this.LCantidadFiguras.TabIndex = 7;
            this.LCantidadFiguras.Text = "0";
            // 
            // LCantidadListado
            // 
            this.LCantidadListado.AutoSize = true;
            this.LCantidadListado.Location = new System.Drawing.Point(137, 323);
            this.LCantidadListado.Name = "LCantidadListado";
            this.LCantidadListado.Size = new System.Drawing.Size(13, 13);
            this.LCantidadListado.TabIndex = 8;
            this.LCantidadListado.Text = "0";
            // 
            // tDato1
            // 
            this.tDato1.Location = new System.Drawing.Point(69, 15);
            this.tDato1.MaxLength = 12;
            this.tDato1.Name = "tDato1";
            this.tDato1.Size = new System.Drawing.Size(100, 20);
            this.tDato1.TabIndex = 3;
            this.tDato1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ValorNumerico_KeyPress);
            // 
            // tDato2
            // 
            this.tDato2.Location = new System.Drawing.Point(69, 39);
            this.tDato2.MaxLength = 12;
            this.tDato2.Name = "tDato2";
            this.tDato2.Size = new System.Drawing.Size(100, 20);
            this.tDato2.TabIndex = 4;
            this.tDato2.Visible = false;
            this.tDato2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ValorNumerico_KeyPress);
            // 
            // tDato3
            // 
            this.tDato3.Location = new System.Drawing.Point(69, 61);
            this.tDato3.MaxLength = 12;
            this.tDato3.Name = "tDato3";
            this.tDato3.Size = new System.Drawing.Size(100, 20);
            this.tDato3.TabIndex = 5;
            this.tDato3.Visible = false;
            this.tDato3.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ValorNumerico_KeyPress);
            // 
            // fPrincipal
            // 
            this.AcceptButton = this.bAgregar;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.GhostWhite;
            this.CancelButton = this.bCerrar;
            this.ClientSize = new System.Drawing.Size(464, 362);
            this.Controls.Add(this.LCantidadListado);
            this.Controls.Add(this.LCantidadFiguras);
            this.Controls.Add(this.label);
            this.Controls.Add(this.LEtiquetaListado);
            this.Controls.Add(this.bCerrar);
            this.Controls.Add(this.bPerimetro);
            this.Controls.Add(this.bArea);
            this.Controls.Add(this.lbFiguras);
            this.Controls.Add(this.panel1);
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(480, 400);
            this.MinimumSize = new System.Drawing.Size(480, 400);
            this.Name = "fPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Figuras";
            this.panel1.ResumeLayout(false);
            this.gbIngreso.ResumeLayout(false);
            this.gbIngreso.PerformLayout();
            this.gbFiguras.ResumeLayout(false);
            this.gbFiguras.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox gbIngreso;
        private System.Windows.Forms.GroupBox gbFiguras;
        private System.Windows.Forms.RadioButton rbRectangulo;
        private System.Windows.Forms.RadioButton rbTriangulo;
        private System.Windows.Forms.RadioButton rbCuadrado;
        private System.Windows.Forms.RadioButton rbCirculo;
        private System.Windows.Forms.Button bAgregar;
        private System.Windows.Forms.Label lDato1;
        private System.Windows.Forms.Label lDato3;
        private System.Windows.Forms.Label lDato2;
        private System.Windows.Forms.ListBox lbFiguras;
        private System.Windows.Forms.Button bArea;
        private System.Windows.Forms.Button bPerimetro;
        private System.Windows.Forms.Button bCerrar;
        private System.Windows.Forms.Label LEtiquetaListado;
        private System.Windows.Forms.Label label;
        private System.Windows.Forms.Label LCantidadFiguras;
        private System.Windows.Forms.Label LCantidadListado;
        private System.Windows.Forms.TextBox tDato3;
        private System.Windows.Forms.TextBox tDato2;
        private System.Windows.Forms.TextBox tDato1;
    }
}

