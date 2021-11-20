
namespace Ejercicio5
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
            this.listOne = new System.Windows.Forms.ListBox();
            this.listMulti = new System.Windows.Forms.ListBox();
            this.anhadir = new System.Windows.Forms.Button();
            this.quitar = new System.Windows.Forms.Button();
            this.traspasar = new System.Windows.Forms.Button();
            this.traspasar2 = new System.Windows.Forms.Button();
            this.entradaDatos = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // listOne
            // 
            this.listOne.FormattingEnabled = true;
            this.listOne.Location = new System.Drawing.Point(132, 51);
            this.listOne.Name = "listOne";
            this.listOne.Size = new System.Drawing.Size(111, 160);
            this.listOne.TabIndex = 0;
            this.listOne.SelectedIndexChanged += new System.EventHandler(this.listOne_SelectedIndexChanged);
            this.listOne.MouseHover += new System.EventHandler(this.listOne_MouseHover);
            // 
            // listMulti
            // 
            this.listMulti.FormattingEnabled = true;
            this.listMulti.Location = new System.Drawing.Point(12, 51);
            this.listMulti.Name = "listMulti";
            this.listMulti.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.listMulti.Size = new System.Drawing.Size(111, 160);
            this.listMulti.TabIndex = 1;
            this.listMulti.SelectedIndexChanged += new System.EventHandler(this.listMulti_SelectedIndexChanged);
            // 
            // anhadir
            // 
            this.anhadir.Location = new System.Drawing.Point(321, 102);
            this.anhadir.Name = "anhadir";
            this.anhadir.Size = new System.Drawing.Size(75, 23);
            this.anhadir.TabIndex = 2;
            this.anhadir.Text = "Añadir";
            this.anhadir.UseVisualStyleBackColor = true;
            this.anhadir.Click += new System.EventHandler(this.anhadir_Click);
            // 
            // quitar
            // 
            this.quitar.Location = new System.Drawing.Point(321, 131);
            this.quitar.Name = "quitar";
            this.quitar.Size = new System.Drawing.Size(75, 23);
            this.quitar.TabIndex = 3;
            this.quitar.Text = "Quitar";
            this.quitar.UseVisualStyleBackColor = true;
            this.quitar.Click += new System.EventHandler(this.quitar_Click);
            // 
            // traspasar
            // 
            this.traspasar.Location = new System.Drawing.Point(321, 160);
            this.traspasar.Name = "traspasar";
            this.traspasar.Size = new System.Drawing.Size(75, 23);
            this.traspasar.TabIndex = 4;
            this.traspasar.Text = "1 >> 2";
            this.traspasar.UseVisualStyleBackColor = true;
            this.traspasar.Click += new System.EventHandler(this.traspasar_Click);
            // 
            // traspasar2
            // 
            this.traspasar2.Location = new System.Drawing.Point(321, 189);
            this.traspasar2.Name = "traspasar2";
            this.traspasar2.Size = new System.Drawing.Size(75, 23);
            this.traspasar2.TabIndex = 5;
            this.traspasar2.Text = "1 << 2";
            this.traspasar2.UseVisualStyleBackColor = true;
            this.traspasar2.Click += new System.EventHandler(this.traspasar2_Click);
            // 
            // entradaDatos
            // 
            this.entradaDatos.Location = new System.Drawing.Point(260, 51);
            this.entradaDatos.Name = "entradaDatos";
            this.entradaDatos.Size = new System.Drawing.Size(136, 20);
            this.entradaDatos.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Numero items: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(130, 7);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Indices: ";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AcceptButton = this.anhadir;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(441, 253);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.entradaDatos);
            this.Controls.Add(this.traspasar2);
            this.Controls.Add(this.traspasar);
            this.Controls.Add(this.quitar);
            this.Controls.Add(this.anhadir);
            this.Controls.Add(this.listMulti);
            this.Controls.Add(this.listOne);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listOne;
        private System.Windows.Forms.ListBox listMulti;
        private System.Windows.Forms.Button anhadir;
        private System.Windows.Forms.Button quitar;
        private System.Windows.Forms.Button traspasar;
        private System.Windows.Forms.Button traspasar2;
        private System.Windows.Forms.TextBox entradaDatos;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Timer timer1;
    }
}

