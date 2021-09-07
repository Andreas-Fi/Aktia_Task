using System;

namespace Test_Task
{
    class Boss : Employee
    {
        public Boss() : base()
        {
        }

        public int YearlyBonus { get; set; }

        public override void DoWork()
        {
            Console.Out.WriteLine("I did work in role {0}, my information: " +
                "\n\t- Name: {1}\n\t- SSN: {2}\n\t- Role: {0}\n\t- YearlyBonus: {3}", Role, Name, SSN, YearlyBonus);
        }
    }
}
