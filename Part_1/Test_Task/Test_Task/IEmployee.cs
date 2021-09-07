namespace Test_Task
{
    interface IEmployee
    {
        string Name { get; set; }
        string SSN { get; set; }
        string Role { get; set; }

        void DoWork();
    }
}
