using Microsoft.AspNetCore.Components.Endpoints;
using Microsoft.AspNetCore.Mvc;
using Index = BlazorSSR.Pages.Index;

namespace BlazorSSR.Controllers;
public class MvcController : Controller
{
    public IResult Index()
    {
        return new RazorComponentResult<Index>(new { Message = "Hello from MVC!" });
    }
}
