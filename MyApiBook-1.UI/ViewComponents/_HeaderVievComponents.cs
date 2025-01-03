using Microsoft.AspNetCore.Mvc;

namespace MyApiBook_1.UI.ViewComponents
{
    public class _HeaderVievComponents : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
