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
            ArticlePageList = pages;
        }

        public IEnumerable<ArticlePage> ArticlePageList { get; set; }

    }
}