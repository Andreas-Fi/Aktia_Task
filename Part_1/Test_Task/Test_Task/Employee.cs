using System;

namespace Test_Task
{
    class Employee : IEmployee
    {
        public string Name { get;set; }
        public string SSN { get; set; }
        public string Role { get; set; }

        public virtual void DoWork()
        {
            Console.Out.WriteLine("I did work in role {0}, my information: " +
                "\n\t- Name: {1}\n\t- SSN: {2}\n\t- Role: {0}", Role, Name,SSN);
        }
    }
}
