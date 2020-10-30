using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Web;
using System.Web.Mvc;

namespace CompraloTo
{
    public static class RazorHelpers
    {

        public static IHtmlString Submit(this HtmlHelper helper, string caption, string cssClasses = null)
        {
            return new HtmlString(
                string.Format("<input type=\"submit\" value=\"{0}\" class=\"{1}\"/>", 
                    caption, cssClasses ?? "btn btn-default"));
        }

        public static IHtmlString DropZone<TModel, TValue>(this HtmlHelper<TModel> helper, Expression<Func<TModel, TValue>> model, string uploadUrl)
        {

            MemberExpression expr = model.Body as MemberExpression;
            string field = expr.ToString().Split('.')[1];

            string content =
string.Format(@"
<input id=""{0}"" name=""{0}"" type=""hidden"">
<div class=""jumbotron"">
    <div class=""dropzone"" id=""dropzoneProduct"">
        <div class=""fallback"">
            <input name = ""file"" type=""file"" />
        </div>
    </div>
  </div>
", field);


            WebViewPage page = helper.ViewDataContainer as WebViewPage;
            if (page != null)
            {
                page.DefineSection("PageScripts", () =>
                {
                    StringBuilder builder = new StringBuilder();

                    builder.Append("<script type=\"text/javascript\">");

                    builder.Append("$(document).ready(function() {");

                    //File Upload response from the server
                    builder.Append("Dropzone.options.dropzoneProduct = {");
                    builder.Append("maxFiles: 1,");

                    builder.Append("url: \"" + uploadUrl + "\",");

                    builder.Append("init: function() {");

                    builder.Append("this.on(\"complete\", function(data) {");

                    builder.Append("var res = JSON.parse(data.xhr.responseText);");
                    builder.Append("$(\"input[type = 'hidden'][name = '" + field + "'\").val(res);");
                    builder.Append("});");

                    builder.Append("}");
                    builder.Append("};");
                    builder.Append("});");

                    builder.Append("</script>");

                    page.Write(MvcHtmlString.Create(builder.ToString()));

                });
            }

            return new HtmlString(content);

        }

    }
}