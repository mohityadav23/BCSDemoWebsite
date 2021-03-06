﻿using System;
using System.ComponentModel.DataAnnotations;
using EPiServer.Core;
using EPiServer.DataAbstraction;
using EPiServer.DataAnnotations;
using EPiServer.SpecializedProperties;

namespace BCSDemoWebsite.Models.Pages
{
    [ContentType(DisplayName = "StartPage", GUID = "a4988aaa-a6b9-44d5-a169-75b2637ea8aa", Description = "")]
    public class StartPage : BasePage
    {

        [CultureSpecific]
        [Display(
            Name = "Main body",
            Description = "The main body will be shown in the main content area of the page, using the XHTML-editor you can insert for example text, images and tables.",
            GroupName = SystemTabNames.Content,
            Order = 0)]
        public virtual XhtmlString MainBody { get; set; }

        [CultureSpecific]
        [Display(
           Name = "Content",
           Description = "The main body will be shown in the main content area of the page, using the XHTML-editor you can insert for example text, images and tables.",
           GroupName = SystemTabNames.Content,
           Order = 1)]
        public virtual ContentArea Content { get; set; }

        //[CultureSpecific]
        //[Display(
        //   Name = "Content 2",
        //   Description = "The main body will be shown in the main content area of the page, using the XHTML-editor you can insert for example text, images and tables.",
        //   GroupName = SystemTabNames.Content,
        //   Order = 2)]
        //public virtual ContentArea Content2 { get; set; }

    }
}