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

namespace _2DArrayDS
{
    class Result
    {

        /*
         * Complete the 'hourglassSum' function below.
         *
         * The function is expected to return an INTEGER.
         * The function accepts 2D_INTEGER_ARRAY arr as parameter.
         */

        public static int hourglassSum(List<List<int>> arr)
        {
            int x = 0;
            int y = 0;
            int linha = 0;
            int coluna = 0;
            int stopLinha = 3;
            int stopColuna = 3;
            int soma = 0;
            int maior = 0;
            int exclude = 0;

            for (int i = 0; i < 16; i++)//nro de hourglasses
            {                     
                for (y = coluna; y < stopColuna; y++)
                {
                    for (x = linha; x < stopLinha; x++)
                    {
                        if (exclude != 3 && exclude != 5)
                            soma += arr[y][x];

                        exclude++;
                    }
                }
                if (i == 0) maior = soma;
                if (soma > maior) maior = soma;
                Console.WriteLine(soma);
                soma = 0;
                exclude = 0;

                if (linha < 3)
                {
                    linha++;
                    stopLinha++;
                }
                else
                {
                    linha = 0;
                    stopLinha = 3;
                    coluna++;
                    stopColuna++;
                }
            }
            return maior;
        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            // TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

            List<List<int>> arr = new List<List<int>>();

            for (int i = 0; i < 6; i++)
            {
                arr.Add(Console.ReadLine().TrimEnd().Split(' ').ToList().Select(arrTemp => Convert.ToInt32(arrTemp)).ToList());
            }

            int result = Result.hourglassSum(arr);

            Console.WriteLine(result);

        }
    }
}
