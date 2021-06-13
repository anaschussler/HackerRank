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

namespace RepeatedString
{
    class Result
    {

        /*
         * Complete the 'repeatedString' function below.
         *
         * The function is expected to return a LONG_INTEGER.
         * The function accepts following parameters:
         *  1. STRING s
         *  2. LONG_INTEGER n
         */

        public static long repeatedString(string s, long n)
        {

            //quantidade de a na string
            long count = s.Count(c => c == 'a');
            // quantas x essa string cabe dentro de n
            long inteiros = (n / s.Length);
            //quantos caracters falta preencher
            long sobra = (n % s.Length);
            //somatoria de a
            long result = count * inteiros;
            //adicionar os caracteres q faltam
           return result += s.Substring(0, Convert.ToInt32( sobra)).Count(c => c == 'a');           
        }

    }

    class Program
    {
        public static void Main(string[] args)
        {
            //TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

            string s = Console.ReadLine();

            long n = Convert.ToInt64(Console.ReadLine().Trim());

            long result = Result.repeatedString(s, n);

            Console.WriteLine(result);

            // textWriter.Flush();
            // textWriter.Close();
        }
    }
}
