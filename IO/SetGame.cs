using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Common;
using IO.Helpers;

namespace IO
{
    static public class SetGame
    {

        public static void Introduction(Player player)
        {
            Console.WriteLine("Welcome to the Submarine Game! this is your board, and your submarine Territory.\n");
            PrintObject.Board(player.MyBoard.Matrix);
        }

        public static void SetUp()
        {
            Console.WriteLine("first locate your submarines on the board. \nthe rules are:\n" +
                "1. can only be located in a vertical or horizontal way(not in diagonally)" +
                "2. around each submarine there are framework of territorial water,\n  wich it means you cannot locate another submarine in that area");
            Console.WriteLine("\nTo locate a submarine write the dots on both ends" +
                "in this format:\n x,y {Press Enter}\n x,y {Press Enter}");
        }

        public static Point[] GetSubmarineEdgePoints(Submarine submarine, Square[,] matrix, string message = null)
        {
            Point[] endPoints = new Point[2];
            Console.WriteLine(message + "\n");

            Console.WriteLine("Place the following Submarine:\t");
            PrintObject.Submarine(submarine.Size);
            PrintObject.Board(matrix);

            for (int i = 0; i < 2; i++)
            {
                endPoints[i] = new Point();
                InputPoint.GetPoint(ref endPoints[i]);

                if (endPoints[0] == endPoints[1] && endPoints[0] != null)
                {
                    Console.WriteLine("Choose 2 different points from each other");
                    i = 0;
                }
            }

            return endPoints;
        }
    }
}