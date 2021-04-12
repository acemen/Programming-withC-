﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Chapter03Program01
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {

        }
        
        private void btnCalc_Click(object sender, EventArgs e)
        {
            bool flag;
            int operand1;//, which is explained in a later section of this chapter)
            int operand2;
            int answer;
            // Input Step
            // Check first input...
            flag = int.TryParse(txtOperand1.Text, out operand1);
            if (flag == false)
            {
                MessageBox.Show("Enter a whole number", "Input Error");
                txtOperand1.Focus();
                return;
            }
            // Check second input...
            flag = int.TryParse(txtOperand2.Text, out operand2);
            if (flag == false)
            {
                MessageBox.Show("Enter a whole number", "Input Error");
                txtOperand2.Focus();
                return;
            }
            // Process Step
            answer = (2 + operand1) * (operand2 + 5);
            // Display Step
            txtResult.Text = operand1.ToString() + " divided by " +
            operand2.ToString() +
            " equals " + answer.ToString();
            txtResult.Visible = true;
        }
        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnExit_Click_1(object sender, EventArgs e)
        {
            this.Close();

        }
        //flag = int.TryParse(txtOperand1.Text, out operand1);
    }
}
