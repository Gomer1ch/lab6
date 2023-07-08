using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Семестр_2_Лаба_1_попытка_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FormTask1 newFormT1 = new FormTask1();
            newFormT1.Show();
            this.Hide();
        }

        private void Form1Closed(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FormTask2 newFormT2 = new FormTask2();
            newFormT2.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            FormTask3 newFromT3 = new FormTask3();
            newFromT3.Show();
            this.Hide();
        }
    }
}
