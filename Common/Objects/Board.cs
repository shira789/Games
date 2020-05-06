using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common
{
    public class Board
    {
        public Square[,] Matrix { get; set; }
        public Board(int matrixSize)
        {
            Matrix = new Square[matrixSize+2, matrixSize+2];

            for (uint x = 0; x <= matrixSize+1; x++)
            {
                for (uint y = 0; y <= matrixSize+1; y++)
                {
                    Matrix[x, y] = new Square(x, y);  
                }
            }
        }
    }
}

