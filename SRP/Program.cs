using System;
using System.IO;

namespace SRP
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }

        public class MemberShip
        {
            public void Add()
            {
                try
                {
                    //to do
                }
                catch (Exception ex)
                {
                    Logger logger = new Logger();
                    logger.log(ex.Message);
                }
            }
        }

        public class Logger
        {
            public void log(string error)
            {
                File.WriteAllText("c:\\log", error);
            }
        }
    }
}
