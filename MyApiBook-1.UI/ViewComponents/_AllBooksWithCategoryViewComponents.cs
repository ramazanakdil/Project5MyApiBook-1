using Microsoft.AspNetCore.Mvc;
using MyApiBook_1.BusinessLayer.Abstract;

namespace MyApiBook_1.UI.ViewComponents
{
    public class _AllBooksWithCategoryViewComponents : ViewComponent
    {

        public IViewComponentResult Invoke()
        {
            
            return View();
        }
    }
}
