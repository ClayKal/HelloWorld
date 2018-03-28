using System;
using System.Configuration;

namespace HelloWorldAPI
{
    public class HelloWorldConsole : IHelloWorld
    {
        public string WriteLocation { get; set; }

        public string getGreeting()
        {
            return "Hello World Console";
        }

        public void writeMessage(string value)
        {
            throw new NotImplementedException("The writeMessage method has not been implemented. If it were it would write to " + this.WriteLocation);
        }
    }
}
