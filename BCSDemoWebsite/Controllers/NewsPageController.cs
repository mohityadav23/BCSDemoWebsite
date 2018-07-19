using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;
using BCSDemoWebsite.Models.Pages;
using BCSDemoWebsite.Models.ViewModels;
using EPiServer;
using EPiServer.Core;
using EPiServer.Framework.DataAnnotations;
using EPiServer.Web.Mvc;

namespace BCSDemoWebsite.Controllers
{
    public class NewsPageController : PageController<NewsPage>
    {
        public ActionResult Index(NewsPage currentPage)
        {
            /* Implementation of action. You can create your own view model class that you pass to the view or
             * you can pass the page type for simpler templates */
            var model = PageViewModel.Create(currentPage);
            return View(model);
        }
    }
}