﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StructureKeyword
{
    internal class StructMain
    {
        static void Main(string[] args)
        {
            Dept d1 = new Dept(1, "HR");
            Console.WriteLine(d1.Print());


            var d2 = new Dept(2, "Sales");
            Console.WriteLine(d2.Print());

        }

    }
}
