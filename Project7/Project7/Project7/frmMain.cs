using System;
using System.Windows.Forms;

namespace Project7
{
    public partial class frmMain : Form
    {
        
        public frmMain()
        {
            InitializeComponent();
        }
        

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            bool flag;
            int i;
            int start;
            int end;
            string buff;
            //============ Gather inputs ======================
            // Convert start from text to int
            flag = int.TryParse(txtStart.Text, out start);
            if (flag == false)
            {
                MessageBox.Show("Numeric data only", "Input Error");
                txtStart.Focus();
                return;
            }
            // Convert end from text to int
            flag = int.TryParse(txtEnd.Text, out end);
            if (flag == false)
            {
                MessageBox.Show("Numeric data only", "Input Error");
                txtEnd.Focus();
                return;
            }
            if (start >= end) // Reasonable values?
            {
                MessageBox.Show("Start less than end.", "Input Error");
                txtStart.Focus();
                return;
            }
            //============= Process and Display ==============
            i = start; // Initialize loop counter: condition 1
            while (i <= end) // Another iteration: condition 2
            {
                buff = string.Format("{0, 5}{1, 20}", i, i * i);
                lstOutput.Items.Add(buff);
                i++; // Change state of loop: condition 3
            }
        }
        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtStart.Clear();
            txtEnd.Clear();
            lstOutput.Items.Clear();
        }
    }
}