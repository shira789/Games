using Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IO.Helpers
{
    static public class PrintObject
    {
        public static void Board(Square[,] matrix, bool myBoard = true)
        {
            for (int x = 0; x < matrix.GetLength(1) - 1; x++)
            {
                Console.Write(x + " ");
            }
            Console.WriteLine();

            for (int x = 1; x < matrix.GetLength(0) - 1; x++) //raws
            {
                Console.Write(x + " ");

                for (int y = 1; y < matrix.GetLength(1) - 1; y++)//columns
                {
                    if (!myBoard) //EnemyBoard
                    {
                        if (matrix[x, y].IsHitted)
                            if (matrix[x, y].IsSubmarine)
                            { Console.Write("*"); }
                            else
                            { Console.Write("/"); }
                        else
                        { Console.Write("O"); }

                        Console.Write(" ");
                    }
                    else
                    {
                        if (!matrix[x, y].IsAccessiable)
                        {
                            if (matrix[x, y].IsSubmarine)
                            { Console.Write("*"); }
                            else
                            { Console.Write("/"); }
                        }
                        else
                        { Console.Write("O"); }
                    }
                    Console.Write(" ");
                }

                Console.WriteLine("");
            }
            Console.WriteLine("\nO - sea water" +
                "\n* - Submarine point ");
        }

        public static void Submarine(int size)
        {
            for (int i = 1; i <= size; i++)
            {
                Console.Write(" "+ i);
            }
            Console.WriteLine();
            for (int i = 0; i < size; i++)
            {
                Console.Write(" *");
            }
            Console.WriteLine("\n");
        }
    }
}
