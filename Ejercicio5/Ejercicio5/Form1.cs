using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio5
{
    public partial class Form1 : Form
    {
        int cont = 0;
 
        ToolTip tip1 = new ToolTip();
       
        public Form1()
        {
            InitializeComponent();
            
            timer1.Start();
            timer1.Interval=200;
       
            tip1.SetToolTip(this.label1, "indices");
            tip1.SetToolTip(this.listMulti, "Seleccion multiple");
            tip1.SetToolTip(this.entradaDatos, "Entrada datos");


        }



        bool comprobacionaVacio(string s)
        {
            if (entradaDatos.Text == "")
            {
                MessageBox.Show("Datos no validos.");
                return true;
            }
            else
            {
                return false;
            }
        }
       
        private void anhadir_Click(object sender, EventArgs e)
        {

            if (!comprobacionaVacio(entradaDatos.Text))
            {
                
                listMulti.Items.Add(entradaDatos.Text);

                entradaDatos.Text = "";
                
            }


            label1.Text = string.Format("Numero de items: {0}", listMulti.Items.Count.ToString());

        }

        private void quitar_Click(object sender, EventArgs e)
        {
            
            
            if (listMulti.SelectedItems.Count > 0)
            {
                    
                for (int i = listMulti.SelectedIndices.Count-1; i >-1 ; i--)
                {
                    listMulti.Items.RemoveAt(listMulti.SelectedIndices[i]);
                }

            }
            else
            {
                MessageBox.Show("elemento noseleccionado");
            }
            label1.Text = string.Format("Numero de items: {0}", listMulti.Items.Count.ToString());

        }

        private void traspasar_Click(object sender, EventArgs e)
        {
            
                if (listMulti.Items.Count > 0)
                {
                    for(int i = listMulti.SelectedIndices.Count-1; i > -1; i--)
                    {

                        listOne.Items.Insert(0,listMulti.SelectedItems[i]);
                        listMulti.Items.RemoveAt(listMulti.SelectedIndices[i]);

                    }
                }
        
        }


      

        private void listMulti_SelectedIndexChanged(object sender, EventArgs e)
        {

            string indices = "Indices listMulti: ";
           
            for (int i = 0; i < listMulti.SelectedIndices.Count; i++)
            {
                indices += listMulti.SelectedIndices[i]+" ";
            }
            label2.Text = indices;
            
        }


        string espacios = "";
        bool empieza = true;
        bool cambia = false;
        static string titulo = "titulo dinamicoxD";
        int longitud = titulo.Length - 1;
        private void timer1_Tick(object sender, EventArgs e)
        {
            if (!cambia)
            {
                this.Icon = Properties.Resources.bonfire_4386;
                cambia = true;
            }
            else
            {
                this.Icon = Properties.Resources.icon2;
                cambia = false;
            }


            if (cont == 100)
            {
                cont = 0;
                empieza = true;
                longitud = titulo.Length-1;
                
            }
            else
            {

                if (!empieza)
                {
                    espacios += " ";
                }
                else
                {
                    espacios = "";
                }
                this.Text = espacios+titulo.Substring(longitud);
                if (empieza)
                {
                    longitud--;
                    if (longitud < 0)
                    {
                        empieza = false;
                        longitud = 0;
                    }
                   
                }

            }

            cont++;

        }

        private void listOne_SelectedIndexChanged(object sender, EventArgs e)
        {
            string indices = "Indices listOne: ";
            indices += listOne.SelectedIndex;
            label2.Text = indices;
        }

        private void traspasar2_Click(object sender, EventArgs e)
        {
       
            if (listOne.SelectedIndices.Count ==1)
            {
                listMulti.Items.Insert(0,listOne.SelectedItem);
                listOne.Items.RemoveAt(listOne.SelectedIndex);
            }

        }

        private void listOne_MouseHover(object sender, EventArgs e)
        {
            tip1.SetToolTip(this.listOne, listOne.Items.Count.ToString());
        }
    }
}
