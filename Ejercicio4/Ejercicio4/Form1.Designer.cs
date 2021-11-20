
namespace Ejercicio4
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.valor1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.suma = new System.Windows.Forms.RadioButton();
            this.resta = new System.Windows.Forms.RadioButton();
            this.multiplicacion = new System.Windows.Forms.RadioButton();
            this.division = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.valor2 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.operador = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.resultado = new System.Windows.Forms.Label();
            this.calcular = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // valor1
            // 
            this.valor1.Location = new System.Drawing.Point(56, 58);
            this.valor1.Margin = new System.Windows.Forms.Padding(2);
            this.valor1.Name = "valor1";
            this.valor1.Size = new System.Drawing.Size(70, 20);
            this.valor1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(58, 41);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Primer valor:";
            // 
            // suma
            // 
            this.suma.AutoSize = true;
            this.suma.Location = new System.Drawing.Point(8, 26);
            this.suma.Margin = new System.Windows.Forms.Padding(2);
            this.suma.Name = "suma";
            this.suma.Size = new System.Drawing.Size(52, 17);
            this.suma.TabIndex = 4;
            this.suma.TabStop = true;
            this.suma.Text = "Suma";
            this.suma.UseVisualStyleBackColor = true;
            this.suma.CheckedChanged += new System.EventHandler(this.grupoDeRadioBox);
            // 
            // resta
            // 
            this.resta.AutoSize = true;
            this.resta.Location = new System.Drawing.Point(8, 48);
            this.resta.Margin = new System.Windows.Forms.Padding(2);
            this.resta.Name = "resta";
            this.resta.Size = new System.Drawing.Size(53, 17);
            this.resta.TabIndex = 5;
            this.resta.TabStop = true;
            this.resta.Text = "Resta";
            this.resta.UseVisualStyleBackColor = true;
            this.resta.CheckedChanged += new System.EventHandler(this.grupoDeRadioBox);
            // 
            // multiplicacion
            // 
            this.multiplicacion.AutoSize = true;
            this.multiplicacion.Location = new System.Drawing.Point(71, 26);
            this.multiplicacion.Margin = new System.Windows.Forms.Padding(2);
            this.multiplicacion.Name = "multiplicacion";
            this.multiplicacion.Size = new System.Drawing.Size(89, 17);
            this.multiplicacion.TabIndex = 6;
            this.multiplicacion.TabStop = true;
            this.multiplicacion.Text = "Multiplicación";
            this.multiplicacion.UseVisualStyleBackColor = true;
            this.multiplicacion.CheckedChanged += new System.EventHandler(this.grupoDeRadioBox);
            // 
            // division
            // 
            this.division.AutoSize = true;
            this.division.Location = new System.Drawing.Point(71, 49);
            this.division.Margin = new System.Windows.Forms.Padding(2);
            this.division.Name = "division";
            this.division.Size = new System.Drawing.Size(62, 17);
            this.division.TabIndex = 7;
            this.division.TabStop = true;
            this.division.Text = "División";
            this.division.UseVisualStyleBackColor = true;
            this.division.CheckedChanged += new System.EventHandler(this.grupoDeRadioBox);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.multiplicacion);
            this.groupBox1.Controls.Add(this.division);
            this.groupBox1.Controls.Add(this.suma);
            this.groupBox1.Controls.Add(this.resta);
            this.groupBox1.Location = new System.Drawing.Point(52, 94);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(170, 89);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Operaciones";
            // 
            // valor2
            // 
            this.valor2.Location = new System.Drawing.Point(162, 58);
            this.valor2.Margin = new System.Windows.Forms.Padding(2);
            this.valor2.Name = "valor2";
            this.valor2.Size = new System.Drawing.Size(67, 20);
            this.valor2.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(160, 41);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Segundo valor:";
            // 
            // operador
            // 
            this.operador.AutoSize = true;
            this.operador.Location = new System.Drawing.Point(137, 60);
            this.operador.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.operador.Name = "operador";
            this.operador.Size = new System.Drawing.Size(0, 13);
            this.operador.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(232, 60);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(13, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "=";
            // 
            // resultado
            // 
            this.resultado.AutoSize = true;
            this.resultado.Location = new System.Drawing.Point(249, 60);
            this.resultado.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.resultado.Name = "resultado";
            this.resultado.Size = new System.Drawing.Size(13, 13);
            this.resultado.TabIndex = 11;
            this.resultado.Text = "0";
            // 
            // calcular
            // 
            this.calcular.Location = new System.Drawing.Point(235, 133);
            this.calcular.Margin = new System.Windows.Forms.Padding(2);
            this.calcular.Name = "calcular";
            this.calcular.Size = new System.Drawing.Size(56, 19);
            this.calcular.TabIndex = 12;
            this.calcular.Text = "Calcular";
            this.calcular.UseVisualStyleBackColor = true;
            this.calcular.Click += new System.EventHandler(this.calcular_Click);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(311, 222);
            this.Controls.Add(this.calcular);
            this.Controls.Add(this.resultado);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.operador);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.valor2);
            this.Controls.Add(this.valor1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox valor1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton suma;
        private System.Windows.Forms.RadioButton resta;
        private System.Windows.Forms.RadioButton multiplicacion;
        private System.Windows.Forms.RadioButton division;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox valor2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label operador;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label resultado;
        private System.Windows.Forms.Button calcular;
        private System.Windows.Forms.Timer timer1;
    }
}

