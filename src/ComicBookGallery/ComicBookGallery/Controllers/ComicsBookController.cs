using ComicBookGallery.Data;
using ComicBookGallery.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ComicBookGallery.Controllers
{
    public class ComicBooksController : Controller
    {
        private ComicBookRepository _comicBookRepository = null;

        public ComicBooksController()
        {
            _comicBookRepository = new Data.ComicBookRepository();
        }

        public ActionResult Index()
        {
            ComicBook[] comicBooks = _comicBookRepository.GetComicBooks();
            return View(comicBooks);
        }

        public ActionResult Detail (int? id)
        {
            if (id == null)
            {
                return HttpNotFound();
            }

            ComicBook comicBook = _comicBookRepository.GetComicBook(id.Value);
           
            return View(comicBook);
        }
    }
}