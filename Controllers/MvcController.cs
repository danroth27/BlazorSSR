using BlazorSSR.Pages;
using BlazorSSR.Shared;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Endpoints;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Routing;

namespace BlazorSSR.Controllers;
public class MvcController : Controller
{
    public IResult Index()
    {
        // Note: The form post isn't working yet in this usage
        return new RazorComponentResult<Home>(new { Message = "Hello from MVC!" });
    }
}
