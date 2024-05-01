using Microsoft.AspNetCore.Mvc;

namespace UserMessageApp.ViewComponents
{
    public class _HeaderComponentPartial:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
