using Ecommerce.Controllers;
using Ecommerce.Services;
using NUnit.Framework;

namespace ECommerce.Test
{
    public class GreetingControllerTest
    {
        [Test]
        public void GreetingControllerSendsMessage()
        {
            var greetingController = new GreetingController(new MockGreetingService());
            Assert.AreEqual("Hello World!",greetingController.GetGreeting());
            Assert.True(true);
        }
    }

    public class MockGreetingService : IGreetingService
    {
        public string Greeting(string hello = "")
        {
            return "Hello World";
        }
    }
}