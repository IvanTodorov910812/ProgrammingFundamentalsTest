﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecriptingMessages
{
    class DecriptingMessages
    {
        static void Main(string[] args)
        {
            byte decriptionKey = byte.Parse(Console.ReadLine());
            byte charactersCount = byte.Parse(Console.ReadLine());
            string message = "";

            while (charactersCount > 0)
            {
                message += ((char)(char.Parse(Console.ReadLine()) + decriptionKey)).ToString();

                charactersCount--;
            }

            Console.WriteLine(message);
        }
    }
}