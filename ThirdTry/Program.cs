﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThirdTry
{
    internal class Program
    {

        static void Main(string[] args)
        {
            // first
            string name = "Столовник Володимир";
            int age = 18;
            Console.WriteLine("Привiт, мене звати {0}, менi {1} рокiв", name, age);
            // end

            // second
            int a = 3;
            int b = 8;
            double result;
            result = ((Math.Pow(a + b, 4)) - (Math.Pow(a, 4)) + 4 * (Math.Pow(a, 3)) * b + 6 * (Math.Pow(a, 2)) * (Math.Pow(b, 2))) / ((Math.Pow(b, 2)) * 4 * a + (Math.Pow(b, 4)));
            Console.WriteLine($"Результат = {result}");
            //end

            //third
            Console.WriteLine("Виведення трьохзначного числа в зворотному порядку:");
            int input, output;
            input = Convert.ToInt32(Console.ReadLine());
            output = (input % 10 * 100 + (input % 100 / 10 * 10) + (input / 100));
            Console.WriteLine($"{input} --> {output}");

            /*
            string resultString = result.ToString();
            string reversedResult = "";
            for (int i = resultString.Length - 1; i >= 0; i--)
            {
                reversedResult += resultString[i];
            }
            Console.WriteLine($"Результат в зворотньому порядку  = {reversedResult}");
            Я МАССІВ ВИВІВ
            */
            Console.ReadKey();
            //The end
        }
    }
}