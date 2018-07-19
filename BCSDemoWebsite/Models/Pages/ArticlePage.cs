using System;
using System.ComponentModel.DataAnnotations;
using EPiServer.Core;
using EPiServer.DataAbstraction;
using EPiServer.DataAnnotations;
using EPiServer.SpecializedProperties;
using EPiServer.Web;
using BCSDemoWebsite.Models.Blocks;
using EPiServer.Shell.ObjectEditing;
using System.Collections.Generic;

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
        public virtual string Heading { get; set; }

        [UIHint(UIHint.Image)]
        public virtual ContentReference Image { get; set; }
        [SelectOne(SelectionFactoryType = typeof(BlockColorSelectionFactory))]
        public virtual string ColorTheme { get; set; }
        [SelectMany(SelectionFactoryType = typeof(BlockColorSelectionFactory))]
        public virtual string MultipleLanguage { get; set; }

    }
    public class BlockColorSelectionFactory : ISelectionFactory
    {
        public IEnumerable<ISelectItem> GetSelections(ExtendedMetadata metadata)
        {
            yield return new SelectItem()
            {
                Text = "Blue",
                Value = "blue"
            };
            yield return new SelectItem()
            {
                Text = "White",
                Value = "white"
            };
            yield return new SelectItem()
            {
                Text = "Gray",
                Value = "dark"
            };
            yield return new SelectItem()
            {
                Text = "Black",
                Value = "black"
            };
            yield return new SelectItem()
            {
                Text = "Lavender",
                Value = "lavender"
            };
        }
    }


}