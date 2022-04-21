using System;

namespace Pacmencoba
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "||||Game Pacmen||||";
            // Buat map
            int[,] letak = new int[11, 21];
            letak[0, 0] = 1;
            letak[0, 1] = 1;
            letak[0, 2] = 1;
            letak[0, 3] = 1;
            letak[0, 4] = 1;
            letak[0, 5] = 1;
            letak[0, 6] = 1;
            letak[0, 7] = 1;
            letak[0, 8] = 1;
            letak[0, 9] = 1;
            letak[0, 10] = 1;
            letak[0, 11] = 1;
            letak[0, 12] = 1;
            letak[0, 13] = 1;
            letak[0, 14] = 1;
            letak[0, 15] = 1;
            letak[0, 16] = 1;
            letak[0, 17] = 1;
            letak[0, 18] = 1;
            letak[0, 19] = 1;
            letak[0, 20] = 1;
            letak[1, 0] = 2;
            letak[1, 2] = 3;
            letak[1, 4] = 3;
            letak[1, 6] = 3;
            letak[1, 8] = 3;
            letak[1, 10] = 2;
            letak[1, 12] = 3;
            letak[1, 14] = 3;
            letak[1, 16] = 3;
            letak[1, 18] = 6;
            letak[1, 20] = 2;
            letak[2, 0] = 2;
            letak[2, 2] = 3;
            letak[2, 4] = 1;
            letak[2, 5] = 1;
            letak[2, 6] = 1;
            letak[2, 8] = 3;
            letak[2, 10] = 2;
            letak[2, 12] = 3;
            letak[2, 14] = 1;
            letak[2, 15] = 1;
            letak[2, 16] = 1;
            letak[2, 18] = 3;
            letak[2, 20] = 2;
            letak[3, 0] = 2;
            letak[3, 2] = 3;
            letak[3, 4] = 2;
            letak[3, 6] = 3;
            letak[3, 8] = 3;
            letak[3, 10] = 3;
            letak[3, 12] = 3;
            letak[3, 14] = 3;
            letak[3, 16] = 2;
            letak[3, 18] = 3;
            letak[3, 20] = 2;
            letak[4, 0] = 2;
            letak[4, 2] = 3;
            letak[4, 4] = 2;
            letak[4, 6] = 3;
            letak[4, 8] = 1;
            letak[4, 9] = 1;
            letak[4, 10] = 1;
            letak[4, 11] = 1;
            letak[4, 12] = 1;
            letak[4, 14] = 3;
            letak[4, 16] = 2;
            letak[4, 18] = 3;
            letak[4, 20] = 2;
            letak[5, 0] = 2;
            letak[5, 2] = 3;
            letak[5, 4] = 3;
            letak[5, 6] = 3;
            letak[5, 14] = 3;
            letak[5, 16] = 3;
            letak[5, 18] = 3;
            letak[5, 20] = 2;
            letak[6, 0] = 2;
            letak[6, 2] = 3;
            letak[6, 4] = 2;
            letak[6, 6] = 3;
            letak[6, 8] = 1;
            letak[6, 9] = 1;
            letak[6, 10] = 1;
            letak[6, 11] = 1;
            letak[6, 12] = 1;
            letak[6, 14] = 3;
            letak[6, 16] = 2;
            letak[6, 18] = 3;
            letak[6, 20] = 2;
            letak[7, 0] = 2;
            letak[7, 2] = 3;
            letak[7, 4] = 2;
            letak[7, 6] = 3;
            letak[7, 8] = 3;
            letak[7, 10] = 3;
            letak[7, 12] = 3;
            letak[7, 14] = 3;
            letak[7, 16] = 2;
            letak[7, 18] = 3;
            letak[7, 20] = 2;
            letak[8, 0] = 2;
            letak[8, 2] = 3;
            letak[8, 4] = 1;
            letak[8, 5] = 1;
            letak[8, 6] = 1;
            letak[8, 8] = 3;
            letak[8, 10] = 2;
            letak[8, 12] = 3;
            letak[8, 14] = 1;
            letak[8, 15] = 1;
            letak[8, 16] = 1;
            letak[8, 18] = 3;
            letak[8, 20] = 2;
            letak[9, 0] = 2;
            letak[9, 2] = 4;
            letak[9, 4] = 3;
            letak[9, 6] = 3;
            letak[9, 8] = 3;
            letak[9, 10] = 2;
            letak[9, 12] = 3;
            letak[9, 14] = 3;
            letak[9, 16] = 3;
            letak[9, 18] = 3;
            letak[9, 20] = 2;
            letak[10, 0] = 1;
            letak[10, 1] = 1;
            letak[10, 2] = 1;
            letak[10, 3] = 1;
            letak[10, 4] = 1;
            letak[10, 5] = 1;
            letak[10, 6] = 1;
            letak[10, 7] = 1;
            letak[10, 8] = 1;
            letak[10, 9] = 1;
            letak[10, 10] = 1;
            letak[10, 11] = 1;
            letak[10, 12] = 1;
            letak[10, 13] = 1;
            letak[10, 14] = 1;
            letak[10, 15] = 1;
            letak[10, 16] = 1;
            letak[10, 17] = 1;
            letak[10, 18] = 1;
            letak[10, 19] = 1;
            letak[10, 20] = 1;
            letak[1, 1] = 2;
            letak[2, 1] = 2;
            letak[3, 1] = 2;
            letak[4, 1] = 2;
            letak[5, 1] = 2;
            letak[6, 1] = 2;
            letak[7, 1] = 2;
            letak[8, 1] = 2;
            letak[9, 1] = 2;
            letak[2, 3] = 2;
            letak[3, 3] = 2;
            letak[4, 3] = 2;
            letak[6, 3] = 2;
            letak[7, 3] = 2;
            letak[8, 3] = 2;
            letak[3, 5] = 2;
            letak[4, 5] = 2;
            letak[1, 11] = 2;
            letak[2, 11] = 2;
            letak[8, 11] = 2;
            letak[9, 11] = 2;
            letak[2, 13] = 2;
            letak[4, 13] = 2;
            letak[6, 13] = 2;
            letak[8, 13] = 2;
            letak[3, 15] = 2;
            letak[4, 15] = 2;
            letak[6, 15] = 2;
            letak[7, 15] = 2;
            letak[2, 17] = 2;
            letak[3, 17] = 2;
            letak[4, 17] = 2;
            letak[6, 17] = 2;
            letak[7, 17] = 2;
            letak[8, 17] = 2;
            letak[1, 9] = 2;
            letak[2, 9] = 2;
            letak[8, 9] = 2;
            letak[9, 9] = 2;
            letak[8, 7] = 2;
            letak[2, 7] = 2;
            letak[4, 7] = 2;
            letak[6, 7] = 2;
            letak[6, 5] = 2;
            letak[7, 5] = 2;
            letak[1, 19] = 2;
            letak[2, 19] = 2;
            letak[3, 19] = 2;
            letak[4, 19] = 2;
            letak[5, 19] = 2;
            letak[6, 19] = 2;
            letak[7, 19] = 2;
            letak[8, 19] = 2;
            letak[9, 19] = 2;
            letak[5, 10] = 5;

            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.WriteLine("  -----------  ");
            Console.WriteLine("~ P A C M A N ~");
            Console.WriteLine("  -----------  ");
            Console.WriteLine("");
            Console.ForegroundColor = ConsoleColor.Black;
            Console.BackgroundColor = ConsoleColor.DarkCyan;
            Console.WriteLine("  Menu  Utama  ");
            Console.WriteLine();
            Console.WriteLine("   1. Start    ");
            Console.WriteLine();
            Console.WriteLine("   2. Exit     ");
            Console.WriteLine();
            Console.Write("   Pilihan :  ");
            int h = Convert.ToInt32(Console.ReadLine());
            Console.BackgroundColor = ConsoleColor.Black;
            Console.Clear();
            if (h == 1)
            {
                // cetak map
                for (int i = 0; i < 11; i++)
                {
                    for (int j = 0; j < 21; j++)
                    {
                        if (letak[i, j] == 0)
                        {
                            Console.Write(" ");
                        }
                        if (letak[i, j] == 1)
                        {
                            Console.ForegroundColor = ConsoleColor.Blue;
                            Console.Write("-");
                        }
                        if (letak[i, j] == 2)
                        {
                            Console.ForegroundColor = ConsoleColor.Blue;
                            Console.Write("|");
                        }
                        if (letak[i, j] == 3)
                        {
                            Console.ForegroundColor = ConsoleColor.White;
                            Console.Write(".");
                        }
                        if (letak[i, j] == 4)
                        {
                            Console.ForegroundColor = ConsoleColor.Yellow;
                            Console.Write("V");
                        }
                        if (letak[i, j] == 5)
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.Write("M");
                        }
                        if (letak[i, j] == 6)
                        {
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.Write("o");
                        }
                    }
                    Console.WriteLine();
                }
                ConsoleKey Keyinfo = Console.ReadKey(true).Key;
                int hantu1col = 10;
                int hantu1row = 5;
                int a = 0;
                int column = 2;
                int row = 9;
                int score = 0;
                int HK = 0;
                int lives = 3;

                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.SetCursorPosition(0, 12);
                Console.Write("Score : " + score);
                Console.SetCursorPosition(12, 12);
                Console.Write("Lives : " + lives);
                do
                {
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    ConsoleKey Keyold = Keyinfo;
                    int columnold = column;
                    int rowold = row;
                    int hantu1colold = hantu1col;
                    int hantu1rowold = hantu1row;

                    //baca key
                    if (Console.KeyAvailable)
                    {
                        Keyinfo = Console.ReadKey(true).Key;
                    }

                    //Menentukan gerakan pacman
                    switch (Keyinfo)
                    {
                        case ConsoleKey.RightArrow:
                            if (letak[row, column + 1] == 1 || letak[row, column + 1] == 2)
                            {
                                Keyinfo = Keyold;
                            }

                            break;
                        case ConsoleKey.LeftArrow:
                            if (letak[row, column - 1] == 1 || letak[row, column - 1] == 2)
                            {
                                Keyinfo = Keyold;
                            }
                            break;
                        case ConsoleKey.UpArrow:
                            if (letak[row - 1, column] == 1 || letak[row - 1, column] == 2)
                            {
                                Keyinfo = Keyold;
                            }
                            break;
                        case ConsoleKey.DownArrow:
                            if (letak[row + 1, column] == 1 || letak[row + 1, column] == 2)
                            {
                                Keyinfo = Keyold;
                            }
                            break;
                    }

                    // cetak gerak pacman
                    if (Keyinfo == ConsoleKey.RightArrow)
                    {
                        if (letak[row, column + 1] != 1 && letak[row, column + 1] != 2)
                        {
                            if (letak[row, column + 1] == 3)
                            {
                                score++;
                                Console.SetCursorPosition(8, 12);
                                Console.Write(score);
                            }
                            column++;
                            Console.SetCursorPosition(column, row);
                            Console.ForegroundColor = ConsoleColor.Yellow;
                            Console.Write("<");
                            Console.SetCursorPosition(columnold, rowold);
                            Console.Write(" ");
                            letak[rowold, columnold] = 0;
                        }
                    }
                    if (Keyinfo == ConsoleKey.LeftArrow)
                    {
                        if (letak[row, column - 1] != 1 && letak[row, column - 1] != 2)
                        {
                            if (letak[row, column - 1] == 3)
                            {
                                score++;
                                Console.SetCursorPosition(8, 12);
                                Console.Write(score);
                            }
                            column--;
                            Console.SetCursorPosition(column, row);
                            Console.ForegroundColor = ConsoleColor.Yellow;
                            Console.Write(">");
                            Console.SetCursorPosition(columnold, rowold);
                            Console.Write(" ");
                            letak[rowold, columnold] = 0;
                        }
                    }
                    if (Keyinfo == ConsoleKey.UpArrow)
                    {
                        if (letak[row - 1, column] != 1 && letak[row - 1, column] != 2)
                        {
                            if (letak[row - 1, column] == 3)
                            {
                                score++;
                                Console.SetCursorPosition(8, 12);
                                Console.Write(score);
                            }
                            row--;
                            Console.SetCursorPosition(column, row);
                            Console.ForegroundColor = ConsoleColor.Yellow;
                            Console.Write("V");
                            Console.SetCursorPosition(columnold, rowold);
                            Console.Write(" ");
                            letak[rowold, columnold] = 0;
                        }
                    }
                    if (Keyinfo == ConsoleKey.DownArrow)
                    {
                        if (letak[row + 1, column] != 1 && letak[row + 1, column] != 2)
                        {
                            if (letak[row + 1, column] == 3)
                            {
                                score++;
                                Console.SetCursorPosition(8, 12);
                                Console.Write(score);
                            }
                            row++;
                            Console.SetCursorPosition(column, row);
                            Console.ForegroundColor = ConsoleColor.Yellow;
                            Console.Write("^");
                            Console.SetCursorPosition(columnold, rowold);
                            Console.Write(" ");
                            letak[rowold, columnold] = 0;
                        }
                    }

                    //menentukan gerak hantu
                    if (HK == 0)
                    {
                        if (Math.Abs(column - hantu1col) <= Math.Abs(row - hantu1row))
                        {
                            if (column <= hantu1col)
                            {
                                HK = 1;
                            }
                            else
                            {
                                HK = 2;
                            }
                        }
                        else
                        {
                            if (row <= hantu1row)
                            {
                                HK = 3;
                            }
                            else
                            {
                                HK = 4;
                            }
                        }
                    }
                    if (HK == 1)
                    {
                        if (hantu1col <= column || letak[hantu1row, hantu1col - 1] == 1 || letak[hantu1row, hantu1col - 1] == 2)
                        {
                            if (row <= hantu1row && letak[hantu1row - 1, hantu1col] != 1 && letak[hantu1row - 1, hantu1col] != 2)
                            {
                                HK = 3;
                            }
                            if (row > hantu1row && letak[hantu1row + 1, hantu1col] != 1 && letak[hantu1row + 1, hantu1col] != 2)
                            {
                                HK = 4;
                            }
                            if (HK == 1 && (letak[hantu1row, hantu1col - 1] == 2 || letak[hantu1row, hantu1col - 1] == 1))
                            {
                                if (letak[hantu1row - 1, hantu1col] != 1 && letak[hantu1row - 1, hantu1col] != 2)
                                {
                                    HK = 3;
                                }
                                if (letak[hantu1row + 1, hantu1col] != 1 && letak[hantu1row + 1, hantu1col] != 2)
                                {
                                    HK = 4;
                                }
                            }
                        }
                    }
                    else
                    {
                        if (HK == 2)
                        {
                            if (column <= hantu1col || letak[hantu1row, hantu1col + 1] == 1 || letak[hantu1row, hantu1col + 1] == 2)
                            {
                                if (row <= hantu1row && letak[hantu1row - 1, hantu1col] != 1 && letak[hantu1row - 1, hantu1col] != 2)
                                {
                                    HK = 3;
                                }
                                if (row > hantu1row && letak[hantu1row + 1, hantu1col] != 1 && letak[hantu1row + 1, hantu1col] != 2)
                                {
                                    HK = 4;
                                }
                                if (HK == 2 && (letak[hantu1row, hantu1col + 1] == 2 || letak[hantu1row, hantu1col + 1] == 1))
                                {
                                    if (letak[hantu1row - 1, hantu1col] != 1 && letak[hantu1row - 1, hantu1col] != 2)
                                    {
                                        HK = 3;
                                    }
                                    if (letak[hantu1row + 1, hantu1col] != 1 && letak[hantu1row + 1, hantu1col] != 2)
                                    {
                                        HK = 4;
                                    }
                                }
                            }
                        }
                        else
                        {
                            if (HK == 3)
                            {
                                if (hantu1row <= row || letak[hantu1row - 1, hantu1col] == 1 || letak[hantu1row - 1, hantu1col] == 2)
                                {
                                    if (column <= hantu1col && letak[hantu1row, hantu1col - 1] != 1 && letak[hantu1row, hantu1col - 1] != 2)
                                    {
                                        HK = 1;
                                    }
                                    if (column > hantu1col && letak[hantu1row, hantu1col + 1] != 1 && letak[hantu1row, hantu1col + 1] != 2)
                                    {
                                        HK = 2;
                                    }
                                    if (HK == 3 && (letak[hantu1row - 1, hantu1col] == 2 || letak[hantu1row - 1, hantu1col] == 1))
                                    {
                                        if (letak[hantu1row, hantu1col - 1] != 1 && letak[hantu1row, hantu1col - 1] != 2)
                                        {
                                            HK = 1;
                                        }
                                        if (letak[hantu1row, hantu1col + 1] != 1 && letak[hantu1row, hantu1col + 1] != 2)
                                        {
                                            HK = 2;
                                        }
                                    }
                                }
                            }
                            else
                            {
                                if (HK == 4)
                                {
                                    if (row <= hantu1row || letak[hantu1row + 1, hantu1col] == 1 || letak[hantu1row + 1, hantu1col] == 2)
                                    {
                                        if (column <= hantu1col && letak[hantu1row, hantu1col - 1] != 1 && letak[hantu1row, hantu1col - 1] != 2)
                                        {
                                            HK = 1;
                                        }
                                        if (column > hantu1col && letak[hantu1row, hantu1col + 1] != 1 && letak[hantu1row, hantu1col + 1] != 2)
                                        {
                                            HK = 2;
                                        }
                                        if (HK == 4 && (letak[hantu1row + 1, hantu1col] == 2 || letak[hantu1row + 1, hantu1col] == 1))
                                        {
                                            if (letak[hantu1row, hantu1col - 1] != 1 && letak[hantu1row, hantu1col - 1] != 2)
                                            {
                                                HK = 1;
                                            }
                                            if (letak[hantu1row, hantu1col + 1] != 1 && letak[hantu1row, hantu1col + 1] != 2)
                                            {
                                                HK = 2;
                                            }
                                        }
                                    }
                                }
                            }
                        }
                    }

                    //cetak gerakan hantu
                    if (HK == 1)
                    {
                        hantu1col = hantu1col - 1;
                        Console.SetCursorPosition(hantu1col, hantu1row);
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.Write("M");
                        if (letak[hantu1rowold, hantu1colold] == 3)
                        {
                            Console.SetCursorPosition(hantu1colold, hantu1rowold);
                            Console.ForegroundColor = ConsoleColor.White;
                            Console.Write(".");
                        }
                        if (letak[hantu1rowold, hantu1colold] == 0 || letak[hantu1rowold, hantu1colold] == 5)
                        {
                            Console.SetCursorPosition(hantu1colold, hantu1rowold);
                            Console.Write(" ");
                        }
                        if (letak[hantu1rowold, hantu1colold] == 6)
                        {
                            Console.SetCursorPosition(hantu1colold, hantu1rowold);
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.Write("o");
                        }
                    }
                    if (HK == 2)
                    {
                        hantu1col = hantu1col + 1;
                        Console.SetCursorPosition(hantu1col, hantu1row);
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.Write("M");
                        if (letak[hantu1rowold, hantu1colold] == 3)
                        {
                            Console.SetCursorPosition(hantu1colold, hantu1rowold);
                            Console.ForegroundColor = ConsoleColor.White;
                            Console.Write(".");
                        }
                        if (letak[hantu1rowold, hantu1colold] == 0 || letak[hantu1rowold, hantu1colold] == 5)
                        {
                            Console.SetCursorPosition(hantu1colold, hantu1rowold);
                            Console.Write(" ");
                        }
                        if (letak[hantu1rowold, hantu1colold] == 6)
                        {
                            Console.SetCursorPosition(hantu1colold, hantu1rowold);
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.Write("o");
                        }
                    }
                    if (HK == 3)
                    {
                        hantu1row = hantu1row - 1;
                        Console.SetCursorPosition(hantu1col, hantu1row);
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.Write("M");
                        if (letak[hantu1rowold, hantu1colold] == 3)
                        {
                            Console.SetCursorPosition(hantu1colold, hantu1rowold);
                            Console.ForegroundColor = ConsoleColor.White;
                            Console.Write(".");
                        }
                        if (letak[hantu1rowold, hantu1colold] == 0 || letak[hantu1rowold, hantu1colold] == 5)
                        {
                            Console.SetCursorPosition(hantu1colold, hantu1rowold);
                            Console.Write(" ");
                        }
                        if (letak[hantu1rowold, hantu1colold] == 6)
                        {
                            Console.SetCursorPosition(hantu1colold, hantu1rowold);
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.Write("o");
                        }
                    }
                    if (HK == 4)
                    {
                        hantu1row = hantu1row + 1;
                        Console.SetCursorPosition(hantu1col, hantu1row);
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.Write("M");
                        if (letak[hantu1rowold, hantu1colold] == 3)
                        {
                            Console.SetCursorPosition(hantu1colold, hantu1rowold);
                            Console.ForegroundColor = ConsoleColor.White;
                            Console.Write(".");
                        }
                        if (letak[hantu1rowold, hantu1colold] == 0 || letak[hantu1rowold, hantu1colold] == 5)
                        {
                            Console.SetCursorPosition(hantu1colold, hantu1rowold);
                            Console.Write(" ");
                        }
                        if (letak[hantu1rowold, hantu1colold] == 6)
                        {
                            Console.SetCursorPosition(hantu1colold, hantu1rowold);
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.Write("o");
                        }
                    }

                    //hantu tabrak pacman
                    if ((hantu1col == column && hantu1row == row) || (hantu1colold == column && hantu1rowold == row))
                    {
                        lives--;
                        Console.SetCursorPosition(20, 12);
                        Console.ForegroundColor = ConsoleColor.Cyan;
                        Console.Write(lives);
                        Console.ResetColor();
                        if (lives == 0)
                        {
                            a++;
                            Console.Clear();
                            Console.SetCursorPosition(55, 15);
                            Console.ForegroundColor = ConsoleColor.Black;
                            Console.BackgroundColor = ConsoleColor.DarkCyan;
                            Console.WriteLine("YOU LOSE!!!");
                        }
                        else
                        {
                            Console.SetCursorPosition(hantu1col, hantu1row);
                            Console.Write(" ");
                            column = 2;
                            row = 9;
                            hantu1col = 10;
                            hantu1row = 5;
                            Console.SetCursorPosition(column, row);
                            Console.ForegroundColor = ConsoleColor.Yellow;
                            Console.Write("V");
                            Console.SetCursorPosition(hantu1col, hantu1row);
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.Write("M");
                            HK = 0;
                        }

                    }

                    //menang
                    if (score == 50)
                    {
                        a++;
                        Console.Clear();
                        Console.SetCursorPosition(55, 15);
                        Console.ForegroundColor = ConsoleColor.Black;
                        Console.BackgroundColor = ConsoleColor.DarkCyan;
                        Console.WriteLine("YOU WIN!!!");
                    }

                    //powerup
                    if (letak[row, column] == 6)
                    {
                        int e = 1;
                        HK = 0;
                        while (e <= 30)
                        {
                            Console.ForegroundColor = ConsoleColor.Cyan;
                            columnold = column;
                            rowold = row;
                            hantu1colold = hantu1col;
                            hantu1rowold = hantu1row;
                            Keyold = Keyinfo;
                            if (Console.KeyAvailable)
                            {
                                Keyinfo = Console.ReadKey(true).Key;
                            }

                            //menentukan gerak pacmen
                            switch (Keyinfo)
                            {
                                //Pacmen gerak
                                case ConsoleKey.RightArrow:
                                    if (letak[row, column + 1] == 1 || letak[row, column + 1] == 2)
                                    {
                                        Keyinfo = Keyold;
                                    }

                                    break;
                                case ConsoleKey.LeftArrow:
                                    if (letak[row, column - 1] == 1 || letak[row, column - 1] == 2)
                                    {
                                        Keyinfo = Keyold;
                                    }
                                    break;
                                case ConsoleKey.UpArrow:
                                    if (letak[row - 1, column] == 1 || letak[row - 1, column] == 2)
                                    {
                                        Keyinfo = Keyold;
                                    }
                                    break;
                                case ConsoleKey.DownArrow:
                                    if (letak[row + 1, column] == 1 || letak[row + 1, column] == 2)
                                    {
                                        Keyinfo = Keyold;
                                    }
                                    break;
                            }

                            //cetak gerak pacmen
                            if (Keyinfo == ConsoleKey.RightArrow)
                            {
                                if (letak[row, column + 1] != 1 && letak[row, column + 1] != 2)
                                {
                                    if (letak[row, column + 1] == 3)
                                    {
                                        score++;
                                        Console.SetCursorPosition(8, 12);
                                        Console.Write(score);
                                    }
                                    column++;
                                    Console.SetCursorPosition(column, row);
                                    Console.ForegroundColor = ConsoleColor.Yellow;
                                    Console.Write("<");
                                    Console.SetCursorPosition(columnold, rowold);
                                    Console.Write(" ");
                                    letak[rowold, columnold] = 0;
                                }
                            }
                            if (Keyinfo == ConsoleKey.LeftArrow)
                            {
                                if (letak[row, column - 1] != 1 && letak[row, column - 1] != 2)
                                {
                                    if (letak[row, column - 1] == 3)
                                    {
                                        score++;
                                        Console.SetCursorPosition(8, 12);
                                        Console.Write(score);
                                    }
                                    column--;
                                    Console.SetCursorPosition(column, row);
                                    Console.ForegroundColor = ConsoleColor.Yellow;
                                    Console.Write(">");
                                    Console.SetCursorPosition(columnold, rowold);
                                    Console.Write(" ");
                                    letak[rowold, columnold] = 0;
                                }
                            }
                            if (Keyinfo == ConsoleKey.UpArrow)
                            {
                                if (letak[row - 1, column] != 1 && letak[row - 1, column] != 2)
                                {
                                    if (letak[row - 1, column] == 3)
                                    {
                                        score++;
                                        Console.SetCursorPosition(8, 12);
                                        Console.Write(score);
                                    }
                                    row--;
                                    Console.SetCursorPosition(column, row);
                                    Console.ForegroundColor = ConsoleColor.Yellow;
                                    Console.Write("V");
                                    Console.SetCursorPosition(columnold, rowold);
                                    Console.Write(" ");
                                    letak[rowold, columnold] = 0;
                                }
                            }
                            if (Keyinfo == ConsoleKey.DownArrow)
                            {
                                if (letak[row + 1, column] != 1 && letak[row + 1, column] != 2)
                                {
                                    if (letak[row + 1, column] == 3)
                                    {
                                        score++;
                                        Console.SetCursorPosition(8, 12);
                                        Console.Write(score);
                                    }
                                    row++;
                                    Console.SetCursorPosition(column, row);
                                    Console.ForegroundColor = ConsoleColor.Yellow;
                                    Console.Write("^");
                                    Console.SetCursorPosition(columnold, rowold);
                                    Console.Write(" ");
                                    letak[rowold, columnold] = 0;
                                }
                            }

                            //arah hantu kabur 
                            if (e % 2 == 0)
                            {
                                if (HK == 0)
                                {
                                    if (Math.Abs(column - hantu1col) <= Math.Abs(row - hantu1row))
                                    {
                                        if (row >= hantu1row)
                                        {
                                            HK = 3;
                                        }
                                        else
                                        {
                                            HK = 4;
                                        }
                                    }
                                    else
                                    {
                                        if (column >= hantu1col)
                                        {
                                            HK = 1;
                                        }
                                        else
                                        {
                                            HK = 2;
                                        }
                                    }
                                }
                                if (HK == 1)
                                {
                                    if (hantu1col >= column || letak[hantu1row, hantu1col - 1] == 1 || letak[hantu1row, hantu1col - 1] == 2)
                                    {
                                        if (row > hantu1row && letak[hantu1row - 1, hantu1col] != 1 && letak[hantu1row - 1, hantu1col] != 2)
                                        {
                                            HK = 3;
                                        }
                                        if (row <= hantu1row && letak[hantu1row + 1, hantu1col] != 1 && letak[hantu1row + 1, hantu1col] != 2)
                                        {
                                            HK = 4;
                                        }
                                        if (HK == 1 && (letak[hantu1row, hantu1col - 1] == 2 || letak[hantu1row, hantu1col - 1] == 1))
                                        {
                                            if (letak[hantu1row - 1, hantu1col] != 1 && letak[hantu1row - 1, hantu1col] != 2)
                                            {
                                                HK = 3;
                                            }
                                            if (letak[hantu1row + 1, hantu1col] != 1 && letak[hantu1row + 1, hantu1col] != 2)
                                            {
                                                HK = 4;
                                            }
                                        }
                                    }
                                }
                                else
                                {
                                    if (HK == 2)
                                    {
                                        if (hantu1col <= column || letak[hantu1row, hantu1col + 1] == 1 || letak[hantu1row, hantu1col + 1] == 2)
                                        {
                                            if (row > hantu1row && letak[hantu1row - 1, hantu1col] != 1 && letak[hantu1row - 1, hantu1col] != 2)
                                            {
                                                HK = 3;
                                            }
                                            if (row <= hantu1row && letak[hantu1row + 1, hantu1col] != 1 && letak[hantu1row + 1, hantu1col] != 2)
                                            {
                                                HK = 4;
                                            }
                                            if (HK == 2 && (letak[hantu1row, hantu1col + 1] == 2 || letak[hantu1row, hantu1col + 1] == 1))
                                            {
                                                if (letak[hantu1row - 1, hantu1col] != 1 && letak[hantu1row - 1, hantu1col] != 2)
                                                {
                                                    HK = 3;
                                                }
                                                if (letak[hantu1row + 1, hantu1col] != 1 && letak[hantu1row + 1, hantu1col] != 2)
                                                {
                                                    HK = 4;
                                                }
                                            }
                                        }
                                    }
                                    else
                                    {
                                        if (HK == 3)
                                        {
                                            if (hantu1row >= row || letak[hantu1row - 1, hantu1col] == 1 || letak[hantu1row - 1, hantu1col] == 2)
                                            {
                                                if (column > hantu1col && letak[hantu1row, hantu1col - 1] != 1 && letak[hantu1row, hantu1col - 1] != 2)
                                                {
                                                    HK = 1;
                                                }
                                                if (column <= hantu1col && letak[hantu1row, hantu1col + 1] != 1 && letak[hantu1row, hantu1col + 1] != 2)
                                                {
                                                    HK = 2;
                                                }
                                                if (HK == 3 && (letak[hantu1row - 1, hantu1col] == 2 || letak[hantu1row - 1, hantu1col] == 1))
                                                {
                                                    if (letak[hantu1row, hantu1col - 1] != 1 && letak[hantu1row, hantu1col - 1] != 2)
                                                    {
                                                        HK = 1;
                                                    }
                                                    if (letak[hantu1row, hantu1col + 1] != 1 && letak[hantu1row, hantu1col + 1] != 2)
                                                    {
                                                        HK = 2;
                                                    }
                                                }
                                            }
                                        }
                                        else
                                        {
                                            if (HK == 4)
                                            {
                                                if (hantu1col <= column || letak[hantu1row + 1, hantu1col] == 1 || letak[hantu1row + 1, hantu1col] == 2)
                                                {
                                                    if (column > hantu1col && letak[hantu1row, hantu1col - 1] != 1 && letak[hantu1row, hantu1col - 1] != 2)
                                                    {
                                                        HK = 1;
                                                    }
                                                    if (column <= hantu1col && letak[hantu1row, hantu1col + 1] != 1 && letak[hantu1row, hantu1col + 1] != 2)
                                                    {
                                                        HK = 2;
                                                    }
                                                    if (HK == 4 && (letak[hantu1row + 1, hantu1col] == 2 || letak[hantu1row + 1, hantu1col] == 1))
                                                    {
                                                        if (letak[hantu1row, hantu1col - 1] != 1 && letak[hantu1row, hantu1col - 1] != 2)
                                                        {
                                                            HK = 1;
                                                        }
                                                        if (letak[hantu1row, hantu1col + 1] != 1 && letak[hantu1row, hantu1col + 1] != 2)
                                                        {
                                                            HK = 2;
                                                        }
                                                    }
                                                }
                                            }
                                        }
                                    }
                                }

                                //cetak hantu kabur
                                if (HK == 1)
                                {
                                    hantu1col = hantu1col - 1;
                                    Console.SetCursorPosition(hantu1col, hantu1row);
                                    Console.ForegroundColor = ConsoleColor.Magenta;
                                    Console.Write("M");
                                    if (letak[hantu1rowold, hantu1colold] == 3)
                                    {
                                        Console.SetCursorPosition(hantu1colold, hantu1rowold);
                                        Console.ForegroundColor = ConsoleColor.White;
                                        Console.Write(".");
                                    }
                                    if (letak[hantu1rowold, hantu1colold] == 0 || letak[hantu1rowold, hantu1colold] == 5)
                                    {
                                        Console.SetCursorPosition(hantu1colold, hantu1rowold);
                                        Console.Write(" ");
                                    }
                                }
                                if (HK == 2)
                                {
                                    hantu1col = hantu1col + 1;
                                    Console.SetCursorPosition(hantu1col, hantu1row);
                                    Console.ForegroundColor = ConsoleColor.Magenta;
                                    Console.Write("M");
                                    if (letak[hantu1rowold, hantu1colold] == 3)
                                    {
                                        Console.SetCursorPosition(hantu1colold, hantu1rowold);
                                        Console.ForegroundColor = ConsoleColor.White;
                                        Console.Write(".");
                                    }
                                    if (letak[hantu1rowold, hantu1colold] == 0 || letak[hantu1rowold, hantu1colold] == 5)
                                    {
                                        Console.SetCursorPosition(hantu1colold, hantu1rowold);
                                        Console.Write(" ");
                                    }

                                }
                                if (HK == 3)
                                {
                                    hantu1row = hantu1row - 1;
                                    Console.SetCursorPosition(hantu1col, hantu1row);
                                    Console.ForegroundColor = ConsoleColor.Magenta;
                                    Console.Write("M");
                                    if (letak[hantu1rowold, hantu1colold] == 3)
                                    {
                                        Console.SetCursorPosition(hantu1colold, hantu1rowold);
                                        Console.ForegroundColor = ConsoleColor.White;
                                        Console.Write(".");
                                    }
                                    if (letak[hantu1rowold, hantu1colold] == 0 || letak[hantu1rowold, hantu1colold] == 5)
                                    {
                                        Console.SetCursorPosition(hantu1colold, hantu1rowold);
                                        Console.Write(" ");
                                    }

                                }
                                if (HK == 4)
                                {
                                    hantu1row = hantu1row + 1;
                                    Console.SetCursorPosition(hantu1col, hantu1row);
                                    Console.ForegroundColor = ConsoleColor.Magenta;
                                    Console.Write("M");
                                    if (letak[hantu1rowold, hantu1colold] == 3)
                                    {
                                        Console.SetCursorPosition(hantu1colold, hantu1rowold);
                                        Console.ForegroundColor = ConsoleColor.White;
                                        Console.Write(".");
                                    }
                                    if (letak[hantu1rowold, hantu1colold] == 0 || letak[hantu1rowold, hantu1colold] == 5)
                                    {
                                        Console.SetCursorPosition(hantu1colold, hantu1rowold);
                                        Console.Write(" ");
                                    }

                                }
                            }

                            //hantu ditabrak pacmen
                            if ((hantu1col == column && hantu1row == row) || (hantu1colold == column && hantu1rowold == row))
                            {
                                Console.SetCursorPosition(hantu1col, hantu1row);
                                Console.Write(" ");
                                Console.SetCursorPosition(column, row);
                                Console.ForegroundColor = ConsoleColor.Yellow;
                                Console.Write("V");
                                HK = 5;
                            }

                            //menang
                            if (score == 50)
                            {
                                a++;
                                Console.Clear();
                                Console.SetCursorPosition(55, 15);
                                Console.ForegroundColor = ConsoleColor.Black;
                                Console.BackgroundColor = ConsoleColor.DarkCyan;
                                Console.WriteLine("YOU WIN!!!");
                            }

                            //cetak hantu di akhir perulangan
                            if (e == 30 && HK == 5)
                            {
                                HK = 0;
                                hantu1col = 10;
                                hantu1row = 5;
                                Console.SetCursorPosition(hantu1col, hantu1row);
                                Console.ForegroundColor = ConsoleColor.Red;
                                Console.Write("M");
                            }
                            System.Threading.Thread.Sleep(250);
                            e++;
                        }
                    }
                    //delay 250 milisecond
                    System.Threading.Thread.Sleep(250);
                } while (a == 0);
                Console.ReadKey();
            }
            else
            {
            }
        }
    }
}
