﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ConsoleApplication5
{
    class Program
    {
        static void Main(string[] args)
        {
           

            Singleton s1 = Singleton.Instance();
            Singleton s2 = Singleton.Instance();

            // Тестирование экземпляра

            if (s1 == s2)
            {
                Console.WriteLine("Objects are the same instance");
            }
            Console.ReadKey();
        }
    }
}
