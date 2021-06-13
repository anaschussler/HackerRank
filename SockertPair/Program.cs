﻿using System;
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


namespace SocketPair
{

    class Result
    {

        /*
         * Complete the 'sockMerchant' function below.
         *
         * The function is expected to return an INTEGER.
         * The function accepts following parameters:
         *  1. INTEGER n
         *  2. INTEGER_ARRAY ar
         */

        public static int sockMerchant(int n, List<int> ar)
        {
            int par = 0;
            int count = 1;
            ar.Sort();
            for (int i = 0; i < n-1; i++)
            {
                if (ar[i] == ar[i + 1])
                {
                    count++;                    
                }
                else
                {
                    par += (count / 2);
                    count = 1;
                }                
            }
            par += (count / 2);
            return par;
        }

    }

    class Program
    {
        public static void Main(string[] args)
        {

            int n = Convert.ToInt32(Console.ReadLine().Trim());

            List<int> ar = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(arTemp => Convert.ToInt32(arTemp)).ToList();

            int result = Result.sockMerchant(n, ar);

            Console.WriteLine(result);


        }
    }
}