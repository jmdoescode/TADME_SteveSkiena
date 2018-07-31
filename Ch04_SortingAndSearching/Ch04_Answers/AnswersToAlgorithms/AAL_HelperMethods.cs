using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ch04
{
    public static class AAL_HelperMethods
    {
        public static int[] CreateRandomIntArray(int lowBound = 0, int highBound = 10000)
        {
            Random rnd = new Random();
            int len = rnd.Next(lowBound, highBound);

            int[] arr = new int[len];

            while(len > 0)
            {
                arr[len-1] = rnd.Next(lowBound, highBound);
                len--;
            }

            return arr;
        }
    }
}
