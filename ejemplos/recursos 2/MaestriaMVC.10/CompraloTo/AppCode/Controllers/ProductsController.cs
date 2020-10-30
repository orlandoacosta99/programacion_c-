using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using System.IO;

using CompraloTo.DB;
using CompraloTo.ViewModels;

namespace CompraloTo.Controllers
{
    public class ProductsController : Controller
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


        [Route("products")]
        public ActionResult GetProductList(GetProductListRequest request)
        {
            return View("ProductListView", _queryService.GetProductList(request));
        }



        // GET: Products/Details/5
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

        // GET: Products/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Products/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(CreateUpdateProductViewModel model)
        {

            int productID = _cmdService.CreateProduct(model.product);


            System.IO.File.Copy(

                Path.Combine(Path.GetTempPath(), model.fileServer),

                Path.Combine(Server.MapPath("/public/img/products"), productID + ".jpg") ,

                true

            );


            return RedirectToAction(nameof(GetProductList));
        }

        // GET: Products/Edit/5
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

        // POST: Products/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ID,name,createDate,description,price")] ProductDTO productDTO)
        {
            throw new NotImplementedException();
            //if (ModelState.IsValid)
            //{
            //    db.Entry(productDTO).State = EntityState.Modified;
            //    db.SaveChanges();
            //    return RedirectToAction("Index");
            //}
            //return View(productDTO);
        }

        // GET: Products/Delete/5
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

        // POST: Products/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            throw new NotImplementedException();
            //ProductDTO productDTO = db.ProductDTOes.Find(id);
            //db.ProductDTOes.Remove(productDTO);
            //db.SaveChanges();
            //return RedirectToAction("Index");
        }


        [HttpPost]
        [Route("products/upload")]
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
