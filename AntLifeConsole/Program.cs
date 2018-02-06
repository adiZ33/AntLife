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

            //MilitaryBase mb = new MilitaryBase();
            //mb.CreateBase("MilitaryBase Name", 9.9f, 10.10f,100);

            //BaseBody mbb = new MilitaryBase();
            //mbb.CreateBase("MilitaryBase Name", 9.9f, 10.10f);

            MilitaryBase bbm = new BaseBody();


            Console.ReadKey();
        }
    }
}