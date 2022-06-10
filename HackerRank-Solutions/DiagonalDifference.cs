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
     * Complete the 'diagonalDifference' function below.
     *
     * The function is expected to return an INTEGER.
     * The function accepts 2D_INTEGER_ARRAY arr as parameter.
     */

    public static int diagonalDifference(List<List<int>> arr)
    {
        var firstDiagonal = GetLeftToRightDiagonalSum(arr);
        var secondDiagonal = GetRightToLeftDiagonalSum(arr);
        var diff = Math.Abs(firstDiagonal - secondDiagonal);
        return diff;
    }
    private static int GetLeftToRightDiagonalSum(List<List<int>> arr)
    {
        var sum = 0;
        for (int i = 0; i < arr.Count; i++)
        {
            for (int k = 0; k < arr[0].Count; k++)
            {
                if (i == k)
                {
                    sum += arr[i][k];
                    break;
                }
            }
        }
        return sum;
    }
    private static int GetRightToLeftDiagonalSum(List<List<int>> arr)
    {
        var sum = 0;
        for (int i = 0; i < arr.Count; i++)
        {
            for (int k = 0; k < arr[0].Count; k++)
            {
                if (k == arr[0].Count - 1 - i)
                {
                    sum += arr[i][k];
                    break;
                }
            }
        }
        return sum;
    }
}

class Solution
{
    public static void Main(string[] args)
    {
        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        int n = Convert.ToInt32(Console.ReadLine().Trim());

        List<List<int>> arr = new List<List<int>>();

        for (int i = 0; i < n; i++)
        {
            arr.Add(Console.ReadLine().TrimEnd().Split(' ').ToList().Select(arrTemp => Convert.ToInt32(arrTemp)).ToList());
        }

        int result = Result.diagonalDifference(arr);

        textWriter.WriteLine(result);

        textWriter.Flush();
        textWriter.Close();
    }
}