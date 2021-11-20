using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            pantalla.Text += "*****************";
            pantalla.Text += "*************";
            pantalla.Text += "ALCATEL***********";
            pantalla.Text += "*****************";
            pantalla.Text += "*************************\n";


            int contadorLimite = 3;
            //formulario 2
            Form2 f = new Form2();
            bool contrasenaAceptada = false;
            bool numeroIntentos = false;
            DialogResult res = f.ShowDialog();

            switch (res)
            {
                case DialogResult.OK:
                    do
                    {
                        if (f.textBox1.Text == "123")
                        {
                            MessageBox.Show("Contraseña Aceptada", "Contraseña", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            contrasenaAceptada = true;
                        }
                        else
                        {
                            
                            MessageBox.Show("Contraseña Invalida, numero de intentos " + contadorLimite, "Contraseña", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            if (contadorLimite != 0)
                            {

                                f.ShowDialog();
                            }
                            
                            contadorLimite--;

                            if (contadorLimite == 0)
                            {
                                numeroIntentos = true;
                                MessageBox.Show("Numero de intentos superados.");
                                this.Close();
                            }


                        }
                    } while (contadorLimite != 0 && !contrasenaAceptada && !numeroIntentos);
                    break;
                case DialogResult.Cancel:
                    MessageBox.Show("Operacion cancelada", "Contraseña", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    this.Close();
                    break;
            }
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            
            
            switch (e.ClickedItem.ToString())
            {
                case "Acerca de...":
                    MessageBox.Show("Información App: 1.0.0\nAuthor: Gara J", "Acerda de...", MessageBoxButtons.OK, MessageBoxIcon.Information);
                break;

            }
            
        }

        bool apretadoReset = false;
        bool apretado = false;
        private void botones(object sender, EventArgs e)
        {

            if (((Button)sender).Focused)
            {
                if (sender == btnReset)
                {
                    pantalla.Text = "";
                }
                else
                {
                    pantalla.Text += ((Button)sender).Text;
                }
            }
        }

        
        private void botones_MouseMove(object sender, MouseEventArgs e)
        {
            if (!apretado)
            {
                ((Button)sender).BackColor = Color.DarkViolet;
            }
        }

        private void botones_MouseLeave(object sender, EventArgs e)
        {
            if (!apretado)
            {
                ((Button)sender).BackColor = DefaultBackColor;
            }
        }

        public void call(object sender)
        {
            apretado = true;
            if (sender == btnReset)
            {
                apretadoReset = true;
            }
            if (!apretadoReset)
            {
                ((Button)sender).BackColor = Color.Red;
            }
            else
            {
                foreach (Control ce in this.Controls)
                {
                    if (ce is Button)
                    {
                        ((Button)ce).BackColor = DefaultBackColor;
                        apretado = false;
                        apretadoReset = false;
                    }
                }
            }

        }

        private void button2_MouseDown(object sender, MouseEventArgs e)
        {
            call(sender);
        }

      

        private void ItemsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            switch (((ToolStripItem)sender).Text)
            {
                case "Grabar número":
                    SaveFileDialog file = new SaveFileDialog();
                    file.Title = "Guardar numero";
                    file.InitialDirectory = "C:\\";
                    file.ValidateNames = true;
                    file.ShowDialog();
                    StreamWriter s;
                    try
                    {

                        s = new StreamWriter(file.FileName);
                        if (pantalla.Text != "")
                        {
                            s.Write(pantalla.Text);
                        }
                        else
                        {
                            MessageBox.Show("Operacion no valida", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        s.Close();
                    }
                    catch (ArgumentException)
                    {
            
                    }

                break;
                case "Reset":
                    call(btnReset);
                    pantalla.Text = "";
                break;
                case "Separador":
                    pantalla.Text += "\n";
                break;
                case "Salir":
                    this.Close();
                    MessageBox.Show("");
                break;
            }
            
        }
    }
}
