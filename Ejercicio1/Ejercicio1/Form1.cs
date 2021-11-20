#define KEY
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.Text = "Mouse Tester";
        }





        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {

            int x = e.X;
            int y = e.Y;



            if (sender is Button)
            {
                this.Text = string.Format("X: {0}, Y: {1}", x += ((Button)sender).Location.X, y += ((Button)sender).Location.Y);
            }
            else
            {

                this.Text = string.Format("X: {0}, Y: {1}", x, y);
            }


        }

        private void Form1_MouseLeave(object sender, EventArgs e)
        {
            this.Text = "Mouse Tester";
        }

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                button1.BackColor = Color.Aqua;
            }
            if (e.Button == MouseButtons.Right)
            {
                button2.BackColor = Color.Red;
            }

            if (e.Button == MouseButtons.Middle)
            {
                button1.BackColor = Color.Aqua;
                button2.BackColor = Color.Red;
            }
        }

        private void Form1_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                button1.BackColor = default;
            }
            if (e.Button == MouseButtons.Right)
            {
                button2.BackColor = default;
            }
            if (e.Button == MouseButtons.Middle)
            {
                button1.BackColor = default;
                button2.BackColor = default;
            }
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {

#if KEY
            if (e.KeyCode == Keys.Escape)
            {
                this.Text = "Mouse Tester";
            }
            else
            {

                this.Text = ""+e.KeyCode;

            }
#endif  
        }
        private void Form1_KeyPress(object sender, KeyPressEventArgs e)
        {
#if !KEY
            if (e.KeyChar == 27)
            {
                this.Text = "Mouse Tester";
            }
            else
            {
                this.Text = "" + e.KeyChar;
            }
#endif
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("¿Seguro que desea cerrar el programa?",
                "Mouse Tester",
                MessageBoxButtons.OKCancel, 
                MessageBoxIcon.Question) == DialogResult.Cancel)
            {
                e.Cancel = true;
            }
        }
    }
}
