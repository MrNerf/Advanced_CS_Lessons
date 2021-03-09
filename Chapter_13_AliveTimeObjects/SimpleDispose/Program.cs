﻿using System;
using System.Diagnostics.CodeAnalysis;
using System.IO;

namespace SimpleDispose
{
    [SuppressMessage("ReSharper", "StringLiteralTypo")]
    internal class Program
    {
        private static void Main()
        {
            Console.Title = "Использования метода Dispose";
            Console.ForegroundColor = ConsoleColor.Green;
            var res = new MyResource("John", 25);
            Console.WriteLine(res.ToString());
            res.ChangeAll("Mark", 45);
            Console.WriteLine(res.ToString());
            res.Dispose();
            using (var sw = new StreamWriter(@"log.txt"))
            { 
                sw.Write(res.ToString());
            }
            Console.ReadLine();
        }
    }
}
