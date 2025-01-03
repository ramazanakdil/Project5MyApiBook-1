using Microsoft.AspNetCore.Mvc;
using MyApiBook_1.BusinessLayer.Abstract;

namespace MyApiBook_1.UI.ViewComponents
{
    public class _FeatureViewComponents : ViewComponent
    {
        private readonly IFeatureService _featureService;

        public _FeatureViewComponents(IFeatureService featureService)
        {
            _featureService = featureService;
        }

        public IViewComponentResult Invoke()
        {
            var values = _featureService.TGetAll();
            return View(values);
        }
    }
}
