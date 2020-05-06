using Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic
{
    public class PlaceSubmarine
    {
        private Board Matrix;
        private Point Point1;
        private Point Point2;
        private Submarine Submarine;  


        public PlaceSubmarine(ref Submarine submarine, Point point1, Point point2, Board board)
        { 
            Point1 = point1;
            Point2 = point2;
            Submarine = submarine;
            Matrix = board;
        }
        
        public bool IsPlaced()
        {
            if(TryToCreateHorizontalLine() || TryToCreateVerticalLine())
            {
                SetSubmarineFrame();
                return true;
            }
            return false;
        }
        


        private bool TryToCreateVerticalLine()
        {
            if (Point1.Y != Point2.Y) {return false; }
            
            if(Submarine.Size == (Point1.X - Point2.X +1) || Submarine.Size == (Point2.X - Point1.X)+1)
            {
                int highestX = (int)Point1.GetHighestPoint(Point2).X;
                int round = highestX - Submarine.Size;
                int index = Submarine.Size;

                for (int i = highestX; i > round ; i--)
                {
                    if (!Matrix.Matrix[(uint)i, Point1.Y].IsAccessiable) { return false; }
                       
                    Matrix.Matrix[(uint)i, Point1.Y].IsAccessiable = false;
                    Matrix.Matrix[(uint)i, Point1.Y].IsSubmarine = true;
                    Submarine.Territory[--index] = new Point((uint)i, Point1.Y); 
                }
                return true;
            }            
            return false;  
        }

        private bool TryToCreateHorizontalLine()
        {
            if (Point1.X != Point2.X) { return false; }

            if (Submarine.Size == (Point1.Y - Point2.Y+1) || Submarine.Size == (Point2.Y - Point1.Y)+1)
            {
                int rightY = (int) Point1.GetRightPoint(Point2).Y;
                int round = rightY - Submarine.Size;
                int index = Submarine.Size;
                for (int i = rightY; i > round; i--)
                {
                    if (!Matrix.Matrix[Point1.X, (uint)i].IsAccessiable) { return false; }

                    Matrix.Matrix[Point1.X, (uint)i].IsAccessiable = false;
                    Matrix.Matrix[Point1.X, (uint)i].IsSubmarine = true;
                    Submarine.Territory[--index] = new Point(Point1.X, (uint)i);
                }
                return true;
            }
            return false;
        }

        public void SetSubmarineFrame()
        {
            for (int i = 0; i < Submarine.Size; i++)
            {
                Point current = Submarine.Territory[i];
                Matrix.Matrix[current.X + 1, current.Y].IsAccessiable = false;
                Matrix.Matrix[current.X, current.Y - 1].IsAccessiable = false;
                Matrix.Matrix[current.X, current.Y + 1].IsAccessiable = false;
                Matrix.Matrix[current.X - 1, current.Y].IsAccessiable = false;
            }
        }
    }
}
