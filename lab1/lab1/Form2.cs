using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab1
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form adminForm = new Form3();
            adminForm.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Form adminForm = new Form1();
            adminForm.Show();
        }
    }
}
