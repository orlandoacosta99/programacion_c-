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
    
    #line 1 "..\..\Views\Account\Register.cshtml"
    using CaptchaMvc.HtmlHelpers;
    
    #line default
    #line hidden
    using CompraloTo;
    using CompraloTo.Res;
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("RazorGenerator", "2.0.0.0")]
    [System.Web.WebPages.PageVirtualPathAttribute("~/Views/Account/Register.cshtml")]
    public partial class _Views_Account_Register_cshtml : System.Web.Mvc.WebViewPage<CompraloTo.ViewModels.RegisterViewModel>
    {
        public _Views_Account_Register_cshtml()
        {
        }
        public override void Execute()
        {
WriteLiteral("\r\n");

            
            #line 5 "..\..\Views\Account\Register.cshtml"
  
    ViewBag.Title = "Registro de nuevo usuario";

            
            #line default
            #line hidden
WriteLiteral("\r\n\r\n");

            
            #line 9 "..\..\Views\Account\Register.cshtml"
 if(Model != null && !string.IsNullOrEmpty(Model.errorMessage))
{

            
            #line default
            #line hidden
WriteLiteral("    <div");

WriteLiteral(" class=\"alert alert-danger\"");

WriteLiteral(">\r\n");

WriteLiteral("        ");

            
            #line 12 "..\..\Views\Account\Register.cshtml"
   Write(Model.errorMessage);

            
            #line default
            #line hidden
WriteLiteral("\r\n    </div>\r\n");

            
            #line 14 "..\..\Views\Account\Register.cshtml"
}

            
            #line default
            #line hidden
WriteLiteral("\r\n");

            
            #line 16 "..\..\Views\Account\Register.cshtml"
 using (Html.BeginForm()) 
{
    
            
            #line default
            #line hidden
            
            #line 18 "..\..\Views\Account\Register.cshtml"
Write(Html.AntiForgeryToken());

            
            #line default
            #line hidden
            
            #line 18 "..\..\Views\Account\Register.cshtml"
                            
    

            
            #line default
            #line hidden
WriteLiteral("    <div");

WriteLiteral(" class=\"form-horizontal\"");

WriteLiteral(">\r\n        <h4>Registro de nuevo usuario</h4>\r\n        <hr />\r\n");

WriteLiteral("        ");

            
            #line 23 "..\..\Views\Account\Register.cshtml"
   Write(Html.ValidationSummary(true, "", new { @class = "text-danger" }));

            
            #line default
            #line hidden
WriteLiteral("\r\n        <div");

WriteLiteral(" class=\"form-group\"");

WriteLiteral(">\r\n");

WriteLiteral("            ");

            
            #line 25 "..\..\Views\Account\Register.cshtml"
       Write(Html.LabelFor(model => model.email, htmlAttributes: new { @class = "control-label col-md-4" }));

            
            #line default
            #line hidden
WriteLiteral("\r\n            <div");

WriteLiteral(" class=\"col-md-6\"");

WriteLiteral(">\r\n");

WriteLiteral("                ");

            
            #line 27 "..\..\Views\Account\Register.cshtml"
           Write(Html.EditorFor(model => model.email, new { htmlAttributes = new { @class = "form-control" } }));

            
            #line default
            #line hidden
WriteLiteral("\r\n");

WriteLiteral("                ");

            
            #line 28 "..\..\Views\Account\Register.cshtml"
           Write(Html.ValidationMessageFor(model => model.email, "", new { @class = "text-danger" }));

            
            #line default
            #line hidden
WriteLiteral("\r\n            </div>\r\n        </div>\r\n\r\n        <div");

WriteLiteral(" class=\"form-group\"");

WriteLiteral(">\r\n");

WriteLiteral("            ");

            
            #line 33 "..\..\Views\Account\Register.cshtml"
       Write(Html.LabelFor(model => model.password, htmlAttributes: new { @class = "control-label col-md-4" }));

            
            #line default
            #line hidden
WriteLiteral("\r\n            <div");

WriteLiteral(" class=\"col-md-4\"");

WriteLiteral(">\r\n");

WriteLiteral("                ");

            
            #line 35 "..\..\Views\Account\Register.cshtml"
           Write(Html.PasswordFor(model => model.password, new { @class = "form-control" }));

            
            #line default
            #line hidden
WriteLiteral("\r\n");

WriteLiteral("                ");

            
            #line 36 "..\..\Views\Account\Register.cshtml"
           Write(Html.ValidationMessageFor(model => model.password, "", new { @class = "text-danger" }));

            
            #line default
            #line hidden
WriteLiteral("\r\n            </div>\r\n        </div>\r\n\r\n        <div");

WriteLiteral(" class=\"form-group\"");

WriteLiteral(">\r\n");

WriteLiteral("            ");

            
            #line 41 "..\..\Views\Account\Register.cshtml"
       Write(Html.LabelFor(model => model.confirm, htmlAttributes: new { @class = "control-label col-md-4" }));

            
            #line default
            #line hidden
WriteLiteral("\r\n            <div");

WriteLiteral(" class=\"col-md-4\"");

WriteLiteral(">\r\n");

WriteLiteral("                ");

            
            #line 43 "..\..\Views\Account\Register.cshtml"
           Write(Html.PasswordFor(model => model.confirm, new { @class = "form-control" }));

            
            #line default
            #line hidden
WriteLiteral("\r\n");

WriteLiteral("                ");

            
            #line 44 "..\..\Views\Account\Register.cshtml"
           Write(Html.ValidationMessageFor(model => model.confirm, "", new { @class = "text-danger" }));

            
            #line default
            #line hidden
WriteLiteral("\r\n            </div>\r\n        </div>\r\n\r\n        <div");

WriteLiteral(" class=\"form-group\"");

WriteLiteral(">\r\n            <div");

WriteLiteral(" class=\"col-md-offset-4 col-md-4\"");

WriteLiteral(">\r\n");

WriteLiteral("                ");

            
            #line 50 "..\..\Views\Account\Register.cshtml"
           Write(Html.Captcha("Refrescar", "Introduzca los carácteres de la imagen", 5, "Captcha es requerido", true));

            
            #line default
            #line hidden
WriteLiteral("\r\n            </div>\r\n        </div>\r\n\r\n        <div");

WriteLiteral(" class=\"form-group\"");

WriteLiteral(">\r\n            <div");

WriteLiteral(" class=\"col-md-offset-4 col-md-8\"");

WriteLiteral(">\r\n                <input");

WriteLiteral(" type=\"submit\"");

WriteLiteral(" value=\"Registrar usuario\"");

WriteLiteral(" class=\"btn btn-default\"");

WriteLiteral(" />\r\n            </div>\r\n        </div>\r\n    </div>\r\n");

            
            #line 60 "..\..\Views\Account\Register.cshtml"
}

            
            #line default
            #line hidden
        }
    }
}
#pragma warning restore 1591
