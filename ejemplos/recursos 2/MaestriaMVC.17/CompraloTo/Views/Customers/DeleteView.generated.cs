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
    [System.Web.WebPages.PageVirtualPathAttribute("~/Views/Customers/DeleteView.cshtml")]
    public partial class _Views_Customers_DeleteView_cshtml : System.Web.Mvc.WebViewPage<CompraloTo.ViewModels.CustomerDTO>
    {
        public _Views_Customers_DeleteView_cshtml()
        {
        }
        public override void Execute()
        {
            
            #line 3 "..\..\Views\Customers\DeleteView.cshtml"
  
    ViewBag.Title = "Delete";

            
            #line default
            #line hidden
WriteLiteral("\r\n\r\n<h2>Delete</h2>\r\n\r\n<h3>Are you sure you want to delete this?</h3>\r\n<div>\r\n   " +
" <h4>CustomerDTO</h4>\r\n    <hr />\r\n    <dl");

WriteLiteral(" class=\"dl-horizontal\"");

WriteLiteral(">\r\n        <dt>\r\n");

WriteLiteral("            ");

            
            #line 15 "..\..\Views\Customers\DeleteView.cshtml"
       Write(Html.DisplayNameFor(model => model.name));

            
            #line default
            #line hidden
WriteLiteral("\r\n        </dt>\r\n\r\n        <dd>\r\n");

WriteLiteral("            ");

            
            #line 19 "..\..\Views\Customers\DeleteView.cshtml"
       Write(Html.DisplayFor(model => model.name));

            
            #line default
            #line hidden
WriteLiteral("\r\n        </dd>\r\n\r\n        <dt>\r\n");

WriteLiteral("            ");

            
            #line 23 "..\..\Views\Customers\DeleteView.cshtml"
       Write(Html.DisplayNameFor(model => model.lastName));

            
            #line default
            #line hidden
WriteLiteral("\r\n        </dt>\r\n\r\n        <dd>\r\n");

WriteLiteral("            ");

            
            #line 27 "..\..\Views\Customers\DeleteView.cshtml"
       Write(Html.DisplayFor(model => model.lastName));

            
            #line default
            #line hidden
WriteLiteral("\r\n        </dd>\r\n\r\n        <dt>\r\n");

WriteLiteral("            ");

            
            #line 31 "..\..\Views\Customers\DeleteView.cshtml"
       Write(Html.DisplayNameFor(model => model.address));

            
            #line default
            #line hidden
WriteLiteral("\r\n        </dt>\r\n\r\n        <dd>\r\n");

WriteLiteral("            ");

            
            #line 35 "..\..\Views\Customers\DeleteView.cshtml"
       Write(Html.DisplayFor(model => model.address));

            
            #line default
            #line hidden
WriteLiteral("\r\n        </dd>\r\n\r\n        <dt>\r\n");

WriteLiteral("            ");

            
            #line 39 "..\..\Views\Customers\DeleteView.cshtml"
       Write(Html.DisplayNameFor(model => model.invoiceAddress));

            
            #line default
            #line hidden
WriteLiteral("\r\n        </dt>\r\n\r\n        <dd>\r\n");

WriteLiteral("            ");

            
            #line 43 "..\..\Views\Customers\DeleteView.cshtml"
       Write(Html.DisplayFor(model => model.invoiceAddress));

            
            #line default
            #line hidden
WriteLiteral("\r\n        </dd>\r\n\r\n        <dt>\r\n");

WriteLiteral("            ");

            
            #line 47 "..\..\Views\Customers\DeleteView.cshtml"
       Write(Html.DisplayNameFor(model => model.shippingAddress));

            
            #line default
            #line hidden
WriteLiteral("\r\n        </dt>\r\n\r\n        <dd>\r\n");

WriteLiteral("            ");

            
            #line 51 "..\..\Views\Customers\DeleteView.cshtml"
       Write(Html.DisplayFor(model => model.shippingAddress));

            
            #line default
            #line hidden
WriteLiteral("\r\n        </dd>\r\n\r\n        <dt>\r\n");

WriteLiteral("            ");

            
            #line 55 "..\..\Views\Customers\DeleteView.cshtml"
       Write(Html.DisplayNameFor(model => model.phone));

            
            #line default
            #line hidden
WriteLiteral("\r\n        </dt>\r\n\r\n        <dd>\r\n");

WriteLiteral("            ");

            
            #line 59 "..\..\Views\Customers\DeleteView.cshtml"
       Write(Html.DisplayFor(model => model.phone));

            
            #line default
            #line hidden
WriteLiteral("\r\n        </dd>\r\n\r\n        <dt>\r\n");

WriteLiteral("            ");

            
            #line 63 "..\..\Views\Customers\DeleteView.cshtml"
       Write(Html.DisplayNameFor(model => model.email));

            
            #line default
            #line hidden
WriteLiteral("\r\n        </dt>\r\n\r\n        <dd>\r\n");

WriteLiteral("            ");

            
            #line 67 "..\..\Views\Customers\DeleteView.cshtml"
       Write(Html.DisplayFor(model => model.email));

            
            #line default
            #line hidden
WriteLiteral("\r\n        </dd>\r\n\r\n    </dl>\r\n\r\n");

            
            #line 72 "..\..\Views\Customers\DeleteView.cshtml"
    
            
            #line default
            #line hidden
            
            #line 72 "..\..\Views\Customers\DeleteView.cshtml"
     using (Html.BeginForm()) {
        
            
            #line default
            #line hidden
            
            #line 73 "..\..\Views\Customers\DeleteView.cshtml"
   Write(Html.AntiForgeryToken());

            
            #line default
            #line hidden
            
            #line 73 "..\..\Views\Customers\DeleteView.cshtml"
                                


            
            #line default
            #line hidden
WriteLiteral("        <div");

WriteLiteral(" class=\"form-actions no-color\"");

WriteLiteral(">\r\n            <input");

WriteLiteral(" type=\"submit\"");

WriteLiteral(" value=\"Delete\"");

WriteLiteral(" class=\"btn btn-default\"");

WriteLiteral(" /> |\r\n");

WriteLiteral("            ");

            
            #line 77 "..\..\Views\Customers\DeleteView.cshtml"
       Write(Html.ActionLink("Back to List", "Index"));

            
            #line default
            #line hidden
WriteLiteral("\r\n        </div>\r\n");

            
            #line 79 "..\..\Views\Customers\DeleteView.cshtml"
    }

            
            #line default
            #line hidden
WriteLiteral("</div>\r\n");

        }
    }
}
#pragma warning restore 1591
