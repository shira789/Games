using Common;
using IO.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IO
{
    static public class StartGame
    {
        static public void Introduction(Board board)
        {
            Console.Clear();
            Console.WriteLine(" *********START*********\n");
            PrintObject.Board(board.Matrix);
            Console.WriteLine("\nYou have finished setting up the game!\n" +
                "Now choose a point from the enemy board to attack\n");

        }
    }
}
