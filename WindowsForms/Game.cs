using System;
using System.Drawing;
using System.Windows.Forms;
using WindowsForms.Properties;

namespace WindowsForms
{
    public partial class Game : Form
    {
        public delegate void DataBackEventHandler(string winnerName);
        public event DataBackEventHandler DataBack;

        public event Action<string> OnWinner;

        protected virtual void Winner(string theWinner)
        {
            OnWinner?.Invoke(theWinner);
        }

        enum EnPlayer { Player1, Player2 }
        enum EnWinner { Player1, Player2, Draw, GameInProgress }

        struct StGameStatus
        {
            public EnWinner winner;
            public short playCount;
            public bool gameOver;
        }

        public Game(string playerName)
        {
            InitializeComponent();
            _playerName = playerName;
        }

        StGameStatus gameStatus;
        EnPlayer playerTurn = EnPlayer.Player1;
        private readonly string _playerName;

        private void RestartGame()
        {
            EnablePictureBoxes(true);
            ResetAllPictureBoxes();
            ResetDataStructure();

        }

        private void ResetDataStructure()
        {
            playerTurn = EnPlayer.Player1;

            lblPlayer.Text = "PLAYER 1";
            lblWinner.Text = "IN PROGRESS";

            gameStatus.winner = EnWinner.GameInProgress;
            gameStatus.gameOver = false;
            gameStatus.playCount = 0;
        }

        private void ResetPictureBox(PictureBox pb)
        {
            pb.Tag = '?';
            pb.Image = Resources.White_Question_Mark;
            pb.BackColor = default;
        }

        private void ResetAllPictureBoxes()
        {
            foreach (Control control in Controls)
            {
                if (control is PictureBox pb)
                {
                    ResetPictureBox(pb);
                }
            }
        }

        private void EndGame()
        {
            MessageBox.Show("[GAME OVER]", "Game", MessageBoxButtons.OK, MessageBoxIcon.Information);
            EnablePictureBoxes(false);

            lblPlayer.Text = "[GAME OVER]";

            switch (gameStatus.winner)
            {
                case EnWinner.Player1:
                    lblWinner.Text = _playerName;
                    break;

                case EnWinner.Player2:
                    lblWinner.Text = "PLAYER 2";
                    break;

                default:
                    lblWinner.Text = "DRAW";
                    break;
            }

            
        }

        private void CheckTheWinner()
        {
            if (CheckLines()) return;

            CheckDraw();
        }

        private void CheckDraw()
        {
            if (gameStatus.playCount == 9)
            {
                gameStatus.winner = EnWinner.Draw;
                EndGame();
            }
        }

        private void ChangePictureBoxColor(PictureBox pb1, PictureBox pb2, PictureBox pb3)
        {
            pb1.BackColor = Color.GreenYellow;
            pb2.BackColor = Color.GreenYellow;
            pb3.BackColor = Color.GreenYellow;
        }

        private bool CheckLine(PictureBox pb1, PictureBox pb2, PictureBox pb3)
        {
            if (Convert.ToChar(pb1.Tag) == '?' || Convert.ToChar(pb2.Tag) == '?' || Convert.ToChar(pb3.Tag) == '?')
                return false;

            if (Convert.ToChar(pb1.Tag) == Convert.ToChar(pb2.Tag) && Convert.ToChar(pb2.Tag) == Convert.ToChar(pb3.Tag))
            {
                ChangePictureBoxColor(pb1, pb2, pb3);

                if (Convert.ToChar(pb1.Tag) == 'X')
                {
                    gameStatus.winner = EnWinner.Player1;
                    gameStatus.gameOver = true;
                    EndGame();
                }
                else
                {
                    gameStatus.winner = EnWinner.Player2;
                    gameStatus.gameOver = true;
                    EndGame();
                }
                return true;
            }

            return false;
        }

        private bool CheckLines()
        {
            return CheckLine(pb1, pb2, pb3) || CheckLine(pb4, pb5, pb6) || CheckLine(pb7, pb8, pb9) ||
                   CheckLine(pb1, pb4, pb7) || CheckLine(pb2, pb5, pb8) || CheckLine(pb3, pb6, pb9) ||
                   CheckLine(pb1, pb5, pb9) || CheckLine(pb3, pb5, pb7);
        }

        private void EnablePictureBoxes(bool isEnabled)
        {
            foreach (Control control in Controls)
            {
                if (control is PictureBox pb)
                {
                    pb.Enabled = isEnabled;
                }
            }
        }

        private void StartTurn(PictureBox pb)
        {
            if (Convert.ToChar(pb.Tag) != '?')
            {
                MessageBox.Show("Wrong Choice", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            switch (playerTurn)
            {
                case EnPlayer.Player1:
                    pb.Image = Resources.X;
                    pb.Tag = 'X';

                    lblPlayer.Text = "PLAYER 2";
                    playerTurn = EnPlayer.Player2;
                    break;

                case EnPlayer.Player2:
                    pb.Image = Resources.O;
                    pb.Tag = 'O';

                    lblPlayer.Text = _playerName;
                    playerTurn = EnPlayer.Player1;
                    break;
            }

            gameStatus.playCount++;

            CheckTheWinner();

        }

        #region
        private void Game_Paint(object sender, PaintEventArgs e)
        {
            using (var pen = new Pen(Color.White, 10))
            {
                e.Graphics.DrawLine(pen, 350, 150, 750, 150);
                e.Graphics.DrawLine(pen, 350, 250, 750, 250);
                e.Graphics.DrawLine(pen, 480, 60, 480, 340);
                e.Graphics.DrawLine(pen, 620, 60, 620, 340);
            }
        }

        private void PictureBox_Click(object sender, EventArgs e)
        {
            StartTurn((PictureBox)sender);
        }

        private void BtnRestartGame_Click(object sender, EventArgs e)
        {
            RestartGame();
        }
        #endregion

        private void Game_Load(object sender, EventArgs e)
        {
            lblPlayer.Text = _playerName;
        }

        private void Game_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (lblWinner.Text != "IN PROGRESS")
            DataBack?.Invoke(lblWinner.Text);
            
        }

        private void lblWinner_TextChanged(object sender, EventArgs e)
        {
            OnWinner?.Invoke(lblWinner.Text);
        }
    }
}
