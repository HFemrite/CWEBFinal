using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using FinalProject.Models;

namespace FinalProject.Controllers
{
    public class HomeController : Controller
    {
        LibraryEntities db = new LibraryEntities();
        public ActionResult BookData()
        {
            List<Book> book = db.Books.ToList();
            return View(book);
        }
        [HttpGet]
        public ActionResult Create()
        {
            return PartialView("_Create");
        }
        [HttpPost]
        public ActionResult Create(Book book)
        {
            try
            {
                if (book != null)
                {
                    Book bookData = new Book();
                    bookData.BookTitle = book.BookTitle;
                    bookData.CoverType = book.CoverType;
                    bookData.LastRead = book.LastRead;
                    bookData.TimesRead = book.TimesRead;
                    bookData.Genre = book.Genre;
                    bookData.Author = book.Author;
                    db.Books.Add(bookData);
                    db.SaveChanges();
                }
                return RedirectToAction("BookData");
            }
            catch (Exception)
            {
                ViewBag.msg = "Some error occured.";
                return RedirectToAction("BookData");
            }
        }
        [HttpGet]
        public ActionResult EditUpdate(int id)
        {
            try
            {
                if (id != 0)
                {
                    Book book_data = db.Books.SingleOrDefault(x => x.BookId == id);
                    return PartialView("_EditUpdate", book_data);
                }
                else
                {
                    return RedirectToAction("BookData");
                }
            }
            catch (Exception)
            {
                ViewBag.msg = "Some error occured";
                return RedirectToAction("BookData");
            }
        }
        [HttpPost]
        public ActionResult EditUpdate(Book book_mod)
        {
            try
            {
                if (book_mod != null)
                {
                    Book book_update = db.Books.SingleOrDefault(x => x.BookId == book_mod.BookId);
                    book_update.BookTitle = book_mod.BookTitle;
                    book_update.CoverType = book_mod.CoverType;
                    book_update.LastRead = book_mod.LastRead;
                    book_update.TimesRead = book_mod.TimesRead;
                    book_update.Genre = book_mod.Genre;
                    book_update.Author = book_mod.Author;
                    db.SaveChanges();
                }
                return RedirectToAction("BookData");
            }
            catch (Exception)
            {
                ViewBag.msg = "Some error occured";
                return RedirectToAction("BookData");
            }
        }
        [HttpGet]
        public ActionResult Delete(int id)
        {
            try
            {
                Book book_data = db.Books.SingleOrDefault(x => x.BookId == id);
                if (book_data != null)
                {
                    db.Books.Remove(book_data);
                    db.SaveChanges();
                }
                return RedirectToAction("BookData");
            }
            catch (Exception)
            {
                ViewBag.msg = "Some error occured.";
                return RedirectToAction("BookData");
            }
        }
    }
}