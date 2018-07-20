using System;
using System.ComponentModel.DataAnnotations;
using EPiServer.Core;
using EPiServer.DataAbstraction;
using EPiServer.DataAnnotations;

namespace BCSDemoWebsite.Models.Blocks
{
    [ContentType(DisplayName = "ListDisplayBlock", GUID = "0d16481f-5941-4d54-9573-2d25e65ecdd1", Description = "")]
    public class ListDisplayBlock : BlockData
    {

        [CultureSpecific]
        [Display(
            Name = "Article List Container",
            Description = "Name field's description",
            GroupName = SystemTabNames.Content,
            Order = 1)]
        public virtual PageReference ListContainer { get; set; }

    }
}