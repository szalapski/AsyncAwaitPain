using Microsoft.AspNetCore.Mvc;
using BigBallOfMud.Lib;

namespace BigBallOfMud
{
    public class HomeController : Controller
    {
        private readonly IGreetingProvider _provider;

        public HomeController(IGreetingProvider provider)
        {
            _provider = provider;
        }

        [Route("/")]
        [HttpGet]
        public string Index() => _provider.GetGreeting();
    }
}
