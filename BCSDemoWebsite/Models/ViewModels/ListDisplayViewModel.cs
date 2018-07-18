using BCSDemoWebsite.Models.Pages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BCSDemoWebsite.Models.ViewModels
{
    public class ListDisplayViewModel
    {
        public ListDisplayViewModel(IEnumerable<ArticlePage> pages)
        {
            PageList = pages;
        }

        public IEnumerable<ArticlePage> PageList { get; set; }

    }
}