using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Threading
{
    class GenerateNumbersTask
    {
        private static Random random = new Random();

        public int[] Numbers { get; set; }

        public int StartIndex { get; set; }
        public int Count      { get; set; }

        public void GenerateNumbers()
        {
            for (int i = StartIndex; i < StartIndex + Count; ++i)
                Numbers[i] = random.Next(100);
        }
    }
}
