﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesAndMethods3
{
    class BasicMath
    {
        public static void spaceDimension(int sqWidth, int height)
        {
            BasicMath dimension = new BasicMath();
            int area = sqWidth * sqWidth;

            Console.WriteLine($"Area = {area}");
            Console.WriteLine($"Height = {height}");
        }

        
    }
}
