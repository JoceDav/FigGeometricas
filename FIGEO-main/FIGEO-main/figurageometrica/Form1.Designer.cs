
namespace figurageometrica
{
    partial class Form1
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.CALCULAR = new System.Windows.Forms.Button();
            this.LIMPIAR = new System.Windows.Forms.Button();
            this.EXPORTAR = new System.Windows.Forms.Button();
            this.DIBUJAR = new System.Windows.Forms.Button();
            this.INFORMACION = new System.Windows.Forms.Button();
            this.GUARDAR = new System.Windows.Forms.Button();
            this.CAJA_TEXTO = new System.Windows.Forms.TextBox();
            this.INGRESA = new System.Windows.Forms.Label();
            this.Esfera = new System.Windows.Forms.RadioButton();
            this.Prisma = new System.Windows.Forms.RadioButton();
            this.Cubo = new System.Windows.Forms.RadioButton();
            this.Circulo = new System.Windows.Forms.RadioButton();
            this.Poligonoirregular = new System.Windows.Forms.RadioButton();
            this.Poligonoregular = new System.Windows.Forms.RadioButton();
            this.Rectangulo = new System.Windows.Forms.RadioButton();
            this.Triangulo = new System.Windows.Forms.RadioButton();
            this.Cuadrado = new System.Windows.Forms.RadioButton();
            this.CONSTRUCTOR = new System.Windows.Forms.Label();
            this.INF = new System.Windows.Forms.RichTextBox();
            this.IMAGEN = new System.Windows.Forms.PictureBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.IMAGEN)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.groupBox1.Controls.Add(this.CALCULAR);
            this.groupBox1.Controls.Add(this.LIMPIAR);
            this.groupBox1.Controls.Add(this.EXPORTAR);
            this.groupBox1.Controls.Add(this.DIBUJAR);
            this.groupBox1.Controls.Add(this.INFORMACION);
            this.groupBox1.Controls.Add(this.GUARDAR);
            this.groupBox1.Controls.Add(this.CAJA_TEXTO);
            this.groupBox1.Controls.Add(this.INGRESA);
            this.groupBox1.Controls.Add(this.Esfera);
            this.groupBox1.Controls.Add(this.Prisma);
            this.groupBox1.Controls.Add(this.Cubo);
            this.groupBox1.Controls.Add(this.Circulo);
            this.groupBox1.Controls.Add(this.Poligonoirregular);
            this.groupBox1.Controls.Add(this.Poligonoregular);
            this.groupBox1.Controls.Add(this.Rectangulo);
            this.groupBox1.Controls.Add(this.Triangulo);
            this.groupBox1.Controls.Add(this.Cuadrado);
            this.groupBox1.Controls.Add(this.CONSTRUCTOR);
            this.groupBox1.Location = new System.Drawing.Point(9, 14);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(490, 214);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // CALCULAR
            // 
            this.CALCULAR.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.CALCULAR.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CALCULAR.Location = new System.Drawing.Point(411, 171);
            this.CALCULAR.Name = "CALCULAR";
            this.CALCULAR.Size = new System.Drawing.Size(72, 22);
            this.CALCULAR.TabIndex = 17;
            this.CALCULAR.Text = "CALCULAR";
            this.CALCULAR.UseVisualStyleBackColor = false;
            this.CALCULAR.Click += new System.EventHandler(this.CALCULAR_Click);
            // 
            // LIMPIAR
            // 
            this.LIMPIAR.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.LIMPIAR.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LIMPIAR.Location = new System.Drawing.Point(309, 171);
            this.LIMPIAR.Name = "LIMPIAR";
            this.LIMPIAR.Size = new System.Drawing.Size(96, 19);
            this.LIMPIAR.TabIndex = 16;
            this.LIMPIAR.Text = "LIMPIAR";
            this.LIMPIAR.UseVisualStyleBackColor = false;
            this.LIMPIAR.Click += new System.EventHandler(this.LIMPIAR_Click);
            // 
            // EXPORTAR
            // 
            this.EXPORTAR.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.EXPORTAR.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EXPORTAR.Location = new System.Drawing.Point(207, 170);
            this.EXPORTAR.Name = "EXPORTAR";
            this.EXPORTAR.Size = new System.Drawing.Size(96, 20);
            this.EXPORTAR.TabIndex = 15;
            this.EXPORTAR.Text = "EXPORTAR";
            this.EXPORTAR.UseVisualStyleBackColor = false;
            // 
            // DIBUJAR
            // 
            this.DIBUJAR.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.DIBUJAR.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DIBUJAR.Location = new System.Drawing.Point(105, 170);
            this.DIBUJAR.Name = "DIBUJAR";
            this.DIBUJAR.Size = new System.Drawing.Size(96, 20);
            this.DIBUJAR.TabIndex = 14;
            this.DIBUJAR.Text = "DIBUJAR";
            this.DIBUJAR.UseVisualStyleBackColor = false;
            // 
            // INFORMACION
            // 
            this.INFORMACION.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.INFORMACION.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.INFORMACION.Location = new System.Drawing.Point(3, 170);
            this.INFORMACION.Name = "INFORMACION";
            this.INFORMACION.Size = new System.Drawing.Size(96, 22);
            this.INFORMACION.TabIndex = 13;
            this.INFORMACION.Text = "INFORMACION";
            this.INFORMACION.UseVisualStyleBackColor = false;
            // 
            // GUARDAR
            // 
            this.GUARDAR.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.GUARDAR.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GUARDAR.Location = new System.Drawing.Point(411, 136);
            this.GUARDAR.Name = "GUARDAR";
            this.GUARDAR.Size = new System.Drawing.Size(73, 22);
            this.GUARDAR.TabIndex = 12;
            this.GUARDAR.Text = "GUARDAR";
            this.GUARDAR.UseVisualStyleBackColor = false;
            this.GUARDAR.Click += new System.EventHandler(this.GUARDAR_Click);
            // 
            // CAJA_TEXTO
            // 
            this.CAJA_TEXTO.Location = new System.Drawing.Point(311, 136);
            this.CAJA_TEXTO.Name = "CAJA_TEXTO";
            this.CAJA_TEXTO.Size = new System.Drawing.Size(84, 20);
            this.CAJA_TEXTO.TabIndex = 11;
            // 
            // INGRESA
            // 
            this.INGRESA.AutoSize = true;
            this.INGRESA.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.INGRESA.Location = new System.Drawing.Point(0, 137);
            this.INGRESA.Name = "INGRESA";
            this.INGRESA.Size = new System.Drawing.Size(307, 16);
            this.INGRESA.TabIndex = 10;
            this.INGRESA.Text = "INGRESA MEDIDA DEL LADO,ARISTA,RADIO,ETC";
            this.INGRESA.Click += new System.EventHandler(this.INGRESA_Click);
            // 
            // Esfera
            // 
            this.Esfera.AutoSize = true;
            this.Esfera.Location = new System.Drawing.Point(241, 85);
            this.Esfera.Name = "Esfera";
            this.Esfera.Size = new System.Drawing.Size(67, 17);
            this.Esfera.TabIndex = 9;
            this.Esfera.TabStop = true;
            this.Esfera.Text = "ESFERA";
            this.Esfera.UseVisualStyleBackColor = true;
            this.Esfera.CheckedChanged += new System.EventHandler(this.ESPERA_CheckedChanged);
            // 
            // Prisma
            // 
            this.Prisma.AutoSize = true;
            this.Prisma.Location = new System.Drawing.Point(407, 85);
            this.Prisma.Name = "Prisma";
            this.Prisma.Size = new System.Drawing.Size(66, 17);
            this.Prisma.TabIndex = 8;
            this.Prisma.TabStop = true;
            this.Prisma.Text = "PRISMA";
            this.Prisma.UseVisualStyleBackColor = true;
            this.Prisma.CheckedChanged += new System.EventHandler(this.radioButton8_CheckedChanged);
            // 
            // Cubo
            // 
            this.Cubo.AutoSize = true;
            this.Cubo.Location = new System.Drawing.Point(337, 85);
            this.Cubo.Name = "Cubo";
            this.Cubo.Size = new System.Drawing.Size(55, 17);
            this.Cubo.TabIndex = 7;
            this.Cubo.TabStop = true;
            this.Cubo.Text = "CUBO";
            this.Cubo.UseVisualStyleBackColor = true;
            this.Cubo.CheckedChanged += new System.EventHandler(this.radioButton7_CheckedChanged);
            // 
            // Circulo
            // 
            this.Circulo.AutoSize = true;
            this.Circulo.Location = new System.Drawing.Point(163, 85);
            this.Circulo.Name = "Circulo";
            this.Circulo.Size = new System.Drawing.Size(72, 17);
            this.Circulo.TabIndex = 6;
            this.Circulo.TabStop = true;
            this.Circulo.Text = "CIRCULO";
            this.Circulo.UseVisualStyleBackColor = true;
            // 
            // Poligonoirregular
            // 
            this.Poligonoirregular.AutoSize = true;
            this.Poligonoirregular.Location = new System.Drawing.Point(6, 85);
            this.Poligonoirregular.Name = "Poligonoirregular";
            this.Poligonoirregular.Size = new System.Drawing.Size(147, 17);
            this.Poligonoirregular.TabIndex = 5;
            this.Poligonoirregular.TabStop = true;
            this.Poligonoirregular.Text = "POLIGONO IRREGULAR";
            this.Poligonoirregular.UseVisualStyleBackColor = true;
            // 
            // Poligonoregular
            // 
            this.Poligonoregular.AutoSize = true;
            this.Poligonoregular.Location = new System.Drawing.Point(337, 52);
            this.Poligonoregular.Name = "Poligonoregular";
            this.Poligonoregular.Size = new System.Drawing.Size(136, 17);
            this.Poligonoregular.TabIndex = 4;
            this.Poligonoregular.TabStop = true;
            this.Poligonoregular.Text = "POLIGONO REGULAR";
            this.Poligonoregular.UseVisualStyleBackColor = true;
            this.Poligonoregular.CheckedChanged += new System.EventHandler(this.POLIGONOREGULAR_CheckedChanged);
            // 
            // Rectangulo
            // 
            this.Rectangulo.AutoSize = true;
            this.Rectangulo.Location = new System.Drawing.Point(219, 52);
            this.Rectangulo.Name = "Rectangulo";
            this.Rectangulo.Size = new System.Drawing.Size(99, 17);
            this.Rectangulo.TabIndex = 3;
            this.Rectangulo.TabStop = true;
            this.Rectangulo.Text = "RECTANGULO";
            this.Rectangulo.UseVisualStyleBackColor = true;
            // 
            // Triangulo
            // 
            this.Triangulo.AutoSize = true;
            this.Triangulo.Location = new System.Drawing.Point(105, 52);
            this.Triangulo.Name = "Triangulo";
            this.Triangulo.Size = new System.Drawing.Size(88, 17);
            this.Triangulo.TabIndex = 2;
            this.Triangulo.TabStop = true;
            this.Triangulo.Text = "TRIANGULO";
            this.Triangulo.UseVisualStyleBackColor = true;
            // 
            // Cuadrado
            // 
            this.Cuadrado.AutoSize = true;
            this.Cuadrado.Location = new System.Drawing.Point(6, 52);
            this.Cuadrado.Name = "Cuadrado";
            this.Cuadrado.Size = new System.Drawing.Size(86, 17);
            this.Cuadrado.TabIndex = 1;
            this.Cuadrado.TabStop = true;
            this.Cuadrado.Text = "CUADRADO";
            this.Cuadrado.UseVisualStyleBackColor = true;
            this.Cuadrado.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // CONSTRUCTOR
            // 
            this.CONSTRUCTOR.AutoSize = true;
            this.CONSTRUCTOR.BackColor = System.Drawing.Color.Transparent;
            this.CONSTRUCTOR.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CONSTRUCTOR.Location = new System.Drawing.Point(58, 16);
            this.CONSTRUCTOR.Name = "CONSTRUCTOR";
            this.CONSTRUCTOR.Size = new System.Drawing.Size(362, 19);
            this.CONSTRUCTOR.TabIndex = 0;
            this.CONSTRUCTOR.Text = "CONSTRUCTOR DE FIGURAS GEOMETRICAS";
            this.CONSTRUCTOR.Click += new System.EventHandler(this.CONSTRUCTOR_Click);
            // 
            // INF
            // 
            this.INF.Location = new System.Drawing.Point(250, 234);
            this.INF.Name = "INF";
            this.INF.Size = new System.Drawing.Size(249, 196);
            this.INF.TabIndex = 1;
            this.INF.Text = "";
            this.INF.TextChanged += new System.EventHandler(this.richTextBox1_TextChanged);
            // 
            // IMAGEN
            // 
            this.IMAGEN.Location = new System.Drawing.Point(9, 234);
            this.IMAGEN.Name = "IMAGEN";
            this.IMAGEN.Size = new System.Drawing.Size(235, 196);
            this.IMAGEN.TabIndex = 2;
            this.IMAGEN.TabStop = false;
            this.IMAGEN.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(522, 450);
            this.Controls.Add(this.IMAGEN);
            this.Controls.Add(this.INF);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.IMAGEN)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton Esfera;
        private System.Windows.Forms.RadioButton Prisma;
        private System.Windows.Forms.RadioButton Cubo;
        private System.Windows.Forms.RadioButton Circulo;
        private System.Windows.Forms.RadioButton Poligonoirregular;
        private System.Windows.Forms.RadioButton Poligonoregular;
        private System.Windows.Forms.RadioButton Rectangulo;
        private System.Windows.Forms.RadioButton Triangulo;
        private System.Windows.Forms.RadioButton Cuadrado;
        private System.Windows.Forms.Label CONSTRUCTOR;
        private System.Windows.Forms.Label INGRESA;
        private System.Windows.Forms.RichTextBox INF;
        private System.Windows.Forms.PictureBox IMAGEN;
        private System.Windows.Forms.Button CALCULAR;
        private System.Windows.Forms.Button LIMPIAR;
        private System.Windows.Forms.Button EXPORTAR;
        private System.Windows.Forms.Button DIBUJAR;
        private System.Windows.Forms.Button INFORMACION;
        private System.Windows.Forms.Button GUARDAR;
        private System.Windows.Forms.TextBox CAJA_TEXTO;
    }
}

