using Microsoft.AspNetCore.Mvc;
using MyApiBook_1.BusinessLayer.Abstract;

namespace MyApiBook_1.UI.ViewComponents
{
    public class _WriterViewComponents : ViewComponent
    {
        private readonly IWriterService _writerService;

        public _WriterViewComponents(IWriterService writerService)
        {
            _writerService = writerService;
        }

        public IViewComponentResult Invoke()
        {
            var values = _writerService.TGetAll().ToList();
            return View(values);
        }
    }
}
