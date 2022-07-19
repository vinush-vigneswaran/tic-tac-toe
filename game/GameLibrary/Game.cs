namespace GameLibrary
{
    public class Game
    {
        // Attribute
        private Board board;
        private Player player1;
        private Player player2;
        private Player winner = null;

        // Constructor

        public Game() { }
        public Game(Player player1, Player player2)
        {
            this.player1 = player1;
            this.player2 = player2;
            board = new Board();
        }

        // Methods
        public void createNewBoard()
        {
            board = new Board();
            winner = null;
        }
        public bool PlayerMarks(Player player, int tile)
        {
            return board.Play(player.getGamePiece(), tile);
        }

        public bool CheckEnd() 
        {
            if (board.isGameWon())
            {
                if (board.whoWon() == player1.getGamePiece())
                {
                    int currScore = player1.getScore();
                    player1.setScore(currScore + 1);
                    setWinner(player1);
                }
                else if (board.whoWon() == player2.getGamePiece())
                {
                    int currScore = player2.getScore();
                    player2.setScore(currScore + 1);
                    setWinner(player2);
                }
            }
            return (board.isGameWon() | board.isGameDrawn());
        }

        public Player getWinner() 
        {
            return winner;
        }

        public void setWinner(Player winner)
        {
            this.winner = winner;
        }


        public string ShowBoard()
        {
            char[] i = board.currentStateAsList();
            string boardAsString = (i[0] + " " + i[1] + " " +  i[2] + "\n" +
                i[3] + " " + i[4] + " " + i[5] +"\n" +
                i[6] + " " + i[7] + " " + i[8]);

            return boardAsString;
        }
    }
}