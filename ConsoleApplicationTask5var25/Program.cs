using System;
using System.Collections.Generic;

namespace ConsoleApplicationTask5var25
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            List<Economy> farms = new List<Economy>();
            
            Economy farm1 = new MilkFarm(300000, 50, 10000, 20, 10000);
            Economy farm2 = new MilkFarm(100000, 10, 100000, 1, 1000);
            Economy farm3 = new MilkFarm(5000000, 25, 50000, 100, 6666);
            
            farms.Add(farm1);
            farms.Add(farm2);
            farms.Add(farm3);

            foreach (Economy farm in farms)
            {
                Console.WriteLine(farm);
            }
        }
    }
}