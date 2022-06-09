﻿using System.CodeDom.Compiler;
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
     * Complete the 'fizzBuzz' function below.
     *
     * The function accepts INTEGER n as parameter.
     */

    public static void fizzBuzz(int n)
    {
        for (int i = 1; i <= n; i++)
        {
            Console.WriteLine(GetFizzBuzz(i));
        }
    }
    private static string GetFizzBuzz(int n)
    {
        string s = "";
        if (n % 3 == 0)
        {
            s += "Fizz";
        }
        if (n % 5 == 0)
        {
            s += "Buzz";
        }
        if (string.IsNullOrEmpty(s))
        {
            s = n.ToString();
        }
        return s;
    }

}
class Solution
{
    public static void Main(string[] args)
    {
        int n = Convert.ToInt32(Console.ReadLine().Trim());

        Result.fizzBuzz(n);
    }
}
