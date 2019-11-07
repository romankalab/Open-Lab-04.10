using System;


namespace Open_Lab_04._10
{
    public class Calculator
    {
        public float Average(int[] nums)
        {
            float solution = 0;
            for (var x = 0; x < nums.Length; x++)
                solution = solution + nums[x];

            solution = solution / nums.Length;
            return solution;
        }
    }
}