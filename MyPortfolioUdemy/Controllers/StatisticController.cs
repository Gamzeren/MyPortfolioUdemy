using Microsoft.AspNetCore.Mvc;
using MyPortfolioUdemy.DAL.Context;

namespace MyPortfolioUdemy.Controllers
{
    public class StatisticController : Controller
    {
        MyPortfolioContext context=new MyPortfolioContext();
        public IActionResult Index()
        {
            ViewBag.v1 = context.Skills.Count();
            ViewBag.v2=context.Messages.Count();
            ViewBag.v3=context.Messages.Where(x=>x.IsRead==false).Count();
            ViewBag.v4=context.Messages.Where(x=>x.IsRead==true).Count();
            ViewBag.v5=context.Portfolios.Count();
            ViewBag.v6=context.Experiences.Count();
            ViewBag.v7=context.Testimonials.Count();
            ViewBag.v8=context.Testimonials.Where(x=>x.Title=="Yazılım Mühendisi").Count();
            ViewBag.v9 = context.Portfolios.Where(x => x.SubTitle == ".Net MVC5 İle Geliştirilmiştir").Count();
            ViewBag.v10 = context.Skills.Where(x => x.Value == 70).Count();
            ViewBag.v11 = context.Experiences.Where(x => x.Date == "Temmuz 2023 - Ağustos 2023").Count();
            ViewBag.v12 = context.SocialMedias.Count();
            ViewBag.v13 = context.Portfolios.Where(x => x.SubTitle == "C# WinForm ile Geliştirilmiştir").Count();
            ViewBag.v14 = context.Skills.Where(x => x.Value == 50).Count();
            ViewBag.v15 = context.Testimonials.Where(x => x.Title == "Dr. Öğretim Üyesi").Count();
            ViewBag.v16=context.Abouts.Count();
            return View();
        }
    }
}
