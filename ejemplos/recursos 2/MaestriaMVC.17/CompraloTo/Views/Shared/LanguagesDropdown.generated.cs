﻿#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ASP
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Linq;
    using System.Net;
    using System.Text;
    using System.Web;
    using System.Web.Helpers;
    using System.Web.Mvc;
    using System.Web.Mvc.Ajax;
    using System.Web.Mvc.Html;
    using System.Web.Routing;
    using System.Web.Security;
    using System.Web.UI;
    using System.Web.WebPages;
    using CompraloTo;
    using CompraloTo.Res;
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("RazorGenerator", "2.0.0.0")]
    [System.Web.WebPages.PageVirtualPathAttribute("~/Views/Shared/LanguagesDropdown.cshtml")]
    public partial class _Views_Shared_LanguagesDropdown_cshtml : System.Web.Mvc.WebViewPage<CompraloTo.ViewModels.LanguagesDropdownViewModel>
    {
        public _Views_Shared_LanguagesDropdown_cshtml()
        {
        }
        public override void Execute()
        {
WriteLiteral("<li");

WriteLiteral(" class=\"dropdown\"");

WriteLiteral(">\r\n    <a");

WriteLiteral(" href=\"#\"");

WriteLiteral(" class=\"dropdown-toggle\"");

WriteLiteral(" data-toggle=\"dropdown\"");

WriteLiteral(" role=\"button\"");

WriteLiteral(" aria-haspopup=\"true\"");

WriteLiteral(" aria-expanded=\"false\"");

WriteLiteral(">\r\n        <img");

WriteAttribute("src", Tuple.Create(" src=\"", 216), Tuple.Create("\"", 269)
, Tuple.Create(Tuple.Create("", 222), Tuple.Create<System.Object, System.Int32>(Href("~/public/img/flags/")
, 222), false)
            
            #line 5 "..\..\Views\Shared\LanguagesDropdown.cshtml"
, Tuple.Create(Tuple.Create("", 241), Tuple.Create<System.Object, System.Int32>(Model.CurrentLanguage
            
            #line default
            #line hidden
, 241), false)
, Tuple.Create(Tuple.Create("", 265), Tuple.Create(".png", 265), true)
);

WriteLiteral(" style=\"max-width:20px;\"");

WriteLiteral(" />\r\n        <span");

WriteLiteral(" class=\"caret\"");

WriteLiteral("></span>\r\n    </a>\r\n    <ul");

WriteLiteral(" class=\"dropdown-menu\"");

WriteLiteral(">\r\n\r\n");

            
            #line 10 "..\..\Views\Shared\LanguagesDropdown.cshtml"
        
            
            #line default
            #line hidden
            
            #line 10 "..\..\Views\Shared\LanguagesDropdown.cshtml"
         foreach(string langCode in Model.Languages)
        { 

            
            #line default
            #line hidden
WriteLiteral("        <li><a");

WriteAttribute("href", Tuple.Create(" href=\"", 460), Tuple.Create("\"", 504)
, Tuple.Create(Tuple.Create("", 467), Tuple.Create<System.Object, System.Int32>(Href("~/languageSelector?langCode=")
, 467), false)
            
            #line 12 "..\..\Views\Shared\LanguagesDropdown.cshtml"
, Tuple.Create(Tuple.Create("", 495), Tuple.Create<System.Object, System.Int32>(langCode
            
            #line default
            #line hidden
, 495), false)
);

WriteLiteral(">\r\n                <img");

WriteAttribute("src", Tuple.Create(" src=\"", 528), Tuple.Create("\"", 568)
, Tuple.Create(Tuple.Create("", 534), Tuple.Create<System.Object, System.Int32>(Href("~/public/img/flags/")
, 534), false)
            
            #line 13 "..\..\Views\Shared\LanguagesDropdown.cshtml"
, Tuple.Create(Tuple.Create("", 553), Tuple.Create<System.Object, System.Int32>(langCode
            
            #line default
            #line hidden
, 553), false)
, Tuple.Create(Tuple.Create("", 564), Tuple.Create(".png", 564), true)
);

WriteLiteral(" style=\"max-width:20px;\"");

WriteLiteral(" />\r\n            </a>\r\n        </li>\r\n");

            
            #line 16 "..\..\Views\Shared\LanguagesDropdown.cshtml"
        }

            
            #line default
            #line hidden
WriteLiteral("    </ul>\r\n</li>\r\n");

        }
    }
}
#pragma warning restore 1591