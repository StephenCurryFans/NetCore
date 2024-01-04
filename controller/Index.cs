using Microsoft.AspNetCore.Mvc;

namespace NetCoreDemo.Controller;
[ApiController]
[Route("/index")]
public class Index
{

    [HttpGet("/hello")]
    public string Hello()
    {
        return "HelloWorld";
    }

}