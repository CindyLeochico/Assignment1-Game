using System;
using System.Windows.Forms;

namespace Game
{
    public partial class Form1 : Form
    {
        private char currentPlayer;
        private int playerXScore = 0;
        private int playerOScore = 0;
        private Button[,] buttons = new Button[3, 3];

        public Form1()
        {
            InitializeComponent();
            InitializeGame();
        }

        private void InitializeGame()
        {
            currentPlayer = 'X';
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    buttons[i, j] = new Button
                    {
                        Width = 100,
                        Height = 100,
                        Font = new System.Drawing.Font("Arial", 24),
                        Tag = new Tuple<int, int>(i, j)
                    };
                    buttons[i, j].Click += Button_Click;
                    this.Controls.Add(buttons[i, j]);
                    buttons[i, j].Location = new System.Drawing.Point(j * 100, i * 100);
                }
            }
        }

        private void Button_Click(object sender, EventArgs e)
        {
            Button button = sender as Button;
            if (button.Text == "")
            {
                button.Text = currentPlayer.ToString();
                if (CheckForWinner())
                {
                    MessageBox.Show($"Player {currentPlayer} wins!");
                    UpdateScore();
                    ResetGame();
                }
                else if (IsDraw())
                {
                    MessageBox.Show("It's a draw!");
                    ResetGame();
                }
                else
                {
                    currentPlayer = (currentPlayer == 'X') ? 'O' : 'X';
                }
            }
        }

        private bool CheckForWinner()
        {
            for (int i = 0; i < 3; i++)
            {
                if (buttons[i, 0].Text == currentPlayer.ToString() &&
                    buttons[i, 1].Text == currentPlayer.ToString() &&
                    buttons[i, 2].Text == currentPlayer.ToString())
                    return true;

                if (buttons[0, i].Text == currentPlayer.ToString() &&
                    buttons[1, i].Text == currentPlayer.ToString() &&
                    buttons[2, i].Text == currentPlayer.ToString())
                    return true;
            }

            if (buttons[0, 0].Text == currentPlayer.ToString() &&
                buttons[1, 1].Text == currentPlayer.ToString() &&
                buttons[2, 2].Text == currentPlayer.ToString())
                return true;

            if (buttons[0, 2].Text == currentPlayer.ToString() &&
                buttons[1, 1].Text == currentPlayer.ToString() &&
                buttons[2, 0].Text == currentPlayer.ToString())
                return true;

            return false;
        }

        private bool IsDraw()
        {
            foreach (var button in buttons)
            {
                if (button.Text == "")
                {
                    return false;
                }
            }
            return true;
        }

        private void UpdateScore()
        {
            if (currentPlayer == 'X')
                playerXScore++;
            else
                playerOScore++;

            lblPlayerXScore.Text = playerXScore.ToString();
            lblPlayerOScore.Text = playerOScore.ToString();
        }

        private void ResetGame()
        {
            foreach (var button in buttons)
            {
                button.Text = "";
            }
        }

      
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnReset_Click_1(object sender, EventArgs e)
        {
            ResetGame();
        }

        private void btnExit_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnNewGame_Click_1(object sender, EventArgs e)
        {
            ResetGame();
            playerXScore = 0;
            playerOScore = 0;
            lblPlayerXScore.Text = "0";
            lblPlayerOScore.Text = "0";
        }
    }
}
