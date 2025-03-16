// See https://aka.ms/new-console-template for more information
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tp5_103022330036;

namespace tp5_103022330036
{
    class HaloGeneric
    {
        public void SapaUser<T>(T x)
        {
            Console.WriteLine($"Halo, user{x}");
        }
    }
}


﻿// See https://aka.ms/new-console-template for more information

class program
{
    static void Main(string[] args)
    {
        HaloGeneric hai = new HaloGeneric();

        hai.SapaUser<string>(" Praktikan");
    }
}