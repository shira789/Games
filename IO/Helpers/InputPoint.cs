using Common;
using Common.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IO.Helpers
{
    class InputPoint
    {
        internal static void GetPoint(ref Point point)
        {
            bool flag;
            do
            {
                flag = true;
                string str;
                string[] input = null;
                do
                {
                    str = Console.ReadLine();
                    if (!str.Contains(','))
                    {
                        flag = false; continue;
                    }

                    input = str.Split(',');
                    flag = true;
                } while (!flag);


                point.X = TryParseInputToInteger(input[0], ref flag);
                point.Y = TryParseInputToInteger(input[1], ref flag);

                if (!flag)
                {
                    Console.WriteLine("\n -> Enter Number");
                    continue;
                }

                flag &= IsPointOnBoard(point);
                if (!flag)
                {
                    Console.WriteLine("\n -> Value is out of range");
                    continue;
                }

            } while (flag == false);

        }

        private static bool IsPointOnBoard(Point point)
        {
            return (point.X <= Config.MatrixSize && point.Y <= Config.MatrixSize)
                        && (point.X > 0 && point.Y > 0);
        }

        private static uint TryParseInputToInteger(string input, ref bool success)
        {
            uint number;
            success &= UInt32.TryParse(input, out number);
            return number;
        }
    }
}
