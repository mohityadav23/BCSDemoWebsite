using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using BCSDemoWebsite.Models.Blocks;
using BCSDemoWebsite.Models.Pages;
using BCSDemoWebsite.Models.ViewModels;
using EPiServer;
using EPiServer.Core;
using EPiServer.ServiceLocation;
using EPiServer.Web;
using EPiServer.Web.Mvc;

namespace BCSDemoWebsite.Controllers
{
    public class CarouselDisplayBlockController : BlockController<CarouselDisplayBlock>
    {
        public override ActionResult Index(CarouselDisplayBlock currentBlock)
        {
            var repository = ServiceLocator.Current.GetInstance<IContentRepository>();
            var getAllSubPages = repository.GetChildren<NewsPage>(currentBlock.ListContainer);

            var model = new CarouselDisplayViewModel(getAllSubPages);
            return PartialView(model);
        }
    }
}
