using Microsoft.AspNetCore.Mvc;
using MyApiBook_1.BusinessLayer.Abstract;

namespace MyApiBook_1.UI.ViewComponents
{
    public class _AllBooksViewComponents : ViewComponent
    {
        private readonly IBookService _bookService;

        public _AllBooksViewComponents(IBookService bookService)
        {
            _bookService = bookService;
        }

        public IViewComponentResult Invoke()
        {
            var allBooks = _bookService.TPopulerBookAllCategories();
            return View(allBooks);
        }
    }
}
