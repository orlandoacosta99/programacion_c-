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
    [System.Web.WebPages.PageVirtualPathAttribute("~/Views/Shared/HeadView.cshtml")]
    public partial class _Views_Shared_HeadView_cshtml : System.Web.Mvc.WebViewPage<dynamic>
    {
        public _Views_Shared_HeadView_cshtml()
        {
        }
        public override void Execute()
        {
WriteLiteral("<meta");

WriteLiteral(" charset=\"utf-8\"");

WriteLiteral(" />\r\n<meta");

WriteLiteral(" name=\"viewport\"");

WriteLiteral(" content=\"width=device-width, initial-scale=1.0\"");

WriteLiteral(">\r\n\r\n<title>CompraloTó - ");

            
            #line 4 "..\..\Views\Shared\HeadView.cshtml"
               Write(ViewBag.Title);

            
            #line default
            #line hidden
WriteLiteral(" - LosMegaCursos.com</title>\r\n\r\n");

            
            #line 6 "..\..\Views\Shared\HeadView.cshtml"
 if (Utils.InProduction)
{

            
            #line default
            #line hidden
WriteLiteral("<link");

WriteAttribute("href", Tuple.Create(" href=\"", 200), Tuple.Create("\"", 261)
, Tuple.Create(Tuple.Create("", 207), Tuple.Create<System.Object, System.Int32>(Href("~/public/css/master.min.css?ver=")
, 207), false)
            
            #line 8 "..\..\Views\Shared\HeadView.cshtml"
, Tuple.Create(Tuple.Create("", 239), Tuple.Create<System.Object, System.Int32>(Utils.AssemblyVersion
            
            #line default
            #line hidden
, 239), false)
);

WriteLiteral(" rel=\"stylesheet\"");

WriteLiteral(" />\r\n");

            
            #line 9 "..\..\Views\Shared\HeadView.cshtml"
}
else
{

            
            #line default
            #line hidden
WriteLiteral("<link");

WriteAttribute("href", Tuple.Create(" href=\"", 301), Tuple.Create("\"", 331)
, Tuple.Create(Tuple.Create("", 308), Tuple.Create<System.Object, System.Int32>(Href("~/public/css/master.css")
, 308), false)
);

WriteLiteral(" rel=\"stylesheet\"");

WriteLiteral(" />\r\n");

            
            #line 13 "..\..\Views\Shared\HeadView.cshtml"
}

            
            #line default
            #line hidden
WriteLiteral("\r\n\r\n");

        }
    }
}
#pragma warning restore 1591