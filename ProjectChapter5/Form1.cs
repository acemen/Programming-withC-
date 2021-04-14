using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjectChapter5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnTest_Click(object sender, EventArgs e)
        {
            bool flag;
            int index;
            int start;
            int howMany;
            string temp;
            label6.Text = "";
            // Find length
            txtLength.Text = txtInput.Text.Length.ToString();
            // Change cases
            txtToUpper.Text = txtInput.Text.ToUpper();
            txtToLower.Text = txtInput.Text.ToLower();
            // Index of
            index = txtInput.Text.IndexOf(txtSearchChar.Text, 0);
            label6.Text = "txtInput.Text.IndexOf(\"" + txtSearchChar.Text +
            "\",0) = ";
            txtSearchIndex.Text = index.ToString();
            //LastIndexOf
            index = txtInput.Text.LastIndexOf(txtLastChar.Text);
            label8.Text = "txtInput.Text.LastIndexOf(\"" + txtLastChar.Text + "\")= ";
            txtLastIndexOf.Text = index.ToString();
            // Substring
            flag = int.TryParse(txtStartIndex.Text, out start);
            if (flag == false)
            {
                MessageBox.Show("Improper numeric input. Re-enter.");
                txtStartIndex.Focus();
                return;
            }
            flag = int.TryParse(txtEndIndex.Text, out howMany);
            if (flag == false)
            {
                MessageBox.Show("Improper numeric input. Re-enter.");
                txtEndIndex.Focus();
                return;
            }
            label9.Text = "txtInput.Text.Substring(" + start.ToString() + ", " +
            howMany.ToString() + ") = ";
            txtSubstringResult.Text = txtInput.Text.Substring(start, howMany);
            // Remove
            temp = txtInput.Text;
            index = temp.IndexOf(txtRemove.Text);
            if (index > 0)
            {
                txtRemoveResult.Text = temp.Remove(index, txtRemove.Text.Length);

                // Replace
                temp = txtInput.Text;
                txtReplaceResult.Text = temp.Replace(txtReplaceChars.Text, txtReplaceWith.Text);
            }


        }
    }
}
