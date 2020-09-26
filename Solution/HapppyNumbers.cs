using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Solution
{
   public class HapppyNumbers
    {
        public bool IsHappy(int n)
        {
            bool val = true;
            int v = n.ToString().Length;
            while(v > 0) { 
            var s = n % 10;
                //var q = (s * s);
               n = n / 10;
                v--;

            }

            ////foreach (var item in arr)
            ////{
            ////    Console.WriteLine(item);
            ////}
            //Console.WriteLine(arr.Length);
            return val;
        }
    }
}
