using BCSDemoWebsite.Models.Pages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BCSDemoWebsite.Models.ViewModels
{
    public class CarouselDisplayViewModel
    {
        public CarouselDisplayViewModel(IEnumerable<NewsPage> pages)
        {
            NewsPageList = pages;
        }

        public IEnumerable<NewsPage> NewsPageList { get; set; }

    }
}