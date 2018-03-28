using System;
using HelloWorldAPI;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace HelloWorldUnitTests
{
    [TestClass]
    public class HelloWorldAPITests
    {
        [TestMethod]
        public void CreateConsoleType()
        {
            HelloWorldFactory fac = new HelloWorldFactory();
            IHelloWorld hwAPI = fac.CreateInstance(HelloWorldTypes.Console, "test");

            Assert.AreEqual(hwAPI.getGreeting(), "Hello World Console");
        }

        [TestMethod]
        public void CreateMobileType()
        {

            HelloWorldFactory fac = new HelloWorldFactory();

            Assert.ThrowsException<ApplicationException>(() => fac.CreateInstance(HelloWorldTypes.Mobile, "test"));
        }

        [TestMethod]
        public void WriteMessage_NotImplemented()
        {

            HelloWorldFactory fac = new HelloWorldFactory();
            IHelloWorld hwAPI = fac.CreateInstance(HelloWorldTypes.Console, "test");

            Assert.ThrowsException<NotImplementedException>(() => hwAPI.writeMessage("test"));
        }

    }
}
