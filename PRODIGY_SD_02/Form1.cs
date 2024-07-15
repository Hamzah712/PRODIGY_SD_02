using System;
using System.Runtime.CompilerServices;
using System.Runtime.Intrinsics.X86;

namespace PRODIGY_SD_02
{
    public partial class form : Form
    {
        private static Random random = new Random();
        private int targetNum;
        private bool gameWon = false;
        int counter = 0;

        public form()
        {
            InitializeComponent();
            targetNum = randNum();
        }

        public int randNum()
        {
            return random.Next(0, 101);
        }

        private void guessButton_Click(object sender, EventArgs e)
        {
            string userInput = inputTextBox.Text;
            int userNum;

            if (gameWon) 
            {
                successResultLabel.Visible = false;
                resultLabel.Text = "You've already won! Start a new game.";
                resultLabel.Visible = true;
                resultLabel.ForeColor = Color.DarkRed;
                return;
            }

            if (int.TryParse(userInput, out userNum))
            {
                if (userNum < 0 || userNum > 100)
                {
                    resultLabel.Text = "Please enter a number between 0 and 100.";
                    resultLabel.Visible = true;
                    resultLabel.ForeColor = Color.DarkRed;
                }
                else
                {
                    counter++;
                    if (userNum == targetNum)
                    {
                        successResultLabel.Text = $"Congratulations! You guessed the correct number in {counter} attempt(s).";
                        successResultLabel.Visible = true;
                        successResultLabel.ForeColor = Color.Green;
                        resultProgressBar.Value = 100;
                        gameWon = true;
                    }
                    else
                    {
                        if (userNum < targetNum)
                        {
                            resultLabel.Text = "Too low! Try again.";
                            resultProgressBar.Value = Math.Max(0, 100 - (targetNum - userNum));
                        }
                        else
                        {
                            resultLabel.Text = "Too high! Try again.";
                            resultProgressBar.Value = Math.Max(0, 100 - (userNum - targetNum));
                        }
                        resultLabel.Visible = true;
                        resultLabel.ForeColor = Color.DarkRed;
                    }
                }
            }
            else if (string.IsNullOrWhiteSpace(inputTextBox.Text))
            {
                resultLabel.Text = "Please enter a number.";
                resultLabel.Visible = true;
                resultLabel.ForeColor = Color.DarkRed;
            }
            else
            {
                resultLabel.Text = "Incorrect input, please try again.";
                resultLabel.Visible = true;
                resultLabel.ForeColor = Color.DarkRed;
            }
        }

        private void revealTargetLabel_Click(object sender, EventArgs e)
        {
            MessageBox.Show($"The target number is: {targetNum}", "Reveal Target Number", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void newGameButton_Click(object sender, EventArgs e)
        {
            targetNum = randNum();
            counter = 0;
            resultLabel.Visible = false;
            successResultLabel.Visible = false;
            resultProgressBar.Value = 0;
            inputTextBox.Clear();
            gameWon = false;
        }
    }
}
