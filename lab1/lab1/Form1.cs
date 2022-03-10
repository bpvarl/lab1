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
    public partial class Form1 : Form
    {
        String[] imgList = new String[]
            {"0.jpg","1.jpeg","2.jpg","3.jpg","4.jpg","5.jpg","6.jpg","7.jpg","8.jpg","9.jpg", };
        int index = 0;
        public Form1()
        {
            InitializeComponent();
            pictureBox2.Load("../../../pictures/" + imgList[0]);
            pictureBox3.Load("../../../pictures/" + imgList[1]);
            pictureBox4.Load("../../../pictures/" + imgList[2]);
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form adminForm = new Form2();
            adminForm.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            index = index - 1;
            if (index + 3 < imgList.Length) index = 0;
            pictureBox2.Load("../../../pictures/" + imgList[index+0]);
            pictureBox3.Load("../../../pictures/" + imgList[index+1]);
            pictureBox4.Load("../../../pictures/" + imgList[index+2]);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            index = index + 1;
            if (index + 3 > imgList.Length) index = 0;
            pictureBox2.Load("../../../pictures/" + imgList[index+0]);
            pictureBox3.Load("../../../pictures/" + imgList[index+1]);
            pictureBox4.Load("../../../pictures/" + imgList[index+2]);
        }
    }
}
