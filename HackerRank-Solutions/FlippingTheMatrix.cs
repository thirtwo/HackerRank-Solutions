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
     * Complete the 'flippingMatrix' function below.
     *
     * The function is expected to return an INTEGER.
     * The function accepts 2D_INTEGER_ARRAY matrix as parameter.
     */
    public static int flippingMatrix(List<List<int>> matrix)
    {
        var sum = 0;
        for (int i = 0; i < matrix.Count / 2; i++)
        {
            for (int j = 0; j < matrix.Count / 2; j++)
            {
                int[] arr = new int[4];
                arr[0] = matrix[i][j];
                arr[1] = matrix[i][matrix.Count - (j + 1)];
                arr[2] = matrix[matrix.Count - (i + 1)][j];
                arr[3] = matrix[matrix.Count - (i + 1)][matrix.Count - (j + 1)];
                sum += GetMaxArraySum(arr);
            }
        }
        return sum;
    }
    public static int GetMaxArraySum(int[] arr)
    {
        var sum = 0;
        for (int i = 0; i < 4; i++)
        {
            if (arr[i] > sum) sum = arr[i];
        }
        return sum;
    }
}

class Solution
{
    public static void Main(string[] args)
    {
        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        int q = Convert.ToInt32(Console.ReadLine().Trim());

        for (int qItr = 0; qItr < q; qItr++)
        {
            int n = Convert.ToInt32(Console.ReadLine().Trim());

            List<List<int>> matrix = new List<List<int>>();

            for (int i = 0; i < 2 * n; i++)
            {
                matrix.Add(Console.ReadLine().TrimEnd().Split(' ').ToList().Select(matrixTemp => Convert.ToInt32(matrixTemp)).ToList());
            }

            int result = Result.flippingMatrix(matrix);

            textWriter.WriteLine(result);
        }

        textWriter.Flush();
        textWriter.Close();
    }
}