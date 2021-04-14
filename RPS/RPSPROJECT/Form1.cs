using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RPS
{
    
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }

        public static string humanChoice;
        public static string computerChoice;

        public static int computerScoreCount = 0;
        public static int humanScoreCount = 0;
        public static int drawCount = 0;

        public static string humanScore = "0";
        public static string computerScore = "0";
        public static string drawScore = "0";
        
        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Computer Scores " + computerScore + " and Human Scores " + humanScore + " and " + drawScore + " draws");
            this.Close();
        }
        
        private void btnPaper_Click(object sender, EventArgs e)
        {
            humanChoice = "Paper";
            computerRandomChoice();

        }

        private void btnRock_Click(object sender, EventArgs e)
        {
            humanChoice = "Rock";
            computerRandomChoice();
        }

        private void btnScissors_Click(object sender, EventArgs e)
        {
            humanChoice = "Scissors";
            computerRandomChoice();
        }

        public void computerRandomChoice()
        {

            Random RandomNumber = new Random();
            int x = RandomNumber.Next(0, 3);
            if (x == 0)
            {
                computerChoice = "Rock";
            }
            if (x == 1)
            {
                computerChoice = "Paper";
            }
            if (x == 2)
            {
                computerChoice = "Scissors";
            }
            results();

        }

        public void results()
        {
            if (computerChoice == "Rock" && humanChoice == "Rock" || computerChoice == "Scissors" && humanChoice == "Scissors" ||
                  computerChoice == "Paper" && humanChoice == "Paper")
            {
                humanChoiceTxtBox.Text = ("Player choose " + humanChoice);
                computerChoiceTxtBox.Text = ("Computer choose " + computerChoice);

                drawCount++;
                drawScore = drawCount.ToString();
                drawLabel.Text = (drawScore);

            }

            if (computerChoice == "Paper" && humanChoice == "Rock" ||
                computerChoice == "Scissors" && humanChoice == "Paper" ||
                computerChoice == "Rock" && humanChoice == "Scissors")
            {
                
                humanChoiceTxtBox.Text = ("Player choose " + humanChoice);
                computerChoiceTxtBox.Text = ("Computer choose " + computerChoice);
                
                computerScoreCount++;
                computerScore = computerScoreCount.ToString();
                computerScoreLabel.Text = (computerScore);
                
            }

            if (humanChoice == "Paper" && computerChoice == "Rock" ||
                humanChoice == "Scissors" && computerChoice == "Paper" ||
                humanChoice == "Rock" && computerChoice == "Scissors")
            {
                
                humanChoiceTxtBox.Text = ("Player choose " + humanChoice);
                computerChoiceTxtBox.Text = ("Computer choose " + computerChoice);
                
                humanScoreCount++;
                humanScore = humanScoreCount.ToString();
                humanScoreLabel.Text = (humanScore);
    
            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

    }
}
