using HelloWorldAPI;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorldConsoleClient
{
    class Program
    {
        static void Main(string[] args)
        {
            var writeLocation = ConfigurationManager.AppSettings["WriteToLocation"];

            HelloWorldFactory fac = new HelloWorldFactory();
            IHelloWorld hwAPI = fac.CreateInstance(HelloWorldTypes.Console, writeLocation);

            Console.Write(hwAPI.getGreeting());

            Console.ReadKey();
        }
    }
}
