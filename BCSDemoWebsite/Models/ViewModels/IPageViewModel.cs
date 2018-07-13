using BCSDemoWebsite.Models.Pages;
using EPiServer.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BCSDemoWebsite.Models.ViewModels
{
    public interface IPageViewModel<out T> where T : BasePage
    {
        T CurrentPage { get; }
        LayoutModel Layout { get; set; }
        IContent Section { get; set; }
    }
}