namespace Minesweeper
{
    using System;
    using System.Collections.Generic;

    using Entities;

    public class MinesweeperStartUp
    {
        private const int MaxPossibleMoves = 35;
        private const int HighPlayerLength = 6;
        private const int MinCommandLength = 3;

        public static void Main()
        {
            var command = string.Empty;
            var gameField = CreateGameField();
            var mines = SetTheBombs();
            var scoreCounter = 0;
            var isExploded = false;
            var champions = new List<Player>(HighPlayerLength);
            var row = 0;
            var column = 0;
            var isNewGame = true;
            var isGameOver = false;

            do
            {
                if (isNewGame)
                {
                    Console.WriteLine("Let's Play some \"Minesweeperr!!\". Try your luck to find all fields which are Bomb free!!!." +
                    " Command 'top' Shows the Score Result, 'restart' Starts a new game , 'exit' Ends and Exits the Game!");

                    DrawGameField(gameField);
                    isNewGame = false;
                }

                Console.Write("Write down a row and a column value: ");

                command = Console.ReadLine().Trim();

                if (command.Length >= MinCommandLength)
                {
                    if (int.TryParse(command[0].ToString(), out row) &&
                    int.TryParse(command[2].ToString(), out column) &&
                        row <= gameField.GetLength(0) && column <= gameField.GetLength(1))
                    {
                        command = "turn";
                    }
                }

                switch (command)
                {
                    case "top":
                        ScoreResult(champions);
                        break;
                    case "restart":
                        gameField = CreateGameField();
                        mines = SetTheBombs();
                        DrawGameField(gameField);
                        isExploded = false;
                        isNewGame = false;
                        break;
                    case "exit":
                        Console.WriteLine("Bye, Bye, Bye!");
                        break;
                    case "turn":
                        if (mines[row, column] != '*')
                        {
                            if (mines[row, column] == '-')
                            {
                                YourTurn(gameField, mines, row, column);
                                scoreCounter++;
                            }

                            if (MaxPossibleMoves == scoreCounter)
                            {
                                isGameOver = true;
                            }
                            else
                            {
                                DrawGameField(gameField);
                            }
                        }
                        else
                        {
                            isExploded = true;
                        }

                        break;
                    default:
                        Console.WriteLine("\nError! Invalid Command!\n");
                        break;
                }

                if (isExploded)
                {
                    DrawGameField(mines);
                    Console.Write($"\nHrrrrrr! You died heroicly with {scoreCounter} points. " + "Please enter your nickname: ");
                    var nickname = Console.ReadLine();

                    var currentPlayer = new Player(nickname, scoreCounter);

                    if (champions.Count < 5)
                    {
                        champions.Add(currentPlayer);
                    }
                    else
                    {
                        for (var i = 0; i < champions.Count; i++)
                        {
                            if (champions[i].Points < currentPlayer.Points)
                            {
                                champions.Insert(i, currentPlayer);
                                champions.RemoveAt(champions.Count - 1);
                                break;
                            }
                        }
                    }

                    champions.Sort((Player firstPlayer, Player secondPlayer) => secondPlayer.Name.CompareTo(firstPlayer.Name));
                    champions.Sort((Player firstPlayer, Player secondPlayer) => secondPlayer.Points.CompareTo(firstPlayer.Points));
                    ScoreResult(champions);

                    gameField = CreateGameField();
                    mines = SetTheBombs();
                    scoreCounter = 0;
                    isExploded = false;
                    isNewGame = true;
                }

                if (isGameOver)
                {
                    Console.WriteLine("\nBRAVO!!! You managed to open all 35 tiles that are bomb free!!! Congratulations!!!.");
                    DrawGameField(mines);
                    Console.WriteLine("Please enter your nickname: ");
                    var nickname = Console.ReadLine();
                    Player points = new Player(nickname, scoreCounter);
                    champions.Add(points);
                    ScoreResult(champions);
                    gameField = CreateGameField();
                    mines = SetTheBombs();
                    scoreCounter = 0;
                    isGameOver = false;
                    isNewGame = true;
                }
            }
            while (command != "exit");

            Console.WriteLine("Made in Bulgaria - Uauahahahahaha!");
            Console.Read();
        }

        private static void ScoreResult(List<Player> champions)
        {
            Console.WriteLine("\nPoints:");
            if (champions.Count > 0)
            {
                for (int i = 0; i < champions.Count; i++)
                {
                    Console.WriteLine($"{i + 1}. {champions[i].Name} --> {champions[i].Points} Points");
                }

                Console.WriteLine();
            }
            else
            {
                Console.WriteLine("No Score!!!\n");
            }
        }

        private static void YourTurn(char[,] gameField, char[,] mines, int row, int column)
        {
            var minesCount = MinesCount(mines, row, column);
            mines[row, column] = minesCount;
            gameField[row, column] = minesCount;
        }

        private static void DrawGameField(char[,] gameField)
        {
            var rows = gameField.GetLength(0);
            var columns = gameField.GetLength(1);

            Console.WriteLine("\n    0 1 2 3 4 5 6 7 8 9");
            Console.WriteLine("   ---------------------");

            for (int i = 0; i < rows; i++)
            {
                Console.Write($"{i} | ");

                for (int j = 0; j < columns; j++)
                {
                    Console.Write($"{gameField[i, j]} ");
                }

                Console.Write("|");
                Console.WriteLine();
            }

            Console.WriteLine("   ---------------------\n");
        }

        private static char[,] CreateGameField()
        {
            int gameFieldRows = 5;
            int gameFieldColumns = 10;

            char[,] gameField = new char[gameFieldRows, gameFieldColumns];

            for (int i = 0; i < gameFieldRows; i++)
            {
                for (int j = 0; j < gameFieldColumns; j++)
                {
                    gameField[i, j] = '?';
                }
            }

            return gameField;
        }

        private static char[,] SetTheBombs()
        {
            int gameFieldRows = 5;
            int gameFieldColumns = 10;

            char[,] gameField = new char[gameFieldRows, gameFieldColumns];

            for (int i = 0; i < gameFieldRows; i++)
            {
                for (int j = 0; j < gameFieldColumns; j++)
                {
                    gameField[i, j] = '-';
                }
            }

            List<int> mines = new List<int>();
            while (mines.Count < 15)
            {
                Random random = new Random();
                int randonNumber = random.Next(50);
                if (!mines.Contains(randonNumber))
                {
                    mines.Add(randonNumber);
                }
            }

            foreach (int mine in mines)
            {
                int column = mine / gameFieldColumns;
                int row = mine % gameFieldColumns;

                if (row == 0 && mine != 0)
                {
                    column--;
                    row = gameFieldColumns;
                }
                else
                {
                    row++;
                }

                gameField[column, row - 1] = '*';
            }

            return gameField;
        }

        private static void NeighbourMinesCount(char[,] gameField)
        {
            int columns = gameField.GetLength(0);
            int rows = gameField.GetLength(1);

            for (int i = 0; i < columns; i++)
            {
                for (int j = 0; j < rows; j++)
                {
                    if (gameField[i, j] != '*')
                    {
                        char kolkoo = MinesCount(gameField, i, j);
                        gameField[i, j] = kolkoo;
                    }
                }
            }
        }

        private static char MinesCount(char[,] gameField, int row, int column)
        {
            int mineNumber = 0;
            int rows = gameField.GetLength(0);
            int columns = gameField.GetLength(1);

            if (row - 1 >= 0)
            {
                if (gameField[row - 1, column] == '*')
                {
                    mineNumber++;
                }
            }

            if (row + 1 < rows)
            {
                if (gameField[row + 1, column] == '*')
                {
                    mineNumber++;
                }
            }

            if (column - 1 >= 0)
            {
                if (gameField[row, column - 1] == '*')
                {
                    mineNumber++;
                }
            }

            if (column + 1 < columns)
            {
                if (gameField[row, column + 1] == '*')
                {
                    mineNumber++;
                }
            }

            if ((row - 1 >= 0) && (column - 1 >= 0))
            {
                if (gameField[row - 1, column - 1] == '*')
                {
                    mineNumber++;
                }
            }

            if ((row - 1 >= 0) && (column + 1 < columns))
            {
                if (gameField[row - 1, column + 1] == '*')
                {
                    mineNumber++;
                }
            }

            if ((row + 1 < rows) && (column - 1 >= 0))
            {
                if (gameField[row + 1, column - 1] == '*')
                {
                    mineNumber++;
                }
            }

            if ((row + 1 < rows) && (column + 1 < columns))
            {
                if (gameField[row + 1, column + 1] == '*')
                {
                    mineNumber++;
                }
            }

            return char.Parse(mineNumber.ToString());
        }
    }
}
