using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Guessing_Game2
{
    public partial class Form1 : Form
    {

        private string[] footballClubs = { "Manchester United", "Real Madrid", "Barcelona", "Liverpool", "Bayern   " };
        private string[] hints = { "English club with a red devil mascot", "Spanish club known for its Galácticos", "Famous Catalan club", "Premier League club with 'You'll Never Walk Alone'", "German club with multiple Bundesliga titles" };
        private int currentWordIndex = 0;

        private void DisplayHint()
        {
            if (currentWordIndex < footballClubs.Length)
            {
                lblHint.Text = "Hint: " + hints[currentWordIndex];
            }
            else
            {
                lblHint.Text = "Game Over!";
            }
        }
        public Form1()
        {
            InitializeComponent();
            DisplayHint();


        }

        private void btnHint_Click(object sender, EventArgs e)
        {

        }

        private void btnGuess_Click(object sender, EventArgs e)
        {
            if (currentWordIndex < footballClubs.Length)
            {
                string guess = txtguess.Text.ToLower();
                string correctWord = footballClubs[currentWordIndex].ToLower();

                if (guess == correctWord)
                {
                    MessageBox.Show("Correct guess!", "Guess Result", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    currentWordIndex++;
                    txtguess.Clear();
                    DisplayHint();
                }
                else
                {
                    MessageBox.Show("Incorrect guess. Try again!", "Guess Result", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtguess.Clear();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure want to exit", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes) { Application.Exit(); }
        }
    }
}
