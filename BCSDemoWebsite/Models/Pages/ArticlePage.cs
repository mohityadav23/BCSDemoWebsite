using System;
using System.ComponentModel.DataAnnotations;
using EPiServer.Core;
using EPiServer.DataAbstraction;
using EPiServer.DataAnnotations;
using EPiServer.SpecializedProperties;
using EPiServer.Web;

namespace BCSDemoWebsite.Models.Pages
{
    [ContentType(DisplayName = "ArticlePage", GUID = "722d8cc4-8c35-472c-84e9-e0cdfa4b9a30", Description = "")]
    public class ArticlePage : BasePage
    {
        
                [CultureSpecific]
                [Display(
                    Name = "Main body",
                    Description = "The main body will be shown in the main content area of the page, using the XHTML-editor you can insert for example text, images and tables.",
                    GroupName = SystemTabNames.Content,
                    Order = 1)]
                public virtual XhtmlString MainBody { get; set; }
           [CultureSpecific]
        [Display(
                  Name = "Heading",
                  Description = "The main body will be shown in the main content area of the page, using the XHTML-editor you can insert for example text, images and tables.",
                  GroupName = SystemTabNames.Content,
                  Order = 0)]
        public virtual XhtmlString Heading { get; set; }

        [UIHint(UIHint.Image)]
        public virtual ContentReference Image { get; set; }
    }
}