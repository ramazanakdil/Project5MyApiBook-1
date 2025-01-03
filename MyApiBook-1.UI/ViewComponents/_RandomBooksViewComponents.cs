using Microsoft.AspNetCore.Mvc;
using MyApiBook_1.BusinessLayer.Abstract;

namespace MyApiBook_1.UI.ViewComponents
{
    public class _RandomBooksViewComponents : ViewComponent
    {
        private readonly IBookService _bookService;

        public _RandomBooksViewComponents(IBookService bookService)
        {
            _bookService = bookService;
        }

        public IViewComponentResult Invoke()
        {
            var values = _bookService.TRandom1Book();
            return View(values);
        }
    }
}
