using Common.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common
{
    public class Player
    {
        public Submarine[] Submarines;
        public Board MyBoard;
        public Board EnemyBoard;

        public Player()
        {
            Submarines = new Submarine[Config.NumOfSubmarine];
            for(int i = 0 ;i<Config.NumOfSubmarine ;i++)
            {
                Submarines[i] = new Submarine(Config.SubmarinesSizes[i]); 
            }

            MyBoard = new Board(Config.MatrixSize);
        }
    }
}