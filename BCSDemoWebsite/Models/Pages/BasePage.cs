using System;
using System.ComponentModel.DataAnnotations;
using EPiServer.Core;
using EPiServer.DataAbstraction;
using EPiServer.DataAnnotations;
using EPiServer.SpecializedProperties;

namespace BCSDemoWebsite.Models.Pages
{
    [ContentType(DisplayName = "BasePage", GUID = "de9ffd84-7b90-4d89-83f9-9c2cffb018b1", Description = "")]
    public  abstract class BasePage : PageData
    {
        /*
                [CultureSpecific]
                [Display(
                    Name = "Main body",
                    Description = "The main body will be shown in the main content area of the page, using the XHTML-editor you can insert for example text, images and tables.",
                    GroupName = SystemTabNames.Content,
                    Order = 1)]
                public virtual XhtmlString MainBody { get; set; }
                first arush commit
                Arush second commit
                
        Mohit's first 
                
        
  
         */

    }
}