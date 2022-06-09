using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Collections;
using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.Serialization;
using System.Text.RegularExpressions;
using System.Text;
using System;

class Result
{

    /*
     * Complete the 'miniMaxSum' function below.
     *
     * The function accepts INTEGER_ARRAY arr as parameter.
     */

    public static void miniMaxSum(List<long> arr)
    {
        var min = FindTheMin(arr);
        var max = FindTheMax(arr);

        long minSum = 0, maxSum = 0;

        for (int i = 0, k = 0; i < arr.Count; i++)
        {
            if (arr[i] == max && k == 0)
            {
                k++;
                continue;
            }
            minSum += arr[i];
        }

        for (int i = 0, k = 0; i < arr.Count; i++)
        {
            if (arr[i] == min && k == 0)
            {
                k++;
                continue;
            }
            maxSum += arr[i];
        }

        Console.WriteLine($"{minSum} {maxSum}");
    }
    private static long FindTheMin(List<long> arr)
    {
        long min = arr[0];
        for (int i = 0; i < arr.Count; i++)
        {
            if (arr[i] < min)
            {
                min = arr[i];
            }
        }
        return min;
    }
    private static long FindTheMax(List<long> arr)
    {
        long max = arr[0];
        for (int i = 0; i < arr.Count; i++)
        {
            if (arr[i] > max)
            {
                max = arr[i];
            }
        }
        return max;
    }
}

class Solution
{
    public static void Main(string[] args)
    {

        List<long> arr = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(arrTemp => Convert.ToInt64(arrTemp)).ToList();

        Result.miniMaxSum(arr);
    }
}
