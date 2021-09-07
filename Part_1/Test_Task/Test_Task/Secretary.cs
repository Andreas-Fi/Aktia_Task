using System;

namespace Test_Task
{
    class Secretary : Employee
    {
        public Secretary() : base()
        {
        }

        public bool GeneralAccessCard { get; set; }
        public bool HasForemanCalendarView { get; set; }

        public override void DoWork()
        {
            Console.Out.WriteLine("I did work in role {0}, my information: " +
                "\n\t- Name: {1}\n\t- SSN: {2}\n\t- Role: {0}\n\t- GeneralAccessCard: {3}" +
                "\n\t- HasForemanCalendarView: {4}", Role, Name, SSN, GeneralAccessCard.ToString(), HasForemanCalendarView.ToString());
        }
    }
}
