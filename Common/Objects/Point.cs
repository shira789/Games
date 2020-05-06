using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common
{
    public class Point
    {
       public uint X { get; set; }
       public uint Y { get; set; }

        public Point() {; }
        public Point (uint x, uint y)
        {
            X = x;
            Y = y;
        }

        public bool IsEqual(Point point)
        {
            if (point != null)
            {
                return point.X == X && point.Y == Y;
            }
            return false;
        }
        
        public Point GetHighestPoint(Point point)
        {
            if (IsEqual(point))
            {
                return null;
            }
            else if (point.X < X)
            {
                return this;
            }
            else
            {
                return point;
            }
        }

        public Point GetRightPoint(Point point)
        {
            if (IsEqual(point))
            {
                return null;
            }

            else if (point.Y < Y)
            {
                return this;
            }
            else
            {
                return point;
            }
        }
    } 

}
