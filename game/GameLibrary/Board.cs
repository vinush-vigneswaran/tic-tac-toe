namespace GameLibrary
{
    public class Board
    {
        // Attributes
        private char[] currentBoardState = { '1', '2', '3', '4', '5', '6', '7', '8','9' };
        private Piece Nought;
        private Piece Cross;

        //Constructors
        public Board()
        {
            Nought = new Piece();
            Cross = new Piece();
        }

        // Methods
        public bool Play(char piece, int tileNum) 
        {
            if (currentBoardState[tileNum - 1] == 'O' | currentBoardState[tileNum - 1] == 'X')
            {
                return false;
            }
            if (piece == 'O')
            {
                Nought.addCoordinates(tileNum);
                currentBoardState[tileNum-1] = 'O';
                return true;
            }
            else if (piece == 'X')
            { 
                Cross.addCoordinates(tileNum);
                currentBoardState[tileNum - 1] = 'X';
                return true;
            }
            return false;
        }
        public bool isGameWon()
        {
            return Nought.isWin() | Cross.isWin();
        }

        public char whoWon()
        {
            if (isGameWon())
            {
                if (Nought.isWin())
                {
                    return 'O';
                }
                else if (Cross.isWin())
                {
                    return 'X';
                }
            }
            return '-';
        }

        public bool isGameDrawn()
        {
            return Nought.isDraw() | Cross.isDraw();
        }

        public char[] currentStateAsList()
        {
            return currentBoardState;
        }
    }
}