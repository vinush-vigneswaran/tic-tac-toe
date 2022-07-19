namespace GameLibrary
{
    public class Player
    {   

        //Attributes

        private string name;
        private int score = 0;
        private char gamePiece; //noughts or crosses
        public static char firstPlayerDecidedPiece = 'N';


        //Constructors

        public Player() 
        { 
        }
        public Player(string playerName, char playerGamePiece)
        { 
            this.name = playerName;
            this.gamePiece = playerGamePiece;
        }

        //Methods  


        //Getters and Setters
        public string getName()
        { 
            return name;
        }

        public void setName(string Name)
        { 
            this.name = Name;
        }

        public int getScore() 
        {
            return this.score;
        }

        public void setScore(int Score)
        {
            this.score = Score;
        }

        public char getGamePiece()
        {
            return this.gamePiece;
        }

        public void setGamePiece(char GamePiece) 
        { 
            this.gamePiece=GamePiece;
        }
    }
}