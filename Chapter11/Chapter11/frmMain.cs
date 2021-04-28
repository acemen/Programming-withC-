using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Chapter11
{ 
    public partial class frmMain : Form
    {
    const int MALE = 1;
    const int FEMALE = 0;
    const int MUSHROOMS = 0;
    const int OLIVES = 1;
    const int SAUSAGE = 2;
    const int EXTRACHEESE = 3;
    public frmMain()
        {
            InitializeComponent();
            rbFemale.Checked = true;
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
           
        }

        private void frmMain_Load(object sender, EventArgs e)
        {

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {
         
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int choice;
            int[] toppings = new int[4];

            if (rbMale.Checked == true)
            {
                choice = MALE;
            }
            else
            {
                choice = FEMALE;
            }

            Array.Clear(toppings, 0, toppings.Length);
            if (ckbMushroom.Checked == true)
            {
                toppings[MUSHROOMS] = 1;
            }
            if (ckbOlives.Checked == true)
            {
                toppings[OLIVES] = 1;
            }
            if (ckbSausage.Checked == true)
            {
                toppings[SAUSAGE] = 1;
            }
            if (ckbExtraCheese.Checked == true)
            {
                toppings[EXTRACHEESE] = 1;
            }

            
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
