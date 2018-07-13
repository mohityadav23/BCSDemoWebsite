using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;
using BCSDemoWebsite.Models.Pages;
using EPiServer;
using EPiServer.Core;
using EPiServer.Framework.DataAnnotations;
using EPiServer.Web.Mvc;

namespace BCSDemoWebsite.Controllers
{
    public abstract class BasePageController<T> : PageController<BasePage>
    {
        public ActionResult Index1(BasePage currentPage)
        {
            /* Implementation of action. You can create your own view model class that you pass to the view or
             * you can pass the page type for simpler templates */

            return View(currentPage);
        }
    }
}