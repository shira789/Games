using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common
{
    public class Square
    {
        public bool IsSubmarine { get; set; }
        public bool IsHitted { get; set; }
        public bool IsAccessiable { get; set; }
        public Point Location { get; set; }

        public Square(uint x, uint y)
        {
            IsAccessiable = true;
            IsHitted = false;
            IsSubmarine = false;
            Location = new Point(x, y);
        }
    }
}