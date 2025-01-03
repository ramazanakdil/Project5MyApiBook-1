using Microsoft.AspNetCore.Mvc;
using MyApiBook_1.BusinessLayer.Abstract;

namespace MyApiBook_1.UI.ViewComponents
{
    public class _FeaturedViewComponents : ViewComponent
    {
        private readonly IBookService _bookService;

        public _FeaturedViewComponents(IBookService bookService)
        {
            _bookService = bookService;
        }

        public IViewComponentResult Invoke()
        {
            var values = _bookService.TLast4BooksList();
            return View(values);
        }
    }
}
