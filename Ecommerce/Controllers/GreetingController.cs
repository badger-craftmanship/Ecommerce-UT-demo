using Ecommerce.Services;
using Microsoft.AspNetCore.Mvc;

namespace Ecommerce.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class GreetingController
    {
        public GreetingController(IGreetingService greetingService)
        {
            GreetingService = greetingService;
        }

        private IGreetingService GreetingService{get;}
    

        [HttpGet]
        public string GetGreeting()
        {
            return $"{this.GreetingService.Greeting("lalo")}!";
        }
    }
}