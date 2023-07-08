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
    public partial class FormTask1Help : Form
    {
        public FormTask1Help()
        {
            InitializeComponent();
            string line = "";
            StreamReader file = new StreamReader("Help.txt");
            listBox1.Items.Clear();
            while ((line = file.ReadLine()) != null)
            {
                listBox1.Items.Add(line);
            }
        }
    }
}
