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

namespace CountingValleys
{
    class Result
    {

        /*
         * Complete the 'countingValleys' function below.
         *
         * The function is expected to return an INTEGER.
         * The function accepts following parameters:
         *  1. INTEGER steps
         *  2. STRING path
         */

        public static int countingValleys(int steps, string path)
        {
            int valleys = 0;
            int Pos = 1;
            for (int i = 0; i < steps - 1; i++)
            {
                if (path[i].Equals('U'))
                    Pos++;
                else
                {
                    if (Pos == 1)
                        valleys++;
                    Pos--;
                }
            }
            return valleys;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            int steps = Convert.ToInt32(Console.ReadLine().Trim());
            string path = Console.ReadLine();
            int result = Result.countingValleys(steps, path);
            Console.WriteLine(result);
        }
    }
}
