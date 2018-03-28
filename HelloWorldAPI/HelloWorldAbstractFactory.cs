using System;

namespace HelloWorldAPI
{
    public abstract class HelloWorldAbstractFactory
    {
       public abstract IHelloWorld CreateInstance(HelloWorldTypes clientType, string writeToLocation);
    }
}
