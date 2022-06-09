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
     * Complete the 'plusMinus' function below.
     *
     * The function accepts INTEGER_ARRAY arr as parameter.
     */

    public static void plusMinus(List<int> arr)
    {
        var count = arr.Count;
        double pos = 0, neg = 0, zero = 0;
        for (int i = 0; i < count; i++)
        {
            if (arr[i] < 0)
                neg++;
            else if (arr[i] > 0)
                pos++;
            else
                zero++;
        }
        pos = 1 / (count / pos);
        neg = 1 / (count / neg);
        zero = 1 / (count / zero);
        Console.WriteLine(string.Format("{0:F6}", pos));
        Console.WriteLine(string.Format("{0:F6}", neg));
        Console.WriteLine(string.Format("{0:F6}", zero));
    }
}

class Solution
{
    public static void Main(string[] args)
    {
        int n = Convert.ToInt32(Console.ReadLine().Trim());

        List<int> arr = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(arrTemp => Convert.ToInt32(arrTemp)).ToList();

        Result.plusMinus(arr);
    }
}
