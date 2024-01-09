using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp9
{
    public partial class form1 : Form

    {
        private int targetNumber;
        private Random random;
        private Color defaultBackgroundColor;

        public form1()
        {
            InitializeComponent();
            random = new Random();
            defaultBackgroundColor = this.BackColor;
            ResetGame();

        }
        private void ResetGame()
        {
            targetNumber = random.Next(1, 1001);
            guessTextBox.Text = "";
            guessTextBox.Enabled = true;
            guessButton.Enabled = true;
           
            this.BackColor = defaultBackgroundColor;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            ResetGame();
        }

        private void guessButton_Click(object sender, EventArgs e)
        {
            int guess;
            if (int.TryParse(guessTextBox.Text, out guess))
            {
                if (guess == targetNumber)
                {
                    MessageBox.Show("Correct!");
                    this.BackColor = Color.Green;
                    guessTextBox.Enabled = false;
                    guessButton.Enabled = false;
                    messageLabe.Text = "Correct!";
                }
                else if (guess < targetNumber)
                {
                    messageLabe.Text = "Too Low";
                    this.BackColor = Color.Blue;
                }
                else
                {
                    messageLabe.Text = "Too High";
                    this.BackColor = Color.Red;
                }
            }
            else
            {
                MessageBox.Show("Invalid input. Please enter a valid number.");
            }
            guessTextBox.Text = "";
        }
    }
    }

