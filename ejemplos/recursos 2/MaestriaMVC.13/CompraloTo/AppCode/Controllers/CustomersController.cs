using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using CompraloTo.DB;
using CompraloTo.ViewModels;

namespace CompraloTo.Controllers
{
    [ActionAuthorize(Roles = "Admin")]
    public class CustomersController : Controller
    {

        private readonly ICustomerQueryService _queryService;
        private readonly ICustomerCommandService _cmdService;

        /// <summary>
        /// Constructor from IOC
        /// </summary>
        public CustomersController(ICustomerQueryService queryService, ICustomerCommandService cmdService)
        {
            _queryService = queryService;
            _cmdService = cmdService;
        }



        // GET: Customers
        [Route("customers")]
        public ActionResult GetCustomerList(GetCustomerListRequest request)
        {
            CustomerListViewModel model = new CustomerListViewModel()
            {
                Customers = _queryService.GetCustomerList(request),
                sortField = request?.sortField,
                sortDir = request?.sortDir,
                searchText = request?.searchText
            };

            return View("CustomerListView", model);
        }


        // GET: Customers/Create
        public ActionResult Create()
        {
            return View("CustomerView", new CustomerDTO());
        }


        // POST: Customers/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ID,name,lastName,address,invoiceAddress,shippingAddress,phone,email")] CustomerDTO customerDTO)
        {
            _cmdService.CreateCustomer(customerDTO);
            return RedirectToAction("Index");

            //if (ModelState.IsValid)
            //{
            //    db.CustomerDTOes.Add(customerDTO);
            //    db.SaveChanges();
            //    return RedirectToAction("Index");
            //}
            //
            //return View(customerDTO);
        }



        // GET: Customers/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }

            CustomerDTO customerDTO = _queryService.GetCustomerByID(id.Value);
            if (customerDTO == null)
            {
                return HttpNotFound();
            }
            return View("CustomerView", customerDTO);
        }



        // POST: Customers/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ID,name,lastName,address,invoiceAddress,shippingAddress,phone,email")] CustomerDTO customerDTO)
        {
            _cmdService.UpdateCustomer(customerDTO);
            return RedirectToAction("Index");

            //if (ModelState.IsValid)
            //{
            //    db.Entry(customerDTO).State = EntityState.Modified;
            //    db.SaveChanges();
            //    return RedirectToAction("Index");
            //}
            //return View(customerDTO);
        }





        // GET: Customers/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }


            CustomerDTO customerDTO = _queryService.GetCustomerByID(id.Value);
            if (customerDTO == null)
            {
                return HttpNotFound();
            }

            return View("DeleteView", customerDTO);
        }


        // POST: Customers/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {

            _cmdService.DeleteCustomer(id);

            return RedirectToAction("Index");


            //CustomerDTO customerDTO = db.CustomerDTOes.Find(id);
            //db.CustomerDTOes.Remove(customerDTO);
            //db.SaveChanges();
            //return RedirectToAction("Index");
        }

    }
}
