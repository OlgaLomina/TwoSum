using System;
using System.Collections;
/*Given an array of integers, return indices of the two numbers such that they add up to a specific target.

You may assume that each input would have exactly one solution, and you may not use the same element twice.

Example:

Given nums = [2, 7, 11, 15], target = 9,

Because nums[0] + nums[1] = 2 + 7 = 9,
return [0, 1].
* */
public class Solution
{
    public static int[] TwoSum(int[] nums, int target)
    {
        Hashtable hasht = new Hashtable();
        for (int i = 0; i < nums.Length; i++)
        {
            int value = target - nums[i];
            if (hasht.Contains(value))
                return new int[] { (int)hasht[value], i };
            if (!hasht.Contains(nums[i]))
                hasht.Add(nums[i], i);
        }
        return new int[] { };
    }

    public static void Main()
    {
        int[] array = new int[] { 230,863,863,430,803,59};
        int target = 9;

        int[] result = TwoSum(array, target);
        //Console.WriteLine(result == null);
        if (result.Length > 0)
            Console.WriteLine("[{0}, {1}]", result[0], result[1]);
        else
            Console.WriteLine("[]");

    }
}