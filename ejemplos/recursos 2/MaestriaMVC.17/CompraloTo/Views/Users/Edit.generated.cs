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
    [System.Web.WebPages.PageVirtualPathAttribute("~/Views/Users/Edit.cshtml")]
    public partial class _Views_Users_Edit_cshtml : System.Web.Mvc.WebViewPage<CompraloTo.ViewModels.UserDTO>
    {
        public _Views_Users_Edit_cshtml()
        {
        }
        public override void Execute()
        {
            
            #line 3 "..\..\Views\Users\Edit.cshtml"
  
    ViewBag.Title = "Edit";

            
            #line default
            #line hidden
WriteLiteral("\r\n\r\n<h2>Edit</h2>\r\n\r\n");

            
            #line 9 "..\..\Views\Users\Edit.cshtml"
 using (Html.BeginForm())
{
    
            
            #line default
            #line hidden
            
            #line 11 "..\..\Views\Users\Edit.cshtml"
Write(Html.AntiForgeryToken());

            
            #line default
            #line hidden
            
            #line 11 "..\..\Views\Users\Edit.cshtml"
                            
    

            
            #line default
            #line hidden
WriteLiteral("    <div");

WriteLiteral(" class=\"form-horizontal\"");

WriteLiteral(">\r\n        <h4>UserDTO</h4>\r\n        <hr />\r\n");

WriteLiteral("        ");

            
            #line 16 "..\..\Views\Users\Edit.cshtml"
   Write(Html.ValidationSummary(true, "", new { @class = "text-danger" }));

            
            #line default
            #line hidden
WriteLiteral("\r\n");

WriteLiteral("        ");

            
            #line 17 "..\..\Views\Users\Edit.cshtml"
   Write(Html.HiddenFor(model => model.ID));

            
            #line default
            #line hidden
WriteLiteral("\r\n\r\n        <div");

WriteLiteral(" class=\"form-group\"");

WriteLiteral(">\r\n");

WriteLiteral("            ");

            
            #line 20 "..\..\Views\Users\Edit.cshtml"
       Write(Html.LabelFor(model => model.email, htmlAttributes: new { @class = "control-label col-md-2" }));

            
            #line default
            #line hidden
WriteLiteral("\r\n            <div");

WriteLiteral(" class=\"col-md-10\"");

WriteLiteral(">\r\n");

WriteLiteral("                ");

            
            #line 22 "..\..\Views\Users\Edit.cshtml"
           Write(Html.EditorFor(model => model.email, new { htmlAttributes = new { @class = "form-control" } }));

            
            #line default
            #line hidden
WriteLiteral("\r\n");

WriteLiteral("                ");

            
            #line 23 "..\..\Views\Users\Edit.cshtml"
           Write(Html.ValidationMessageFor(model => model.email, "", new { @class = "text-danger" }));

            
            #line default
            #line hidden
WriteLiteral("\r\n            </div>\r\n        </div>\r\n\r\n        <div");

WriteLiteral(" class=\"form-group\"");

WriteLiteral(">\r\n");

WriteLiteral("            ");

            
            #line 28 "..\..\Views\Users\Edit.cshtml"
       Write(Html.LabelFor(model => model.password, htmlAttributes: new { @class = "control-label col-md-2" }));

            
            #line default
            #line hidden
WriteLiteral("\r\n            <div");

WriteLiteral(" class=\"col-md-10\"");

WriteLiteral(">\r\n");

WriteLiteral("                ");

            
            #line 30 "..\..\Views\Users\Edit.cshtml"
           Write(Html.EditorFor(model => model.password, new { htmlAttributes = new { @class = "form-control" } }));

            
            #line default
            #line hidden
WriteLiteral("\r\n");

WriteLiteral("                ");

            
            #line 31 "..\..\Views\Users\Edit.cshtml"
           Write(Html.ValidationMessageFor(model => model.password, "", new { @class = "text-danger" }));

            
            #line default
            #line hidden
WriteLiteral("\r\n            </div>\r\n        </div>\r\n\r\n        <div");

WriteLiteral(" class=\"form-group\"");

WriteLiteral(">\r\n");

WriteLiteral("            ");

            
            #line 36 "..\..\Views\Users\Edit.cshtml"
       Write(Html.LabelFor(model => model.role, htmlAttributes: new { @class = "control-label col-md-2" }));

            
            #line default
            #line hidden
WriteLiteral("\r\n            <div");

WriteLiteral(" class=\"col-md-10\"");

WriteLiteral(">\r\n");

WriteLiteral("                ");

            
            #line 38 "..\..\Views\Users\Edit.cshtml"
           Write(Html.EnumDropDownListFor(model => model.role, htmlAttributes: new { @class = "form-control" }));

            
            #line default
            #line hidden
WriteLiteral("\r\n");

WriteLiteral("                ");

            
            #line 39 "..\..\Views\Users\Edit.cshtml"
           Write(Html.ValidationMessageFor(model => model.role, "", new { @class = "text-danger" }));

            
            #line default
            #line hidden
WriteLiteral("\r\n            </div>\r\n        </div>\r\n\r\n        <div");

WriteLiteral(" class=\"form-group\"");

WriteLiteral(">\r\n            <div");

WriteLiteral(" class=\"col-md-offset-2 col-md-10\"");

WriteLiteral(">\r\n                <input");

WriteLiteral(" type=\"submit\"");

WriteLiteral(" value=\"Save\"");

WriteLiteral(" class=\"btn btn-default\"");

WriteLiteral(" />\r\n            </div>\r\n        </div>\r\n    </div>\r\n");

            
            #line 49 "..\..\Views\Users\Edit.cshtml"
}

            
            #line default
            #line hidden
WriteLiteral("\r\n<div>\r\n");

WriteLiteral("    ");

            
            #line 52 "..\..\Views\Users\Edit.cshtml"
Write(Html.ActionLink("Back to List", "Index"));

            
            #line default
            #line hidden
WriteLiteral("\r\n</div>\r\n");

        }
    }
}
#pragma warning restore 1591
