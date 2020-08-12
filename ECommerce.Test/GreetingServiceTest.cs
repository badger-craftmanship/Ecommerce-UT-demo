using Ecommerce.Services;
using NUnit.Framework;

namespace ECommerce.Test
{
    public class GreetingServiceTest
    {
        [Test]
        public void TestGretingServiceHello()
        {
            var service = new GreetingService();
            Assert.AreEqual("Hello Lalo", service.Greeting("Lalo"));
        }
        
        [Test]
        public void TestGretingServiceHelloWithDefault()
        {
            var service = new GreetingService();
            Assert.AreEqual("Hello World!", service.Greeting(""));
        }
    }
}