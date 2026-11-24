using System;
using System.Collections.Generic;
using System.Text;

namespace DotNetMastery.Day9
{
    internal class Manager :Employee
    {
        public int TeamSize { get; set; }

        public Manager(string name, int Id, decimal salary, int teamSize) :base(name, Id,salary)
        {
            TeamSize = teamSize;
        }

        public override void ShowDetails()
        {
            base.ShowDetails();
            Console.WriteLine($"Role: Manager | Team Size: {TeamSize} | Bonus: {GetBonus()}");
        }
        public override decimal GetBonus()
        {
            return salary * 0.20m;
        }
    }
}
