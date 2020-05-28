using System;

namespace EventsAndDelegates
{
    class Program
    {
        public static  string  LastName { get; set; }
        public static string  Email { get; set; }
        static void Main(string[] args)
        {
            TestData(null, null);
        }
        public Program()
        {
            LastName = "Humphry";
            Email = "humphry97@outlook.com";
        }
        public static void TestData(object sender, EventArgs e)
        {
            LastName = "Humphry";
            Email = "humphry97@outlook.com";
        }
    }
}
