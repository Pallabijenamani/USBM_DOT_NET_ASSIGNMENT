using assignment_1.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace assignment_1.Controllers
{
    public class BookController : Controller

    {
        private readonly LibraryDbContext context;
        public BookController(LibraryDbContext context)
        {
            this.context = context;
        }
        public IActionResult Showdata()
        {
            var mydata = context.Books.ToList();
            return View(mydata);
        }
        public IActionResult Details(int Id)
        {
            var Data = context.Books.Find(Id);
            return View(Data);
        }
        public IActionResult Edit(int Id, [Bind("Book_Id", "Book_Name", "Book_Author")] Book obj)
        {
            var Data = context.Books.Find(Id);
            return View(Data);
        }
        public IActionResult Create()
        {
            return View();
        }

        public IActionResult Insertvalues(Book obj)
        {
            context.Books.Add(obj);
            context.SaveChanges();
            return RedirectToAction(nameof(Showdata));
        }

        public IActionResult Edit_User([Bind("Book_Id", "Book_Name", "Book_Author")] Book obj)
        {
            context.Update(obj);
            context.SaveChanges();

            return RedirectToAction(nameof(Showdata));

        }
        public IActionResult Delete(int Id)
        {
            var Data = context.Books.Find(Id);
            return View(Data);
        }
        public IActionResult Delete_User(int BookId)
        {
            var Data = context.Books.Find(BookId);
            if (Data != null)
            {
                context.Books.Remove(Data);
            }
            context.SaveChanges();
            return RedirectToAction(nameof(Showdata));
        }




    }
}
