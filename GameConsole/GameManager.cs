using BusinessLogic;
using Common;
using IO;
using IO.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameConsole
{
    class GameManager
    {
        public Player PlayerA { get; set; }
        public Player PlayerB { get; set; }

        public GameManager()
        {
            PlayerA = new Player();
            PlayerB = new Player();
        }

        
        public void Start()
        {
            SetGame.Introduction(PlayerA);

            LocateSubmarinesOnBoard(PlayerA);

            AttackEnemy(PlayerA);
        }

        public void LocateSubmarinesOnBoard(Player player)
        {
            bool IsSuccess = true;
            string message = null;

            SetGame.SetUp();

            for (int i = 0; i < player.Submarines.Length; i++)
            {
                do
                {
                    if (!IsSuccess) { message = "Error Placing the submarine, try another points"; }
                    Point[] points = SetGame.GetSubmarineEdgePoints(player.Submarines[i], player.MyBoard.Matrix, message);
                    PlaceSubmarine placeTool = new PlaceSubmarine(ref player.Submarines[i], points[0], points[1], PlayerA.MyBoard);
                    IsSuccess = placeTool.IsPlaced();
                } while (!IsSuccess);
            }
            PrintObject.Board(PlayerA.MyBoard.Matrix);
        }

        public void AttackEnemy(Player player)
        {
            StartGame.Introduction(player.MyBoard);
        }
    }
}
