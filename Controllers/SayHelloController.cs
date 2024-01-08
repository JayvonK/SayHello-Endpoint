

using Microsoft.AspNetCore.Mvc;

namespace SayHello_Endpoint.Controllers;

[ApiController]
[Route("api/[controller]")]

public class SayHelloController
{
    public List<string> greet = new();
    public Random randNum = new();

    public string greeter = "";

    public SayHelloController()
    {
        greet.Add("Hello, ");
        greet.Add("Hi, ");
        greet.Add("Greetings, ");
        greet.Add("Howdy, ");
        greet.Add("Hola, ");
        greet.Add("What's up, ");
        greet.Add("Hi(with fist bump), ");

        int rng = randNum.Next(0, greet.Count);
        greeter = greet[rng];
    }

    [HttpGet]
    [Route("Greeting/{name}")]
    public string Hello(string name)
    {
        return greeter + " " + name;
    }
}
