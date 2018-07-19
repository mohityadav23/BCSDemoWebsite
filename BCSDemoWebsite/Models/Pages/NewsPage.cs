using System;
using System.ComponentModel.DataAnnotations;
using EPiServer.Core;
using EPiServer.DataAbstraction;
using EPiServer.DataAnnotations;
using EPiServer.SpecializedProperties;
using EPiServer.Web;

namespace BCSDemoWebsite.Models.Pages
{
    [ContentType(DisplayName = "NewsPage", GUID = "ccf56827-3332-4ae2-b572-0e46fee01187", Description = "")]
    public class NewsPage : BasePage
    {

        [CultureSpecific]
        [Display(
            Name = "Heading",
            Description = "The main body will be shown in the main content area of the page, using the XHTML-editor you can insert for example text, images and tables.",
            GroupName = SystemTabNames.Content,
            Order = 1)]
        public virtual string NewsHeading { get; set; }

        [CultureSpecific]
        [Display(
                    Name = "Main body",
                    Description = "The main body will be shown in the main content area of the page, using the XHTML-editor you can insert for example text, images and tables.",
                    GroupName = SystemTabNames.Content,
                    Order = 1)]
        public virtual XhtmlString NewsMainBody { get; set; }

        [UIHint(UIHint.Image)]
        public virtual ContentReference NewsImage { get; set; }

    }
}