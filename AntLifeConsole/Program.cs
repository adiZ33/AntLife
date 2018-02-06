using AntLifePCL;
using System;
using System.Collections.Generic;
using System.Linq;

namespace AntLifeConsole
{
    public class Program
    {
        static void Main(string[] args)
        {
            //Owady
            //LatająceOwady: Owady
            //Osa: LatajaceOwady
            //ZiemneOwady: Owady



        }
        //polimorfizm statyczny (przeciążenie metody)
        public static int dodawanie(int a, int b)
        {
            return a + b;
        }
        public static int dodawanie(int a, int b, int c)
        {
            return a + b + c;
        }
    }
}