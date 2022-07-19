using GameLibrary;
using static System.Console;
namespace tic_tac_toe_ui
{
    public partial class Form1 : Form
    {

        //Attributes
        Player player1 = new Player("Player X", 'X');
        Player player2 = new Player("Player O", 'O');
        Player currentPlayer = new Player();
        Game game = new Game();

        public Form1()
        {
            InitializeComponent();
            label1.Text = $"{player1.getName()}";
            label1.Enabled = true;
            label2.Text = $"{player2.getName()}";
            label3.Text = $"{player1.getScore()} - {player2.getScore()}";
            currentPlayer = player1;
            game = new Game(player1, player2);
        }

        private Player switchPlayer(Player playerA)
        {
            Player playerB = new Player();

            if (playerA == player1)
            {
                playerB = player2;
                label1.Enabled = false;
                label2.Enabled = true;
            }
            else
            {
                playerB = player1;
                label1.Enabled = true;
                label2.Enabled = false;
            }
            return playerB;
        }

        private void resetBoard()
        {
            button1.Enabled = true;
            button2.Enabled = true;
            button3.Enabled = true;
            button4.Enabled = true;
            button5.Enabled = true;
            button6.Enabled = true;
            button7.Enabled = true;
            button8.Enabled = true;
            button9.Enabled = true;

            button1.Text = "";
            button2.Text = "";
            button3.Text = "";
            button4.Text = "";
            button5.Text = "";
            button6.Text = "";
            button7.Text = "";
            button8.Text = "";
            button9.Text = "";
        }

        private void checkEnd()
        {
            if (game.CheckEnd())
            {
                if (game.getWinner() != null)
                {
                    MessageBox.Show($"The winner is {game.getWinner().getName()}!\n\n{player1.getName()}: \t{player1.getScore()}\n{player2.getName()}: \t{player2.getScore()}");
                }
                else
                {
                    MessageBox.Show($"It's a draw!\n\n{player1.getName()}: \t{player1.getScore()}\n{player2.getName()}: \t{player2.getScore()}");
                }

                label1.Text = $"{player1.getName()}";
                label2.Text = $"{player2.getName()}";
                label3.Text = $"{player1.getScore()} - {player2.getScore()}";
                game.createNewBoard();
                resetBoard();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            button1.Text = currentPlayer.getGamePiece().ToString();
            game.PlayerMarks(currentPlayer, 1);
            currentPlayer = switchPlayer(currentPlayer);
            button1.Enabled = false;
            checkEnd();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            button2.Text = currentPlayer.getGamePiece().ToString();
            game.PlayerMarks(currentPlayer, 2);
            currentPlayer = switchPlayer(currentPlayer);
            button2.Enabled = false;
            checkEnd();
        }
        private void button3_Click(object sender, EventArgs e)
        {
            button3.Text = currentPlayer.getGamePiece().ToString();
            game.PlayerMarks(currentPlayer, 3);
            currentPlayer = switchPlayer(currentPlayer);
            button3.Enabled = false;
            checkEnd();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            button4.Text = currentPlayer.getGamePiece().ToString();
            game.PlayerMarks(currentPlayer, 4);
            currentPlayer = switchPlayer(currentPlayer);
            button4.Enabled = false;
            checkEnd();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            button5.Text = currentPlayer.getGamePiece().ToString();
            game.PlayerMarks(currentPlayer, 5);
            currentPlayer = switchPlayer(currentPlayer);
            button5.Enabled = false;
            checkEnd();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            button6.Text = currentPlayer.getGamePiece().ToString();
            game.PlayerMarks(currentPlayer, 6);
            currentPlayer = switchPlayer(currentPlayer);
            button6.Enabled = false;
            checkEnd();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            button7.Text = currentPlayer.getGamePiece().ToString();
            game.PlayerMarks(currentPlayer, 7);
            currentPlayer = switchPlayer(currentPlayer);
            button7.Enabled = false;
            checkEnd();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            button8.Text = currentPlayer.getGamePiece().ToString();
            game.PlayerMarks(currentPlayer, 8);
            currentPlayer = switchPlayer(currentPlayer);
            button8.Enabled = false;
            checkEnd();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            button9.Text = currentPlayer.getGamePiece().ToString();
            game.PlayerMarks(currentPlayer, 9);
            currentPlayer = switchPlayer(currentPlayer);
            button9.Enabled = false;
            checkEnd();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void helpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }

        private void helpToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            MessageBox.Show($"Tic Tac Toe is a game for two players who take turns marking the spaces in a three-by-three grid with X or O. The player who succeeds in placing three of their marks in a horizontal, vertical, or diagonal row is the winner.");
        }
    }
}