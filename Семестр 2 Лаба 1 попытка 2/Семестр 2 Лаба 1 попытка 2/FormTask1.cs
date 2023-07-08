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
    public partial class FormTask1 : Form
    {
        public FormTask1()
        {
            InitializeComponent();
            int width = this.Width, height = this.Height;
            panel1.Width = width / 2;
            panel2.Width = width / 2;
            panel1.Height = height - 24;
            panel2.Height = height - 24;
            panel1.Location = new Point(0, 24);
            panel2.Location = new Point(width / 2, 24);
            StreamWriter file = new StreamWriter("Painting.txt");
            file.Close();
        }
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Application.Exit();
            this.Close();
        }

        private void inputColorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormInputColor newFormIC = new FormInputColor();
            newFormIC.Show();
        }

        private void changeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int R = 0, G = 0, B = 0, left = 0, right = 0;
            string line = "";
            StreamReader file = new StreamReader("Painting.txt");
            while ((line = file.ReadLine()) != null)
            {
                string[] Letters = line.Split(',');
                left = Convert.ToInt32(Letters[0]);
                right = Convert.ToInt32(Letters[1]);
                R = Convert.ToInt32(Letters[2]);
                G = Convert.ToInt32(Letters[3]);
                B = Convert.ToInt32(Letters[4]);
            }
            file.Close();
            if(left == 1) panel1.BackColor = Color.FromArgb(R, G, B);
            if(right == 1) panel2.BackColor = Color.FromArgb(R, G, B);
        }

        private void FormTask1Closed(object sender, FormClosingEventArgs e)
        {
            Form1 newForm = new Form1();
            newForm.Show();
        }

        private void helpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormTask1Help formTask1Help = new FormTask1Help();
            formTask1Help.Show();
        }
    }
}
