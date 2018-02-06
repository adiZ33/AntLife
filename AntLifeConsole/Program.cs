using AntLifePCL;
using AntLifePCL.Poli;
using System;
using System.Collections.Generic;
using System.Linq;

namespace AntLifeConsole
{
    public class Program
    {
        static void Main(string[] args)
        {
            //BaseBody bb = new BaseBody();
            //bb.CreateBase("BaseBody Name", 1.1f, 2.2f);

            MilitaryBase mb = new MilitaryBase("Super baza",33f,44f,9);
            //mb.CreateBase("MilitaryBase Name", 9.9f, 10.10f,100);

            Console.WriteLine(mb.Name);
            Console.WriteLine(mb.Longitude);
            Console.WriteLine(mb.Latitude);
            Console.WriteLine(mb.WallResistance);

            BaseBody mbb = new MilitaryBase("Super baza", 33f, 44f, 9);
            //mbb.CreateBase("MilitaryBase Name", 9.9f, 10.10f);



            Console.ReadKey();
        }
    }
}