﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASCiiConvert
{
    class Program
    {
        static void Main(string[] args)
        {
            ASCiiArtColour tst = new ASCiiArtColour("");
            
            tst.Go();
            Console.ReadKey();
        }
    }
}
