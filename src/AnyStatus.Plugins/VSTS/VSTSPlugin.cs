﻿using AnyStatus.API;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using Xceed.Wpf.Toolkit.PropertyGrid.Attributes;

namespace AnyStatus
{
    public abstract class VSTSPlugin : Plugin
    {
        private const string Category = "Visual Studio Team Services";

        public VSTSPlugin(bool aggregate) : base(aggregate) { }

        [Url]
        [Required]
        [Category(Category)]
        [PropertyOrder(10)]
        [Description("Required. Enter your Visual Studio Team Services account name.")]
        public string Account { get; set; }

        [Required]
        [Category(Category)]
        [PropertyOrder(20)]
        [DisplayName("Project")]
        [Description("Required (case-sensitive). Enter your Visual Studio Team Services project name.")]
        public string Project { get; set; }


        [PropertyOrder(30)]
        [Category(Category)]
        [DisplayName("User Name")]
        [Description("Optional. Enter the user name of your Visual Studio Team Services account. " +
                     "Tip: To authenticate using a Personal Access Token, leave this field empty.")]
        public string UserName { get; set; }

        [Required]
        [PropertyOrder(40)]
        [Category(Category)]
        [DisplayName("Password (Token)")]
        [Description("Required. Enter the Personal Access Token or password of your Visual Studio Team Services account. " +
                     "Tip: To authenticate using a Personal Access Token, leave the User Name field empty.")]
        [Editor(typeof(PasswordEditor), typeof(PasswordEditor))]
        public string Password { get; set; }
    }
}
