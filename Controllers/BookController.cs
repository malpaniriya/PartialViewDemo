using Microsoft.AspNetCore.Mvc;
using PartialViewDemo.Data;

namespace PartialViewDemo.Controllers
{
    public class BookController : Controller
    {
        ApplicationDbContext context;

        public BookController(ApplicationDbContext context)
        {
            this.context = context;
        }
        public ActionResult Index()
        {
            var model=context.Books.ToList();
            return View(model);
        }
    }
}
