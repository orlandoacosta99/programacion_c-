using System;
using System.Net;
using System.Web;
using System.Web.Mvc;
using System.IO;

using CompraloTo.ViewModels;


namespace CompraloTo.Controllers
{

    [RoutePrefix("products")]
    public sealed class ProductsController : Controller
    {
        private readonly IProductQueryService _queryService;
        private readonly IProductCommandService _cmdService;


        /// <summary>
        /// Constructor from IOC
        /// </summary>
        public ProductsController(IProductQueryService queryService, IProductCommandService cmdService)
        {
            _queryService = queryService;
            _cmdService = cmdService;
        }



        /// <summary>
        /// Return Products Full View
        /// </summary>
        [HttpGet]
        [Route("")]
        public ActionResult ProductsView()
        {
            return View("ProductsView", new ProductListViewModel()
            {
                products = _queryService.GetProductList(), 
                categories = _queryService.GetProductCategories(),
            });
        }



        /// <summary>
        /// Return list of products PARTIAL view
        /// </summary>
        [HttpGet]
        [Route("list")]
        public ActionResult ProductsListView(GetProductListRequest request)
        {
            return PartialView("ProductsListView", new ProductListViewModel() {
                
                products = _queryService.GetProductList(request),

            });
        }

        
        /// <summary>
        /// Create new product
        /// </summary>
        [HttpGet]
        [Route("create")]
        public ActionResult Create()
        {
            return View("Create", new CreateUpdateProductViewModel()
            {
                categories = _queryService.GetProductCategories(),
            });
        }


        /// <summary>
        /// POST Create new product
        /// </summary>
        [HttpPost]
        [Route("create")]
        [ValidateAntiForgeryToken]
        public ActionResult Create(CreateUpdateProductViewModel model)
        {
            if (ModelState.IsValid)
            {
                //try
                //{
                    int productID = _cmdService.CreateProduct(model.product);
                    System.IO.File.Copy(

                        Path.Combine(Path.GetTempPath(), model.fileServer),

                        Path.Combine(Server.MapPath("/public/img/products"), productID + ".jpg"),

                        true

                    );

                    return RedirectToAction(nameof(this.ProductsView));
                //}
                //catch(Exception ex)
                //{
                //    model.errorMessage = ex.Message;
                //}
            }

            model.categories = _queryService.GetProductCategories();
            return View("Create", model);
        }





        /// <summary>
        /// Get product details
        /// </summary>
        [Route("details/{id}")]
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ProductDTO productDTO = _queryService.GetProductByID(id.Value);
            if (productDTO == null)
            {
                return HttpNotFound();
            }
            return View(productDTO);
        }




        /// <summary>
        /// Load product for edit
        /// </summary>
        [Route("edit")]
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ProductDTO productDTO = _queryService.GetProductByID(id.Value);
            if (productDTO == null)
            {
                return HttpNotFound();
            }
            return View(productDTO);
        }


        /// <summary>
        /// POST edit a product
        /// </summary>
        [HttpPost]
        [Route("edit")]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(ProductDTO productDTO)
        {
            throw new NotImplementedException();
        }



        
        /// <summary>
        /// Load product for delete
        /// </summary>
        [HttpGet]
        [Route("delete")]
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ProductDTO productDTO = _queryService.GetProductByID(id.Value);
            if (productDTO == null)
            {
                return HttpNotFound();
            }
            return View(productDTO);
        }



        /// <summary>
        /// POST delete product
        /// </summary>
        [HttpPost]
        [Route("delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            throw new NotImplementedException();
        }



        [HttpPost]
        [Route("upload")]
        public JsonResult Upload()
        {
            Validate.IsTrue(Request.Files != null && Request.Files.Count > 0, "Invalid request");

            //get first file
            HttpPostedFileBase file = Request.Files[0];

            //generate temp file name
            string fileServer = Path.GetTempFileName();

            //save the file from the client
            file.SaveAs(fileServer);

            //return the file name generated back to the client
            return new JsonResult() { Data = Path.GetFileName(fileServer) };
        }


    }
}
