using System.Diagnostics;
using KananeloMotaungDev.Models;
using Microsoft.AspNetCore.Mvc;

namespace KananeloMotaungDev.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {
        // These projects are stored in memory for now.
        // Later, finished projects can come from a database or external service.
        var projects = new List<Project>
        {
            new Project
            {
                Title = "OpportunityOS",

                Description =
                    "A developing business platform designed to organize opportunities, " +
                    "projects, workflows, and future AI-assisted tools in one system.",

                Technologies = new List<string>
                {
                    "C#",
                    "ASP.NET Core MVC",
                    "Razor",
                    "CSS",
                    "Git"
                },

                // An empty image path tells Razor to display
                // our custom project preview instead.
                ImagePath = string.Empty,

                GitHubUrl = string.Empty,
                LiveUrl = null,

                IsFeatured = true
            },

            new Project
            {
                Title = "KM Digital Solutions",

                Description =
                    "An application development project focused on building professional " +
                    "software solutions for businesses and future clients.",

                Technologies = new List<string>
                {
                    "C#",
                    "ASP.NET Core MVC",
                    "Razor",
                    "Bootstrap",
                    "CSS"
                },

                ImagePath = string.Empty,

                GitHubUrl = string.Empty,
                LiveUrl = null,

                IsFeatured = false
            }
        };

        // Sends the project list to Views/Home/Index.cshtml.
        return View(projects);
    }

    [ResponseCache(
        Duration = 0,
        Location = ResponseCacheLocation.None,
        NoStore = true)]
    public IActionResult Error()
    {
        return View(
            new ErrorViewModel
            {
                RequestId =
                    Activity.Current?.Id ??
                    HttpContext.TraceIdentifier
            });
    }
}