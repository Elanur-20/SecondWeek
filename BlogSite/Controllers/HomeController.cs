using BlogSite.Models;
using Microsoft.AspNetCore.Mvc;

namespace BlogSite.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {

            var blogPosts = new List<BlogPost>
            {
                new BlogPost
                {
                    Id = 1,
                    Title = " Web Development with ASP.NET Core",
                    Content = "ASP.NET Core is a powerful framework for developing modern web applications. It can run on Windows, Linux, and macOS with cross-platform support.",
                    Author = "Mehrin Kaya",
                    PublishDate = DateTime.Now.AddDays(-45),
                    ViewCount = 145
                },
                new BlogPost
                {
                    Id = 2,
                    Title = "C# Programming Fundamentals",
                    Content = "C# is an object-oriented programming language. Developed by Microsoft, this language is one of the cornerstones of the .NET ecosystem.",
                    Author = "Okan Can Camcý",
                    PublishDate = DateTime.Now.AddDays(-10),
                    ViewCount = 256
                },
                new BlogPost
                {
                    Id = 3,
                    Title = "What's New in Visual Studio 2022",
                    Content = "Visual Studio 2022 introduces many new features for developers, including IntelliSense improvements, Hot Reload, and more.",
                    Author = "Melisa Aracý",
                    PublishDate = DateTime.Now.AddDays(-153),
                    ViewCount = 985
                },
                new BlogPost
                {
                    Id = 4,
                    Title = ".NET Core Performance Optimization Techniques",
                    Content = "We cover the basic techniques used to improve the performance of .NET Core applications. We will explain middleware optimization, asynchronous programming, caching strategies, and developing faster and scalable services with minimal APIs.",
                    Author = "Gönül Bulut",
                    PublishDate = DateTime.Now.AddDays(-60),
                    ViewCount = 1254
                },
            };

            return View(blogPosts);
        }
    }
}