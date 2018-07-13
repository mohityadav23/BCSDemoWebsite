using BCSDemoWebsite.Models.Pages;
using BCSDemoWebsite.Models.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BCSDemoWebsite.Controllers
{
    public class StartPageController : BasePageController<StartPage>
    {
        public ActionResult Index(StartPage currentPage)
        {
            /* Implementation of action. You can create your own view model class that you pass to the view or
             * you can pass the page type for simpler templates */

            var model = PageViewModel.Create(currentPage);
            return View(model);
        }
    }
}