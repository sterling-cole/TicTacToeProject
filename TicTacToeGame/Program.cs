using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToeGame
{
    public class ProgramUI
    {
        public static char playerPiece = ' ';
        static char[] position = { '1', '2', '3', '4', '5', '6', '7', '8', '9' };
        static int turnCount = 0;
        public void Run()
        {
            RunMenu();
            DrawBoard();
            RunGame();
            Win();
            ResetBoard();
            

        }
        public void RunMenu()
        {
            Console.WriteLine("Welcome to Tic Tac Toe!");
            Console.WriteLine("Think you got what it takes to win?");
            Console.WriteLine("Press any key to continue...");
            Console.ReadKey();
        }
        static void DrawBoard()
        {
            Console.Clear();
            Console.WriteLine("---------------------------------");
            Console.WriteLine("           |           |         |");
            Console.WriteLine("    {0}      |     {1}     |    {2}    |", position[0], position[1], position[2]);
            Console.WriteLine("           |           |         |");
            Console.WriteLine("---------------------------------");
            Console.WriteLine("           |           |         |");
            Console.WriteLine("    {0}      |     {1}     |    {2}    |", position[3], position[4], position[5]);
            Console.WriteLine("           |           |         |");
            Console.WriteLine("---------------------------------");
            Console.WriteLine("           |           |         |");
            Console.WriteLine("    {0}      |     {1}     |    {2}    |", position[6], position[7], position[8]);
            Console.WriteLine("           |           |         |");
            Console.WriteLine("---------------------------------");
        }
        public static void ResetBoard()
        { //reset the board to start
            char[] PositionReset = { '1', '2', '3', '4', '5', '6', '7', '8', '9' };

            position = PositionReset;
            DrawBoard();
            turnCount = 0;

        }
        static void RunGame()
        {
            int player = 1;
            int input = 0;
            bool inputCorrect = true;

            do
            {
                if (player == 1)
                {
                    player = 2;
                    XorO(player, input);
                }
                else if (player == 2)
                {
                    player = 1;
                    XorO(player, input);
                }

                DrawBoard();
                turnCount++;
                Win();

                if (turnCount == 9)
                {
                    Console.WriteLine("Look at that, you tied!");
                    Console.WriteLine("Enter any key to reset the game");
                    Console.ReadKey();
                    ResetBoard();
                }

                do
                {
                    Console.WriteLine("Take your turn", player);
                    try
                    {
                        input = Convert.ToInt32(Console.ReadLine());
                        Console.Beep();
                    }
                    catch
                    {
                        Console.WriteLine("Enter a number");
                        
                    }

                    if ((input == 1) && (position[0] == '1'))
                        inputCorrect = true;
                    else if ((input == 2) && (position[1] == '2'))
                        inputCorrect = true;
                    else if ((input == 3) && (position[2] == '3'))
                        inputCorrect = true;
                    else if ((input == 4) && (position[3] == '4'))
                        inputCorrect = true;
                    else if ((input == 5) && (position[4] == '5'))
                        inputCorrect = true;
                    else if ((input == 6) && (position[5] == '6'))
                        inputCorrect = true;
                    else if ((input == 7) && (position[6] == '7'))
                        inputCorrect = true;
                    else if ((input == 8) && (position[7] == '8'))
                        inputCorrect = true;
                    else if ((input == 9) && (position[8] == '9'))
                        inputCorrect = true;
                    else
                    {
                        Console.WriteLine("Choose an empty square.");
                        inputCorrect = false;
                    }
                } while (!inputCorrect);
            } while (true);

        }



        public static void XorO(int player, int input)
        {
            if (player == 1) playerPiece = 'X';
            else if (player == 2) playerPiece = 'O';
            switch (input)
            {
                case 1: position[0] = playerPiece; break;
                case 2: position[1] = playerPiece; break;
                case 3: position[2] = playerPiece; break;
                case 4: position[3] = playerPiece; break;
                case 5: position[4] = playerPiece; break;
                case 6: position[5] = playerPiece; break;
                case 7: position[6] = playerPiece; break;
                case 8: position[7] = playerPiece; break;
                case 9: position[8] = playerPiece; break;
            }
        }
        public static void Win()
        {
            char[] playerPieces = { 'X', 'O' };

            foreach (char playerPiece in playerPieces)
            {
                if (((position[0] == playerPiece) && (position[1] == playerPiece) && (position[2] == playerPiece))
                    || ((position[3] == playerPiece) && (position[4] == playerPiece) && (position[5] == playerPiece))
                    || ((position[6] == playerPiece) && (position[7] == playerPiece) && (position[8] == playerPiece))
                    || ((position[0] == playerPiece) && (position[3] == playerPiece) && (position[6] == playerPiece))
                    || ((position[1] == playerPiece) && (position[4] == playerPiece) && (position[7] == playerPiece))
                    || ((position[2] == playerPiece) && (position[5] == playerPiece) && (position[8] == playerPiece))
                    || ((position[0] == playerPiece) && (position[4] == playerPiece) && (position[8] == playerPiece))
                    || ((position[6] == playerPiece) && (position[4] == playerPiece) && (position[2] == playerPiece)))
                {
                    Console.WriteLine(@" __ __ __    ________  ___   __    ___   __    ______   ______        __ __ __    ________  ___   __    ___   __    ______   ______");
                    Console.WriteLine(@"/_//_//_/\  /_______/\/__/\ /__/\ /__/\ /__/\ /_____/\ /_____/\      /_//_//_/\  /_______/\/__/\ /__/\ /__/\ /__/\ /_____/\ /_____/\      ");
                    Console.WriteLine(@"\:\\:\\:\ \ \__.::._\/\::\_\\  \ \\::\_\\  \ \\::::_\/_\:::_ \ \     \:\\:\\:\ \ \__.::._\/\::\_\\  \ \\::\_\\  \ \\::::_\/_\:::_ \ \     ");
                    Console.WriteLine(@" \:\\:\\:\ \   \::\ \  \:. `-\  \ \\:. `-\  \ \\:\/___/\\:(_) ) )_    \:\\:\\:\ \   \::\ \  \:. `-\  \ \\:. `-\  \ \\:\/___/\\:(_) ) )_   ");
                    Console.WriteLine(@"  \:\\:\\:\ \  _\::\ \__\:. _    \ \\:. _    \ \\::___\/_\: __ `\ \    \:\\:\\:\ \  _\::\ \__\:. _    \ \\:. _    \ \\::___\/_\: __ `\ \  ");
                    Console.WriteLine(@"   \:\\:\\:\ \/__\::\__/\\. \`-\  \ \\. \`-\  \ \\:\____/\\ \ `\ \ \    \:\\:\\:\ \/__\::\__/\\. \`-\  \ \\. \`-\  \ \\:\____/\\ \ `\ \ \ ");
                    Console.WriteLine(@"    \_______\/\________\/ \__\/ \__\/ \__\/ \__\/ \_____\/ \_\/ \_\/     \_______\/\________\/ \__\/ \__\/ \__\/ \__\/ \_____\/ \_\/ \_\/ ");
                    if (playerPiece == 'X')
                    {
                        Console.Beep();
                        Console.WriteLine("Congratulations Player 1.\nYou got the dub! " +
                                          "\nEveryone must bow to you!\n" +
                                          "\nTurns taken{0} ", turnCount);
                    }
                    else if (playerPiece == 'O')
                    {
                        Console.Beep();
                        Console.WriteLine("Congratulations Player 2.\nYou got the dub! " +
                                          "\nEveryone must bow to you!\n" +
                                          "\nTurns taken{0} ", turnCount);
                    }
                    Console.WriteLine("Please press any key to reset the game");
                    Console.ReadKey();
                    ResetBoard();

                    break;
                }
            }


        }

    }
}

// Make board layout*
// Assign positions*
//User input*
// Clearing board and replacing with user inputs*
// Making sure you can't place in a already chosen block*
// Setup logic for deciding winner*