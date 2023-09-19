using BlazorSSR.Components.Pages;
using Microsoft.AspNetCore.Components.Endpoints;
using Microsoft.AspNetCore.Mvc;

namespace BlazorSSR.Controllers;
public class MvcController : Controller
{
    public IResult Index()
    {
        // Note: The form post isn't working yet in this usage
        return new RazorComponentResult<Home>(new { Message = "Hello from MVC!" });
    }
}
