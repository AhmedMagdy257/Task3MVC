using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using Task3MVC.Context;
using Task3MVC.Models;
using Task3MVC.ViewModel;

namespace Task3MVC.Controllers
{
    public class HomeController : Controller
    {
        private readonly TaskDBContext context;

        public HomeController(TaskDBContext _context)
        {
            context = _context;
        }

        public async Task<IActionResult> Index()
        {
            AuthorBookVM authorBookVM = new AuthorBookVM();
            authorBookVM.Books = await BookAsync();
            authorBookVM.Authors = await AuthorAsync();
            return View(authorBookVM);
        }
       
        public async Task<List<Author>> AuthorAsync()
        {
            return context.Authors.ToList();

        }

        public async Task<List<Book>> BookAsync()
        {
            return context.Books.ToList();
        }
        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
