﻿using System;
using System.ComponentModel.DataAnnotations;
using EPiServer.Core;
using EPiServer.DataAbstraction;
using EPiServer.DataAnnotations;
using EPiServer.SpecializedProperties;

namespace BCSDemoWebsite.Models.Pages
{
    [ContentType(DisplayName = "ArticleListPage", GUID = "a4e906ef-60cd-45a8-b667-49933b0fd396", Description = "")]
    public class ArticleListPage : BasePage
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