using System;

namespace HelloWorldAPI
{
    public class HelloWorldFactory : HelloWorldAbstractFactory
    {
        public override IHelloWorld CreateInstance(HelloWorldTypes clientType, string writeToLocation)
        {
            
            switch (clientType)
            {
                case HelloWorldTypes.Console:
                    return new HelloWorldConsole() { WriteLocation = writeToLocation };
                case HelloWorldTypes.Mobile:
                    throw new ApplicationException(string.Format("Client '{0}' cannot be created", clientType.ToString()));
                case HelloWorldTypes.Web:
                    throw new ApplicationException(string.Format("Client '{0}' cannot be created", clientType.ToString()));
                case HelloWorldTypes.WebService:
                    throw new ApplicationException(string.Format("Client '{0}' cannot be created", clientType.ToString()));

                default:
                    throw new ApplicationException(string.Format("Client type is unknown"));
            }
        }
    }
}
