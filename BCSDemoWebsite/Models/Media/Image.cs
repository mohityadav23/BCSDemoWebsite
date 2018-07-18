using System;
using System.ComponentModel.DataAnnotations;
using EPiServer.Core;
using EPiServer.DataAbstraction;
using EPiServer.DataAnnotations;

namespace BCSDemoWebsite.Models.Media
{
    [ContentType(DisplayName = "Image", GUID = "65ef46d9-c0ad-457a-a01c-8f1a64729962", Description = "")]
    /*[MediaDescriptor(ExtensionString = "pdf,doc,docx")]*/
    public class Image : ImageData
    {
        /*
                [CultureSpecific]
                [Editable(true)]
                [Display(
                    Name = "Description",
                    Description = "Description field's description",
                    GroupName = SystemTabNames.Content,
                    Order = 1)]*/
                public virtual string Description { get; set; }
         
    }
}