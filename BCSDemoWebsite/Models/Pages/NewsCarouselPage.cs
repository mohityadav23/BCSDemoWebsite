using System;
using System.ComponentModel.DataAnnotations;
using EPiServer.Core;
using EPiServer.DataAbstraction;
using EPiServer.DataAnnotations;
using EPiServer.SpecializedProperties;

namespace BCSDemoWebsite.Models.Pages
{
    [ContentType(DisplayName = "ArticleCarouselPage", GUID = "48265a5f-0336-49b2-ba53-b5175c4e8e3b", Description = "")]
    public class NewsCarouselPage : BasePage
    {
        /*
                [CultureSpecific]
                [Display(
                    Name = "Main body",
                    Description = "The main body will be shown in the main content area of the page, using the XHTML-editor you can insert for example text, images and tables.",
                    GroupName = SystemTabNames.Content,
                    Order = 1)]
                public virtual XhtmlString MainBody { get; set; }
         */
    }
}