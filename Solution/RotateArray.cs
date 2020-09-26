using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;
using System.Text;

namespace Solution
{
    public class RotateArray
    {
        public void Rotate(int[] nums, int k)
        {
            //Solution 2
            var head =nums.First(); 
            var tail = nums.Last(); // n is the tail
            for (int i = 0; i < k; i++)
            {
                
               

            }
            //Solution 1
            //var n = nums[nums.Length - 1]; // n is the tail
            //for (int i = 0; i < k; i++)
            //{
            //    for ( int j = 0; j < nums.Length-1; j++)
            //    {

            //      nums[nums.Length - j - 1] = nums[nums.Length - j - 2];
            //      nums[nums.Length - j - 2] = n;
            //    }
               

            //    n = nums[nums.Length - 1];
            //}
        }
        public void Factorial(int num)
        {
            var fact = 1;
               
            for (int i = 1; i < 300; i++)
            {

                fact *= i;
                if(fact != 0 && fact > 0)
                Console.WriteLine(fact);
            } 

            

        }
    }
}
