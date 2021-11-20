using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio2
{
    public partial class Form1 : Form
    {
        ToolTip tool = new ToolTip();
        public Form1()
        {
            InitializeComponent();
            
            button4.Hide();
            button1.Tag = Color.Red;
            button2.Tag = Color.Green;
            button3.Tag = Color.Blue;
            button4.Tag = Color.Blue;


            tool.SetToolTip(this.textBox1, "Componente color rojo");
            tool.SetToolTip(this.textBox2, "Componente color verde");
            tool.SetToolTip(this.textBox3, "Componente color azul");
            tool.SetToolTip(this.textBox4, "Carga una imagen al pasarle URL");

        }
        
        

        public void mensajeSalir()
        {
            if (MessageBox.Show("Seguro que desea salir?", "", MessageBoxButtons.OKCancel, MessageBoxIcon.None) == DialogResult.OK)
            {

                this.Close();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            mensajeSalir();
        }

       

        bool colorNoValido = false;
        public int tryCatch(string recibeTextBox)
        {
            
            try
            {
                int numRecibido = int.Parse(recibeTextBox);
                
                    colorNoValido = false;
                    return numRecibido;

            }
            catch (System.FormatException)
            {
                colorNoValido = true;
            }
            catch (System.OverflowException)
            {
                colorNoValido = true;
                
            }
            return default;

        }
        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox1.Text=="" || textBox2.Text=="" || textBox3.Text=="")
            {
                colorNoValido = true;
            }
            else
            {
                int r = tryCatch(textBox1.Text);

                int g = tryCatch(textBox2.Text);
                int b = tryCatch(textBox3.Text);

                try
                {
                    this.BackgroundImage = default;
                    button4.Hide();
                    button3.Show();
                    this.BackColor = Color.FromArgb(r,g,b);
                }
                catch (System.ArgumentException)
                {
                    colorNoValido = true;
                }

            }
            if (colorNoValido)
            {
                this.BackColor = default;
            }
            



        }

        void enterTextBoxesColor(Object sender, EventArgs e)
        {

            this.AcceptButton = button2;
            
        }

        void enterTextBoxesImagen(Object sender, EventArgs e)
        {
                this.AcceptButton = button3;
        }

        private void button3_Click(object sender, EventArgs e)
        {

            try
            {

                this.BackgroundImage = new Bitmap(@textBox4.Text);
                button3.Hide();
                button4.Show();

            }
            catch (System.ArgumentException)
            {
                textBox4.Text = "Imagen No Valida";
                
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.BackgroundImage = default;
            button4.Hide();
            button3.Show();
        }


        void grupoBotonesEntra(object sender,EventArgs e)
        {
            ((Button)sender).BackColor = (Color)((Button)sender).Tag;
        }
        void grupoBotonesSale(object sender,EventArgs e)
        {
            ((Button)sender).BackColor = default;
        }

       
    }
}
