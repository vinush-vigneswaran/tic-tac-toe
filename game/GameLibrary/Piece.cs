namespace GameLibrary
{
    public class Piece
    {
        // attributes
        private int tileNum;
        private List<int> tileList = new List<int>();

        // constructor
        public Piece()
        {
        }

        // methods
        public void addCoordinates(int tileNum)
        {
            setTileNum(tileNum);
            tileList.Add(getTileNum());
        }

        public bool isWin()
        {
            if (tileList.Contains(1) & tileList.Contains(2) & tileList.Contains(3))
            {
                return true;
            }
            else if (tileList.Contains(4) & tileList.Contains(5) & tileList.Contains(6))
            {
                return true;
            }
            else if (tileList.Contains(7) & tileList.Contains(8) & tileList.Contains(9))
            {
                return true;
            }
            else if (tileList.Contains(1) & tileList.Contains(4) & tileList.Contains(7))
            {
                return true;
            }
            else if (tileList.Contains(2) & tileList.Contains(5) & tileList.Contains(8))
            {
                return true;
            }
            else if (tileList.Contains(3) & tileList.Contains(6) & tileList.Contains(9))
            {
                return true;
            }
            else if (tileList.Contains(1) & tileList.Contains(5) & tileList.Contains(9))
            {
                return true;
            }
            else if (tileList.Contains(3) & tileList.Contains(5) & tileList.Contains(7))
            {
                return true;
            }
            else
            { 
                return false;
            }
        }
        public bool isDraw()
        {
            return (tileList.Count == 5);
        }

        // getters and setters
        public int getTileNum()
        {
            return tileNum;
        }

        private void setTileNum(int tileNum)
        {
            this.tileNum = tileNum;
        }

        public List<int> getTileList()
        {
            return tileList;
        }

    }
}