using DBTask.Models;
using Microsoft.AspNetCore.Mvc;

namespace DBTask.Controllers
{
    public class BookController : Controller
    {
        private readonly LibraryManagementSystemContext context;
        public BookController(LibraryManagementSystemContext context)
        {
            this.context = context;
        }
        public IActionResult ShowData()
        {
            var mydata = context.Books.ToList();
            return View(mydata);
        }


        public IActionResult Index() // Action method create view
        {
           
                var Data = context.Books.ToList(); //Table data or models data store into data variable 
                return View(Data);  // View method accessing your list on output 
            
           
        }
    }
}
