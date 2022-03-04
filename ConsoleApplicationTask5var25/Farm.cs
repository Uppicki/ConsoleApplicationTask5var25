using System;
using System.Collections.Generic;

namespace ConsoleApplicationTask5var25
{
    abstract class Farm : Economy
    {
        public double balance{ get; set; }
        protected int staff;
        protected double salary;
        
        
        public Farm(){}


        public void tax()
        {
            Console.WriteLine("Tax: " + _tax());
        }

        public void staffSalary()
        {
            Console.WriteLine("Staff salary: " + _staffSalary());
        }
        
        public void profit()
        {
            Console.WriteLine("Profit: " + _profit());
        }

        
        protected double _tax()
        {
            return 0.3 * balance;
        }

        protected double _staffSalary()
        {
            return salary * staff;
        }

        protected double _profit()
        {
            return balance - (_tax() + _staffSalary());
        }
        
    }
}