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
    public partial class FormTask3 : Form
    {
        string[] list = { "Label: ", "Button: ", "RadioButton: ", "CheckBox: " };
        int[,] mas = { { 0, 0, 0, 0 }, { 0, 0, 0, 0 } };
        int mode;
        void label(Point pos, int action)
        {
            Label mylab = new Label();
            mylab.Text = "Label " + (mas[0, 0] + mas[1, 0]) + " (" + pos.X + ", " + pos.Y + ")";
            mylab.Location = new Point(pos.X, pos.Y);
            mylab.AutoSize = true;
            mylab.Font = new Font("Calibri", 12);
            mylab.ForeColor = Color.Green;
            if (action == 1) this.Controls.Add(mylab);
            else { panel1.Controls.Add(mylab); }
        }
        void button(Point pos, int action)
        {
            Button mylab = new Button();
            mylab.Text = "Button " + (mas[0, 1] + mas[1, 1]) + " (" + pos.X + ", " + pos.Y + ")";
            mylab.Location = new Point(pos.X, pos.Y);
            mylab.AutoSize = true;
            mylab.Font = new Font("Calibri", 12);
            mylab.ForeColor = Color.Orange;
            if (action == 1) this.Controls.Add(mylab);
            else { panel1.Controls.Add(mylab); }
        }
        void RadioButton(Point pos, int action)
        {
            RadioButton mylab = new RadioButton();
            mylab.Text = "Radiobutton " + (mas[0, 2] + mas[1, 2]) + " (" + pos.X + ", " + pos.Y + ")";
            mylab.Location = new Point(pos.X, pos.Y);
            mylab.AutoSize = true;
            mylab.Font = new Font("Calibri", 12);
            mylab.ForeColor = Color.Red;
            if (action == 1) this.Controls.Add(mylab);
            else { panel1.Controls.Add(mylab); }
        }
        void CheckBox(Point pos, int action)
        {
            CheckBox mylab = new CheckBox();
            mylab.Text = "CheckBox " + (mas[0, 3] + mas[1, 3]) + " (" + pos.X + ", " + pos.Y + ")";
            mylab.Location = new Point(pos.X, pos.Y);
            mylab.AutoSize = true;
            mylab.Font = new Font("Calibri", 12);
            mylab.ForeColor = Color.Blue;
            if (action == 1) this.Controls.Add(mylab);
            else { panel1.Controls.Add(mylab); }
        }
        void Spawn(Point pos, int This)
        {
            Random rnd = new Random();
            int a=0;
            switch (mode)
            {
                case 1:
                    a = 1;
                    break;
                case 2:
                    a = 2;
                    break;
                case 3:
                    a = 3;
                    break;
                case 4:
                    a = 4;
                    break;
                case 5:
                    a = rnd.Next(4)+1;;
                    break;
            }
             
            switch (a)
            {
                case 1:
                    label(pos, This);
                    mas[This - 1, 0] += 1;
                    break;
                case 2:
                    button(pos, This);
                    mas[This - 1, 1] += 1;
                    break;
                case 3:
                    RadioButton(pos, This);
                    mas[This - 1, 2] += 1;
                    break;
                case 4:
                    CheckBox(pos, This);
                    mas[This - 1, 3] += 1;
                    break;
            }
            listBox1.Items.Clear();
            listBox1.Items.Add("FORM");
            for (int j = 0; j < 2; j++)
            {
                if (j == 1) { listBox1.Items.Add(""); listBox1.Items.Add("PANEL"); }
                for(int i=0; i<4; i++)
                {
                    listBox1.Items.Add("" + list[i] + mas[j, i]);
                }
            }
        }
        public FormTask3()
        {
            InitializeComponent();
            mode = 5;
        }

        private void FormTask3_MouseDown(object sender, MouseEventArgs e)
        {
            Point pos = e.Location;
            Spawn(pos, 1);
        }

        private void Panel_MouseDown(object sender, MouseEventArgs e)
        {
            Point pos = e.Location;
            Spawn(pos, 2);
        }

        private void FormTask3_Closed(object sender, FormClosedEventArgs e)
        {
            Form1 newForm = new Form1();
            newForm.Show();
        }

        private void lableToolStripMenuItem_Click(object sender, EventArgs e)
        {
            mode = 1;
            lableToolStripMenuItem.BackColor = Color.Lime;
            buttonToolStripMenuItem.BackColor = Color.FromArgb(240, 240, 240);
            radioButtonToolStripMenuItem.BackColor = Color.FromArgb(240, 240, 240);
            checkBoxToolStripMenuItem.BackColor = Color.FromArgb(240, 240, 240);
            randomToolStripMenuItem.BackColor = Color.FromArgb(240, 240, 240);
        }

        private void buttonToolStripMenuItem_Click(object sender, EventArgs e)
        {
            mode = 2;
            lableToolStripMenuItem.BackColor = Color.FromArgb(240, 240, 240);
            buttonToolStripMenuItem.BackColor = Color.Lime;
            radioButtonToolStripMenuItem.BackColor = Color.FromArgb(240, 240, 240);
            checkBoxToolStripMenuItem.BackColor = Color.FromArgb(240, 240, 240);
            randomToolStripMenuItem.BackColor = Color.FromArgb(240, 240, 240);
        }

        private void radioButtonToolStripMenuItem_Click(object sender, EventArgs e)
        {
            mode = 3;
            lableToolStripMenuItem.BackColor = Color.FromArgb(240, 240, 240);
            buttonToolStripMenuItem.BackColor = Color.FromArgb(240, 240, 240);
            radioButtonToolStripMenuItem.BackColor = Color.Lime;
            checkBoxToolStripMenuItem.BackColor = Color.FromArgb(240, 240, 240);
            randomToolStripMenuItem.BackColor = Color.FromArgb(240, 240, 240);
        }

        private void checkBoxToolStripMenuItem_Click(object sender, EventArgs e)
        {
            mode = 4;
            lableToolStripMenuItem.BackColor = Color.FromArgb(240, 240, 240);
            buttonToolStripMenuItem.BackColor = Color.FromArgb(240, 240, 240);
            radioButtonToolStripMenuItem.BackColor = Color.FromArgb(240, 240, 240);
            checkBoxToolStripMenuItem.BackColor = Color.Lime;
            randomToolStripMenuItem.BackColor = Color.FromArgb(240, 240, 240);
        }

        private void randomToolStripMenuItem_Click(object sender, EventArgs e)
        {
            mode = 5;
            lableToolStripMenuItem.BackColor = Color.FromArgb(240, 240, 240);
            buttonToolStripMenuItem.BackColor = Color.FromArgb(240, 240, 240);
            radioButtonToolStripMenuItem.BackColor = Color.FromArgb(240, 240, 240);
            checkBoxToolStripMenuItem.BackColor = Color.FromArgb(240, 240, 240);
            randomToolStripMenuItem.BackColor = Color.Lime;
        }
    }
}
