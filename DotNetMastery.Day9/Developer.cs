using System;
using System.Collections.Generic;
using System.Text;

namespace DotNetMastery.Day9
{
    internal class Developer :Employee
    {
        public string Language { get; set; } = "";

        public Developer(string name, int id, decimal salary, string language):base(name,id, salary)
        {
            Language = language;
        }
        public override void ShowDetails()
        {
            base.ShowDetails();
            Console.WriteLine($"Role: Developer | Language: {Language} | Bonus: {GetBonus()}");
        }
        public override decimal GetBonus()
        {
            return salary * 0.15m;
        }
    }
}
