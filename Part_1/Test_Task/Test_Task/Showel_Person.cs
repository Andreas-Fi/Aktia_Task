using System;

namespace Test_Task
{
    class Showel_Person : Employee
    {
        public Showel_Person() : base()
        {
        }
        public string Tool { get; set; }

        public override void DoWork()
        {
            Console.Out.WriteLine("I did work in role {0}, my information: " +
                "\n\t- Name: {1}\n\t- SSN: {2}\n\t- Role: {0}\n\t- Tool: {3}", Role, Name, SSN,Tool);
        }
    }
}
