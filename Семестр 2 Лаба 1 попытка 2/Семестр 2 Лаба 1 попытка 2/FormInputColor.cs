using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Семестр_2_Лаба_1_попытка_2
{
    public partial class FormInputColor : Form
    {
        int R = 0, G = 0, B = 0, left = 0, right = 0;
        public FormInputColor()
        {
            InitializeComponent();
        }

        private void textbox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if (!(Char.IsDigit(number) || number == 8))
            {
                e.Handled = true;
            }
            if (e.KeyChar == (char)Keys.Enter) 
            {
                try
                {
                    R = Convert.ToInt32(textBox1.Text)%256;
                    textBox1.Text = ""+R;
                }
                catch { R = 0; textBox1.Text = "" + R; }
                panel1.BackColor = Color.FromArgb(R, G, B);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (checkBox1.Checked) left = 1;
            else { left = 0; }
            if (checkBox2.Checked) right = 1;
            else { right = 0; }
            StreamWriter file = new StreamWriter("Painting.txt");
            file.WriteLine("" + left + "," + right + "," + R + "," + G + "," + B);
            file.Close();
            this.Close();
        }

        private void textbox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if (!(Char.IsDigit(number) || number == 8))
            {
                e.Handled = true;
            }
            if (e.KeyChar == (char)Keys.Enter)
            {
                try
                {
                    G = Convert.ToInt32(textBox2.Text) % 256;
                    textBox2.Text = "" + G;
                }
                catch { G = 0; textBox2.Text = "" + G; }
                panel1.BackColor = Color.FromArgb(R, G, B);
            }
        }

        private void textbox3_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if (!(Char.IsDigit(number) || number == 8))
            {
                e.Handled = true;
            }
            if (e.KeyChar == (char)Keys.Enter)
            {
                try
                {
                    B = Convert.ToInt32(textBox3.Text) % 256;
                    textBox3.Text = "" + B;
                }
                catch { B = 0; textBox3.Text = "" + B; }
                panel1.BackColor = Color.FromArgb(R, G, B);
            }
        }
    }
}
