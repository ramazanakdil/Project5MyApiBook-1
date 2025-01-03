using Microsoft.AspNetCore.Mvc;
using MyApiBook_1.BusinessLayer.Abstract;

namespace MyApiBook_1.UI.ViewComponents
{
    public class _AllBooksWithCategoryViewComponents : ViewComponent
    {
        private IBookService _bookService;

        public _AllBooksWithCategoryViewComponents(IBookService bookService)
        {
            _bookService = bookService;
        }

        public IViewComponentResult Invoke()
        {
            
            return View();
        }
    }
}
