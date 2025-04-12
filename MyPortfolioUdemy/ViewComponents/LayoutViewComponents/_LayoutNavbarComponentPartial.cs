using Microsoft.AspNetCore.Mvc;
using MyPortfolioUdemy.DAL.Context;

namespace MyPortfolioUdemy.ViewComponents.LayoutViewComponents
{
    public class _LayoutNavbarComponentPartial:ViewComponent
    {
        MyPortfolioContext context=new MyPortfolioContext();
        public IViewComponentResult Invoke()
        {
            ViewBag.toDoListCount=context.toDoLists.Where(x=>x.Status==false).Count();
            var values=context.toDoLists.Where(x=>x.Status==false).ToList();
            return View(values);
        }
    }
}
