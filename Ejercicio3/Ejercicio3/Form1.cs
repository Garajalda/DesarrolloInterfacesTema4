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

namespace Ejercicio3
{
    public partial class Form1 : Form
    {
    
        OpenFileDialog abreFile;
        
        string nombre;
        Form2 f2;
        public Form1()
        {
            InitializeComponent();
            abreFile = new OpenFileDialog();
            nombre = "";
            

        }

        
        
        private void button1_Click(object sender, EventArgs e)
        {


            f2 = new Form2();
            this.abreFile.Title = "Selección de directorio para almacenar datos";
                this.abreFile.InitialDirectory = "C:\\Users\\gara\\Pictures";
                this.abreFile.Filter = "jpg(*.jpg)|*.jpg|png(*.png)|*.png|todos los archivos(*.*)|*.*";
                this.abreFile.ValidateNames = true;
                DialogResult result = this.abreFile.ShowDialog();
               
                this.nombre = abreFile.SafeFileName;
                this.Text = this.nombre = nombre == "" ? "no tiene nombre" : nombre;

           

            try
            {

                f2.pictureBox1.Image = new Bitmap(abreFile.FileName);
                f2.Text = nombre;

                if (checkBox1.Checked)
                {
                    if (result != DialogResult.Cancel)
                    {
                        f2.ShowDialog();

                    }

                }
                else
                {
                    if (result != DialogResult.Cancel)
                    {

                        f2.Show();
                    }
                    

                }
            }
            catch (System.ArgumentException)
            {
                f2.Close();
            }
            

            
          


        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("¿Quiere salir?",nombre = nombre == ""? "no tiene nombre" : nombre,MessageBoxButtons.OKCancel, MessageBoxIcon.Question)==DialogResult.Cancel)
            {
                e.Cancel = true;
            }
        }
    }
}
