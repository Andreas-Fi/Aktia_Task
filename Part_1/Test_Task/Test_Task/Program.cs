using System;
using Newtonsoft.Json.Linq;

namespace Test_Task
{
    class Program
    {
        static void Main(string[] args)
        {
            //Reads the json file
            string employeeFile = System.IO.File.ReadAllText(@".\\employees.json");

            //Parses the json file
            JToken data = JObject.Parse(employeeFile);

            //Reads through the content of the file
            foreach (var item in data["EmployeeList"])
            {
                try
                {
                    if ((string)item["Role"] == "ShowelPerson")
                    {
                        Showel_Person person = new Showel_Person
                        {
                            Name = (string)item["Name"],
                            SSN = (string)item["SSN"],
                            Role = (string)item["Role"],
                            Tool = (string)item["Tool"]
                        };
                        person.DoWork();
                    }
                    else if ((string)item["Role"] == "Secretary")
                    {
                        Secretary person = new Secretary
                        {
                            Name = (string)item["Name"],
                            SSN = (string)item["SSN"],
                            Role = (string)item["Role"],
                            GeneralAccessCard = (bool)item["GeneralAccessCard"],
                            HasForemanCalendarView = (bool)item["HasForemanCalendarView"]
                        };
                        person.DoWork();
                    }
                    else if ((string)item["Role"] == "Boss")
                    {
                        Boss person = new Boss
                        {
                            Name = (string)item["Name"],
                            SSN = (string)item["SSN"],
                            Role = (string)item["Role"],
                            YearlyBonus = (int)item["YearlyBonus"]
                        };
                        person.DoWork();
                    }
                    Console.WriteLine();
                }
                catch (Exception) { } 
            }

            Console.Write("\n\nDone...");
            Console.ReadLine();
        }
    }
}
