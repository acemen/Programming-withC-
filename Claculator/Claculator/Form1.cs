using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Claculator
{
    public partial class Form1 : Form
    {
        Double val = 0;
        String text = "";
        bool oper_press = false;


        public Form1()
        {
            InitializeComponent();
        }

        private void button_click(object sender, EventArgs e)
        {
            if((Output.Text == "0")||(oper_press))
            {
                Output.Clear();
            }

            Button button = (Button)sender;
            Output.Text = Output.Text + button.Text;
            oper_press = false;
        }

        private void button12_Click(object sender, EventArgs e)
        {
            Output.Text = "0";
        }
        //Oppression:present/result 
        private void op_pres(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            Text = button.Text;
            val = Double.Parse(Output.Text);
            oper_press = true;
        }

        private void op_res(object sender, EventArgs e)
        {
            switch (text)
            {
                case "+":
                    Output.Text = (val + Double.Parse(Output.Text)).ToString();
                    break;
                case "-":
                    Output.Text = (val - Double.Parse(Output.Text)).ToString();
                    break;
                case "*":
                    Output.Text = (val * Double.Parse(Output.Text)).ToString();
                    break;
                case "/":
                    Output.Text = (val / Double.Parse(Output.Text)).ToString();
                    break;
                default:
                    break;
            }
            oper_press = false;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void c_pres(object sender, EventArgs e)
        {
            Output.Clear();
            val = 0;
        }
    }
}
