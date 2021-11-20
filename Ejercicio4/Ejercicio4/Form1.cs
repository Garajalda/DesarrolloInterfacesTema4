using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio4
{
    public partial class Form1 : Form
    {
        delegate double Operation();
        Hashtable operaciones = new Hashtable();
        int contador = 0;
        public Form1()
        {
            InitializeComponent();

            suma.Tag = "+";
            resta.Tag = "-";
            division.Tag = "/";
            multiplicacion.Tag = "*";

            
            try
            {


                operaciones.Add("Suma", (Operation)(() => parse(this.valor1.Text) + parse(this.valor2.Text)));
                operaciones.Add("Resta", (Operation)(() => parse(this.valor1.Text) - parse(this.valor2.Text)));
                operaciones.Add("Multiplicación", (Operation)(() => parse(this.valor1.Text) * parse(this.valor2.Text)));
                operaciones.Add("División", (Operation)(() => parse(this.valor1.Text) / parse(this.valor2.Text)));
            }
            catch (Exception)
            {

            }


            timer1.Start();
            timer1.Interval = 900;


            var timespan = TimeSpan.FromSeconds(contador);
            this.Text = string.Format(timespan.ToString(@"mm\:ss"));


        }

        public double parse(string valor)
        {

            double num;
            bool res = double.TryParse(valor, out num);
            if (res)
            {
                return num;
            }
            else
            {
                return 0;
            }

        }

        string var = "";
        
        private void grupoDeRadioBox(object sender, EventArgs e)
        {
            
            var = ((RadioButton)sender).Text;
            this.operador.Text = (string)((RadioButton)sender).Tag;

        }


        private void calcular_Click(object sender, EventArgs e)
        {
            
            if ((Operation)operaciones[var] != null)
            {
                Operation MiFuncion = (Operation)operaciones[var];
                this.resultado.Text = "" + MiFuncion();

            }
           
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            contador++;
            var timespan = TimeSpan.FromSeconds(contador);
            this.Text = string.Format(timespan.ToString(@"mm\:ss"));
        }
    }
}
