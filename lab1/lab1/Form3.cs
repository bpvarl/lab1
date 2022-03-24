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
    public partial class Form3 : Form
    {
        Team[] teams = new Team[5];
        String[] logo = new String[]
            {"1.jpg","2.jpg","3.jpg","4.jpg","5.jpg" };
        public Form3()
        {
            Team team = new Team();
            team.setAll(1, "Miami Heat", "MIA", "1.jpg");
          
            teams[0] = team;

            team.setAll(2, "Orlando Magic", "ORL", "2.jpg");

            teams[1] = team;
            

            team.setAll(3, "Atlanta Hawks", "ATL", " 3.jpg");

            teams[2] = team;


            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            

        }

        private void tableLayoutPanel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel31_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button60_Click(object sender, EventArgs e)
        {

        }

        private void panel16_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button61_Click(object sender, EventArgs e)
        {
            Team[] teams = new Team[5];
            for (int i = 0; i < 5; i++)
                this.Controls["button" + i].Text = teams[i].name;
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void button51_Click(object sender, EventArgs e)
        {
            Team[] teams = new Team[5];
            for (int i = 0; i < 5; i++)
                this.Controls["button51" + i].Text = teams[i].name;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Form adminForm = new Form2();
            adminForm.Show();
        }

        private void button26_Click(object sender, EventArgs e)
        {
            Team[] teams = new Team[5];
            for (int i = 5; i < 10; i++)
                this.Controls["button26" + i].Text = teams[i].name;
        }
    }
}
