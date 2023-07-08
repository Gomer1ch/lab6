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
    public partial class FormTask2 : Form
    {
        public FormTask2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            label1.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            label1.Show();
        }

        private void FormTask2_Load(object sender, EventArgs e)
        {
            this.BackColor = Color.Lime;
            label1.Text = "Начало работы";
        }

        private void FromTask2_Closed(object sender, FormClosingEventArgs e)
        {
            Form1 newForm = new Form1();
            newForm.Show();
        }
    }
}
