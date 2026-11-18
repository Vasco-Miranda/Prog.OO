using System;
using System.Collections.Generic;
using System.Text;

namespace Cap3_Ex4_MinMax
{
    enum MinMaxEnum
    {
        Min,
        Max
    }

    internal class MathUtils
    {
        public int MinMax(int a, int b, MinMaxEnum type)
        {
            switch (type)
            {
                case MinMaxEnum.Min: return Math.Min(a, b);

                default: return Math.Max(a, b);
            }
            
        }

        public int MinMax(int a, int b, int c, MinMaxEnum type)
        {
            int[] arr = { a, b, c };
            switch (type)
            {
                case MinMaxEnum.Min: return arr.Min();

                default: return arr.Max();
            }

        }
    }
}
