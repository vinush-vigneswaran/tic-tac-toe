using GameLibrary;
using static System.Console;


///////////////Game Begins////////////////////

WriteLine("-------------------\ntic-tac-toe\n-------------------");
Player player1 = InitiatePlayer("Player 1");
Player player2 = InitiatePlayer("Player 2");

WriteLine("-------------------\nPlayers\n-------------------");
WriteLine("Player 1 is " + player1.getName() + " as " + player1.getGamePiece());
WriteLine("Player 2 is " + player2.getName() + " as " + player2.getGamePiece());

WriteLine("-------------------\nLet the games begin!\n-------------------");
Game game = new Game(player1, player2);
Console.WriteLine("-----");
Console.WriteLine(game.ShowBoard());
Console.WriteLine("-----");

Player player = player1;
bool quit = false;

while (!quit) 
{
    game.createNewBoard();

    while (!game.CheckEnd()) 
    {
        bool moveSuccess = false;

        while (!moveSuccess) 
        {
            Console.WriteLine(player.getName() + " choose your tile:");
            int tile = Convert.ToInt16(ReadLine());

            moveSuccess = game.PlayerMarks(player, tile);

            if (!moveSuccess)
            {
                Console.WriteLine("Something went wrong, please try again:");
            }
        }

        // show the board
        Console.WriteLine("-----");
        Console.WriteLine(game.ShowBoard());
        Console.WriteLine("-----");

        // switch turns
        if (player == player1)
        {
            player = player2;
        }
        else
        {
            player = player1;
        }
    }

    Console.WriteLine("-------------------\nScore of " + player1.getName() + " \t: " + player1.getScore());
    Console.WriteLine("Score of " + player2.getName() + " \t: " + player2.getScore() + "\n-------------------");

    Console.WriteLine("\nWould you like to play again? (Y/N)");
    char endGame = ReadLine()[0];
    if (endGame == 'N') 
    {
        quit = true;
    }    
}

Console.WriteLine("The final score was: " );
Console.WriteLine("-------------------\nScore of " + player1.getName() + " \t: " + player1.getScore());
Console.WriteLine("Score of " + player2.getName() + " \t: " + player2.getScore() + "\n-------------------");







static Player InitiatePlayer(string playerNum)
{
    char playerPiece = default;
    string playerName = playerNum;
    bool invalid;

    Console.WriteLine(playerNum + " name:");
    playerName = ReadLine();

    if (Player.firstPlayerDecidedPiece == 'N')
    {
        
        do
        {
            invalid = true;
            Console.WriteLine("Would you like to be noughts or crosses? (O/X)");
            playerPiece = ReadLine()[0];
            if ((playerPiece == 'O') | (playerPiece == 'X'))
            {
                invalid = false;
            }
            else
            {
                Console.WriteLine("Invalid input. Please try again.");
            }
        } while (invalid);

        Player.firstPlayerDecidedPiece = playerPiece;
    }
    else if (Player.firstPlayerDecidedPiece == 'X')
    {
        playerPiece = 'O';
    }
    else if (Player.firstPlayerDecidedPiece == 'O')
    {
        playerPiece = 'X';
    }

    Player player = new Player(playerName, playerPiece);
    return player;
}





