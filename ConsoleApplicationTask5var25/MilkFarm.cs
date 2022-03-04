using System;
using System.Collections.Generic;

namespace ConsoleApplicationTask5var25
{
    class MilkFarm : Farm
    {
        private int animals;
        private double kormCost;

        public MilkFarm(double balance, int staff, int salary, int animals, int kormCost) 
        {
            this.balance = balance;
            this.staff = staff;
            this.animals = animals;
            this.kormCost = kormCost;
            this.salary = salary;
        }

        public void expenses()
        {
            Console.WriteLine("Expenses: " + _expenses());
        }

        private double _expenses()
        {
            return animals * kormCost;
        }

        private double _profit()
        {
            return base._profit() - _expenses();
        }

        public override string ToString()
        {
            return "Balance: " + this.balance + "\n" +
                   "Expenses: " + _expenses() + "\n" +
                   "Tax: " + _tax() + "\n" +
                   "Staff salary: " + _staffSalary()+ "\n" +
                   "Profit: " + _profit() + "\n";
        }
    }
}