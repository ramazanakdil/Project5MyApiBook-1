using Microsoft.AspNetCore.Mvc;
using MyApiBook_1.BusinessLayer.Abstract;

namespace MyApiBook_1.UI.ViewComponents
{
    public class _KisiselGelisimViewComponents : ViewComponent
    {
        private readonly IBookService _bookService;

        public _KisiselGelisimViewComponents(IBookService bookService)
        {
            _bookService = bookService;
        }

        public IViewComponentResult Invoke()
        {
            var books = _bookService.TPopulerBookKisiselGelisim();
            return View(books);
        }
    }
}
