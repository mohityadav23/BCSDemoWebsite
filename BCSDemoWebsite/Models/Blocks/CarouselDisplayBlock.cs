﻿using System;
using System.ComponentModel.DataAnnotations;
using EPiServer.Core;
using EPiServer.DataAbstraction;
using EPiServer.DataAnnotations;

namespace BCSDemoWebsite.Models.Blocks
{
    [ContentType(DisplayName = "CarouselDisplayBlock", GUID = "3dc58058-ef6b-408f-bfb8-48b3005997fa", Description = "")]
    public class CarouselDisplayBlock : BlockData
    {
        [CultureSpecific]
        [Display(
           Name = "Carousel Display Container",
           Description = "Name field's description",
           GroupName = SystemTabNames.Content,
           Order = 1)]
        public virtual PageReference ListContainer { get; set; }
    }
}