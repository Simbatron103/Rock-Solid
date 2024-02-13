using System.ComponentModel;

namespace Rock_Solid
{
    public partial class Form1 : Form
    {
        // variabler 
        int ROCK = 0;
        int PAPER = 1;
        int SCISSORS = 2;

        int wins = 0;
        int losses = 0;
        int ties = 0;

        int choice = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        //Detta gör så man kan välja vad man vad man vill använda
        private void button4_Click(object sender, EventArgs e)
        {
            choice = ROCK;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            choice = PAPER;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            choice = SCISSORS;
        }
        //detta bestämmer vad opponenten använder och så räknar det ut vilka som vinner eller förlorar eller om det bilr ovajort och sparar det på respective label
        private void button1_Click(object sender, EventArgs e)
        {
            int opponent = Random.Shared.Next(ROCK, SCISSORS + 1);
            if (opponent == ROCK)
            {
                label1.Text = "ROCK";
            }
            else if (opponent == PAPER)
            {
                label1.Text = "PAPER";
            }
            else if (opponent == SCISSORS)
            {
                label1.Text = "SCISSORS";
            }
            if (opponent == ROCK && choice == PAPER)
            {
                wins++;
            }
            else if (opponent == PAPER && choice == SCISSORS)
            {
                wins++;
            }
            else if (opponent == SCISSORS && choice == ROCK)
                wins++;

            label2.Text = "Wins: " + wins.ToString();
            if (opponent == ROCK)
            {
                label1.Text = "ROCK";
            }
            else if (opponent == PAPER)
            {
                label1.Text = "PAPER";
            }
            else if (opponent == SCISSORS)
            {
                label1.Text = "SCISSORS";
            }
            if (choice == ROCK && opponent == PAPER)
            {
                losses++;
            }
            else if (choice == PAPER && opponent == SCISSORS)
            { 
                losses++;
            }
            else if (choice == SCISSORS && opponent == ROCK)
                losses++;

            label3.Text = "Losses: " + losses.ToString();
            if (opponent == ROCK)
            {
                label1.Text = "ROCK";
            }
            else if (opponent == PAPER)
            {
                label1.Text = "PAPER";
            }
            else if (opponent == SCISSORS)
            {
                label1.Text = "SCISSORS";
            }
            if (choice == ROCK && opponent == ROCK)
            {
                ties++;
            }
            else if (choice == PAPER && opponent == PAPER)
            {
                ties++;
            }
            else if (choice == SCISSORS && opponent == SCISSORS)
            {
                ties++;
            }
            label4.Text = "Ties: " + ties.ToString();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
