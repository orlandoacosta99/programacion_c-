using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;



using CompraloTo.ViewModels;

namespace CompraloTo.WebPortal
{

    public interface IEmailRenderer
    {
        string GetActivationTemplate(ActivationEmailViewModel model);
    }


	/// <summary>
	/// Usamos este servicio para obtener la vista de la plantilla directamente desde MVC
	/// </summary>
	public sealed class EmailRenderer : ControllerBase,  IEmailRenderer
	{
		public string GetActivationTemplate(ActivationEmailViewModel model)
		{
			return GetTemplate("~/Views/Email/ActivationTemplate.cshtml", model);
		}

		private string GetTemplate<T>(string rutaPlantilla, T model)
		{
			using (var writer = new StringWriter())
			{
				var routeData = new RouteData();
				routeData.Values.Add("controller", "fake");
				var fakeControllerContext = new ControllerContext(
					new HttpContextWrapper(
						new HttpContext(
							new HttpRequest(null, "http://localhost:5050", null),
							new HttpResponse(null))), routeData, this
				);

                IViewEngine razorViewEngine = ViewEngines.Engines[1] as RazorViewEngine;

				var razorViewResult = razorViewEngine.FindView(fakeControllerContext,
					rutaPlantilla, "", false);

				var viewContext = new ViewContext(fakeControllerContext, razorViewResult.View,
					new ViewDataDictionary(model), new TempDataDictionary(), writer);

				razorViewResult.View.Render(viewContext, writer);
				return writer.ToString();
			}
		}


		protected override void ExecuteCore()
		{
			
		}


	}
}