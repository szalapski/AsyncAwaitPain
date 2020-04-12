using Microsoft.AspNetCore.Http;

namespace BigBallOfMud.Lib
{
    public interface IGreetingProvider
    {
        string GetGreeting();
    }
}