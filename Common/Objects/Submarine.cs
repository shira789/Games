using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common
{
    public class Submarine
    { 
        public Point[] Territory { get; set; }
        public bool IsAlive { get; set; }
        public int Size { get; set; }

        public Submarine(int size)
        {
            IsAlive = true;
            Size = size;
            Territory = new Point[size];
        }
    }
}