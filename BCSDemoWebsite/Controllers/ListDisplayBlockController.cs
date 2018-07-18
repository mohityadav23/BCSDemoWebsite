using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using EPiServer;
using EPiServer.Core;
using EPiServer.Web;
using EPiServer.Web.Mvc;
using BCSDemoWebsite.Models.Blocks;
using EPiServer.ServiceLocation;
using BCSDemoWebsite.Models.Pages;
using BCSDemoWebsite.Models.ViewModels;

namespace BCSDemoWebsite.Controllers
{
    public class ListDisplayBlockController : BlockController<ListDisplayBlock>
    {
        public override ActionResult Index(ListDisplayBlock currentBlock)
        {

            var repository = ServiceLocator.Current.GetInstance<IContentRepository>();
            var getAllSubPages = repository.GetChildren<ArticlePage>(currentBlock.ListContainer);

            var model = new ListDisplayViewModel(getAllSubPages);

            return PartialView(model);
        }
    }
}
