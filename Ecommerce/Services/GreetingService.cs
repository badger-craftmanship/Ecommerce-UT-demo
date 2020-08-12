namespace Ecommerce.Services
{
    public class GreetingService : IGreetingService
    {
        public string Greeting(string hello = "")
        {
            if (hello.Equals(""))
            {
                hello = "World!";
            }
            return $"Hello {hello}";
        }
    }

    public interface IGreetingService
    { 
        public string Greeting(string hello = "");
    }
}