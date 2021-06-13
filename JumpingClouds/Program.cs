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

namespace JumpingClouds
{
    class Result
    {

        /*
         * Complete the 'jumpingOnClouds' function below.
         *
         * The function is expected to return an INTEGER.
         * The function accepts INTEGER_ARRAY c as parameter.
         */

        public static int jumpingOnClouds(int n, List<int> c)
        {
            int pulo = 0;
            int i = 0;
            while (i < n - 1)
            {
                if (i + 2 == n)  //one before the last
                {
                    if (c[i + 1] == 0)
                        pulo++;
                    i++;
                }
                else
                {
                    if (c[i + 2] == 0)
                    {
                        i = i + 2;
                    }
                    else
                    {
                        i = i + 1;
                    }
                    pulo++;
                }
            }
            return pulo;
        }

    }
    class Program
    {

        static void Main(string[] args)
        {

            int n = Convert.ToInt32(Console.ReadLine().Trim());
            List<int> c = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(cTemp => Convert.ToInt32(cTemp)).ToList();
            int result = Result.jumpingOnClouds(n, c);
            Console.WriteLine(result);

        }
    }
}
