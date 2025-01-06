using Microsoft.AspNetCore.Mvc;
using MyApiBook_1.BusinessLayer.Abstract;

namespace MyApiBook_1.UI.ViewComponents
{
    public class _TarihViewComponents : ViewComponent
    {
        private readonly IBookService _bookService;

        public _TarihViewComponents(IBookService bookService)
        {
            _bookService = bookService;
        }

        public IViewComponentResult Invoke()
        {
            var books = _bookService.TPopulerBookTarih();
            return View(books);
        }
    }
}
