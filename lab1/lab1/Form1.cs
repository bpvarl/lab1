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
        country1[] countries = new country1[5];
        public Form1()
        {
            InitializeComponent();
            pictureBox2.Load("../../../pictures/" + imgList[0]);
            pictureBox3.Load("../../../pictures/" + imgList[1]);
            pictureBox4.Load("../../../pictures/" + imgList[2]);
            country1 country = new country1();
           
            country.setCountryCode("ARG");
            country.setCountryName("Argentina");
            countries[0] = country;

            country.setCountryCode("AT");
            country.setCountryName("Austria");
            countries[1] = country;

            country.setCountryCode("AUS");
            country.setCountryName("Australia");
            countries[2] = country;

            country.setCountryCode("BI");
            country.setCountryName("Bosnia");
            countries[3] = country;

            country.setCountryCode("BIH");
            country.setCountryName("Bosnia Herzegovina");
            countries[4] = country;
            
            country.setCountryCode("BR");
            country.setCountryName("Brazil");
            countries[5] = country;
            
            country.setCountryCode("CA ");
            country.setCountryName("Canada");
            countries[6] = country;

            country.setCountryCode("CG ");
            country.setCountryName("Congo");
            countries[7] = country;
            
            country.setCountryCode("CH ");
            country.setCountryName("Switzerland");
            countries[8] = country;

            country.setCountryCode("CM ");
            country.setCountryName("Cameroon");
            countries[9] = country;

            country.setCountryCode("COD ");
            country.setCountryName("Democratic Republic of Congo");
            countries[10] = country;

            country.setCountryCode("DE ");
            country.setCountryName("Germany");
            countries[11] = country;

            country.setCountryCode("DO ");
            country.setCountryName("The Dominican Republic");
            countries[12] = country;

            country.setCountryCode("ES ");
            country.setCountryName("Spain");
            countries[13] = country;

            country.setCountryCode("FR ");
            country.setCountryName("France");
            countries[14] = country;

            country.setCountryCode("GE");
            country.setCountryName("Georgia");
            countries[15] = country;

            country.setCountryCode("GR");
            country.setCountryName("Greece");
            countries[16] = country;

            country.setCountryCode("HRV");
            country.setCountryName("Croatia");
            countries[17] = country;

            country.setCountryCode("HT");
            country.setCountryName("Haiti");
            countries[18] = country;
            
            country.setCountryCode("IL");
            country.setCountryName("Israel");
            countries[19] = country;

            country.setCountryCode("IT ");
            country.setCountryName("Italy");
            countries[20] = country;

            country.setCountryCode("LT ");
            country.setCountryName("Lithuania");
            countries[21] = country;

            country.setCountryCode("LV ");
            country.setCountryName("Latvia");
            countries[22] = country;

            country.setCountryCode("MLI");
            country.setCountryName("Mali");
            countries[23] = country;

            country.setCountryCode("MNE");
            country.setCountryName("Montenegro");
            countries[24] = country;

            country.setCountryCode("NGA");
            country.setCountryName("Nigeria");
            countries[25] = country;

            country.setCountryCode("NZ ");
            country.setCountryName("New Zealand");
            countries[26] = country;

            country.setCountryCode("PUR");
            country.setCountryName("Puerto Rico");
            countries[27] = country;

            country.setCountryCode("RU ");
            country.setCountryName("Russia");
            countries[28] = country;

            country.setCountryCode("SEN");
            country.setCountryName("Senegal");
            countries[29] = country;

            country.setCountryCode("SI ");
            country.setCountryName("Slovenia");
            countries[30] = country;

            country.setCountryCode("SRB");
            country.setCountryName("Serbia");
            countries[31] = country;

            country.setCountryCode("SSD");
            country.setCountryName("South Sudan");
            countries[32] = country;

            country.setCountryCode("TN ");
            country.setCountryName("Tunisia");
            countries[33] = country;

            country.setCountryCode("TR ");
            country.setCountryName("Turkey");
            countries[34] = country;

            country.setCountryCode("UA ");
            country.setCountryName("Ukraine");
            countries[35] = country;

            country.setCountryCode("US ");
            country.setCountryName("America");
            countries[36] = country;

            country.setCountryCode("");
            country.setCountryName("");
            countries[37] = country;
  
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
            if (index - 3 < 0) index =imgList.Length -3;
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
