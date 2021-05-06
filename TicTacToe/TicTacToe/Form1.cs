using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TicTacToe
{
    public partial class Form1 : Form
    {
        Random rand;
        bool firsPlayerTurn;
        bool gameStarted;
        bool hasWinner;

        public Form1()
        {
            InitializeComponent();
            rand = new Random();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!gameStarted || hasWinner)
                return;


            Button button = (Button)sender;

            if (!string.IsNullOrEmpty(button.Text))
                return;

            if (firsPlayerTurn)
            {
                button.Text = player1Sign.Text;
                button.ForeColor = player1Sign.ForeColor;
            }
            else
            {
                button.Text = player2Sign.Text;
                button.ForeColor = player2Sign.ForeColor;
            }

            firsPlayerTurn = !firsPlayerTurn;
            CheckWin();
        }

        private void StartGame_Click(object sender, EventArgs e)
        {
            ClearDesk();
            int number = rand.Next(1, 3);
            if (number == 1)
                firsPlayerTurn = true;
            else
                firsPlayerTurn = false;

            if (firsPlayerTurn)
                MessageBox.Show("First player turn");
            else
                MessageBox.Show("Second player turn");

            gameStarted = true;
        }

        public void ClearDesk()
        {
            resultText.Text = "";
            button1.Text = "";
            button2.Text = "";
            button3.Text = "";
            button4.Text = "";
            button5.Text = "";
            button6.Text = "";
            button7.Text = "";
            button8.Text = "";
            button9.Text = "";
            hasWinner = false;
        }

        public void CheckWin()
        {
            hasWinner = true;
            if (!string.IsNullOrEmpty(button1.Text) && button2.Text == button1.Text
                && button3.Text == button1.Text)
            {
                if (button1.Text == player1Sign.Text)
                    resultText.Text = "Winer is player 1";
                else
                    resultText.Text = "Winner is player 2";
            }
            else if (!string.IsNullOrEmpty(button4.Text) && button5.Text == button4.Text
                && button6.Text == button4.Text)
            {
                if (button4.Text == player1Sign.Text)
                    resultText.Text = "Winer is player 1";
                else
                    resultText.Text = "Winner is player 2";
            }
            else if (!string.IsNullOrEmpty(button7.Text) && button8.Text == button7.Text
                && button9.Text == button7.Text)
            {
                if (button7.Text == player1Sign.Text)
                    resultText.Text = "Winer is player 1";
                else
                    resultText.Text = "Winner is player 2";
            }
            else if (!string.IsNullOrEmpty(button1.Text) && button4.Text == button1.Text
                && button7.Text == button1.Text)
            {
                if (button1.Text == player1Sign.Text)
                    resultText.Text = "Winer is player 1";
                else
                    resultText.Text = "Winner is player 2";
            }
            else if (!string.IsNullOrEmpty(button2.Text) && button5.Text == button2.Text
    && button8.Text == button2.Text)
            {
                if (button2.Text == player1Sign.Text)
                    resultText.Text = "Winer is player 1";
                else
                    resultText.Text = "Winner is player 2";
            }
            else if (!string.IsNullOrEmpty(button3.Text) && button6.Text == button3.Text
&& button9.Text == button3.Text)
            {
                if (button3.Text == player1Sign.Text)
                    resultText.Text = "Winer is player 1";
                else
                    resultText.Text = "Winner is player 2";
            }
            else if (!string.IsNullOrEmpty(button1.Text) && button5.Text == button1.Text
&& button9.Text == button1.Text)
            {
                if (button1.Text == player1Sign.Text)
                    resultText.Text = "Winer is player 1";
                else
                    resultText.Text = "Winner is player 2";
            }
            else if (!string.IsNullOrEmpty(button3.Text) && button5.Text == button3.Text
&& button7.Text == button3.Text)
            {
                if (button3.Text == player1Sign.Text)
                    resultText.Text = "Winer is player 1";
                else
                    resultText.Text = "Winner is player 2";
            }
            else
                hasWinner = false;
        }

    }
}
