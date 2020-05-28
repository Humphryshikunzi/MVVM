using System;

namespace CallBacks
{
    class Program
    {
        public delegate void CallBackDelegate(string name);
        static void Main(string[] args)
        {
            CallBackMethod(CallMethod);

        }
        public static void CallMethod(string name)
        {
            Console.WriteLine(name);
        }
        public static void CallBackMethod(CallBackDelegate callBackDelegate)
        {
            for (int i = 0; i < 20; i++)
            {
                // callBackDelegate(i);
            }
            callBackDelegate("Humphry");
        }
    }
    
}
