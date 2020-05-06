using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common.Helpers
{
    public static class Config
    {

        internal readonly static int NumOfSubmarine;
        internal readonly static int[] SubmarinesSizes;
        public readonly static int MatrixSize;

        static Config()
        {
            NumOfSubmarine = Int32.Parse(ConfigurationManager.AppSettings["NumOfSubmarines"]);
            SubmarinesSizes = ConfigurationManager.AppSettings["SubmarinesSize"].Split(',').Select(n => Convert.ToInt32(n)).ToArray();
            MatrixSize = Int32.Parse(ConfigurationManager.AppSettings["MatrixSize"]);
        }
    }
}
