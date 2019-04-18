using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using udemy.Models;

namespace udemy.Controllers
{
    public class ProductController : Controller
    {
        // GET: Product
        public ActionResult Index()
        {
            var Product = new Product() { name = "Fan", serialNumber="3838383"};
            return View(Product);
        }
        // GET: Product
        public ActionResult Create()
        {
            return View();
        }
        public ActionResult Manage()
        {
            //return Content("Hello World");
            //return HttpNotFound();
            //return new EmptyResult();
            return RedirectToAction("Index", "Product", new { page = 5, status = "success" });
        }
        public ActionResult Edit(int id)
        {
            return Content("Page result is" + id);
        }
        public ActionResult Store( int? productId, string sortBy)
        {
            if(!productId.HasValue)
            {
                productId = 1;
            }
            if (String.IsNullOrWhiteSpace(sortBy))
                sortBy = "Name";
            return Content(String.Format("product Id = {0}" +
                ", and sorted by to equal {1}", productId, sortBy));
        }

        //ViewResult
        //PartialViewResult
        //ContentResult
        //RedirectResult
        //RedirectToRouteResult
        //JsonResult
        //FileResult
        //HttpNotFoundResult
        //EmptyResult

    }
}