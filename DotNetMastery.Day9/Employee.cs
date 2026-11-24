using System;
using System.Collections.Generic;
using System.Text;

namespace DotNetMastery.Day9
{
    internal class Employee
    {
        public string Name { get; set; } = "";
        public int Id { get; set; }
        public decimal salary { get; set; }

        public Employee(string name, int id, decimal salary)    
        {
            Name = name;
            Id = id;
            this.salary = salary;
        }

        public virtual void ShowDetails()
        {
            Console.WriteLine($"ID: {Id} | Name: {Name} |Salary : {salary} ");
        }
        public virtual decimal GetBonus()
        {
            return salary * 0.10m;
        }
    }

}
