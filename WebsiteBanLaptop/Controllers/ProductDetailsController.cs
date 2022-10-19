using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using WebsiteBanLaptop.Models;

namespace WebsiteBanLaptop.Controllers
{
    public class ProductDetailsController : Controller
    {
        private QLBanLaptopEntities1 db = new QLBanLaptopEntities1();

        // GET: ProductDetails
        public ActionResult Index()
        {
            var productDetail = db.ProductDetail.Include(p => p.Product);
            return View(productDetail.ToList());
        }

        // GET: ProductDetails/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ProductDetail productDetail = db.ProductDetail.Find(id);
            if (productDetail == null)
            {
                return HttpNotFound();
            }
            return View(productDetail);
        }

        // GET: ProductDetails/Create
        public ActionResult Create()
        {
            ViewBag.ProductID = new SelectList(db.Product, "ProductID", "Name");
            return View();
        }

        // POST: ProductDetails/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "PDID,ProductID,CPU,RAM,Storage,GraphicsCard,Screen,KeyBoard,Audio,LAN,Wireless,Webcam,CommPort,OperatingSystem,Batery,Weight,Size,Color,ProductDescription")] ProductDetail productDetail)
        {
            if (ModelState.IsValid)
            {
                db.ProductDetail.Add(productDetail);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.ProductID = new SelectList(db.Product, "ProductID", "Name", productDetail.ProductID);
            return View(productDetail);
        }

        // GET: ProductDetails/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ProductDetail productDetail = db.ProductDetail.Find(id);
            if (productDetail == null)
            {
                return HttpNotFound();
            }
            ViewBag.ProductID = new SelectList(db.Product, "ProductID", "Name", productDetail.ProductID);
            return View(productDetail);
        }

        // POST: ProductDetails/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "PDID,ProductID,CPU,RAM,Storage,GraphicsCard,Screen,KeyBoard,Audio,LAN,Wireless,Webcam,CommPort,OperatingSystem,Batery,Weight,Size,Color,ProductDescription")] ProductDetail productDetail)
        {
            if (ModelState.IsValid)
            {
                db.Entry(productDetail).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.ProductID = new SelectList(db.Product, "ProductID", "Name", productDetail.ProductID);
            return View(productDetail);
        }

        // GET: ProductDetails/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ProductDetail productDetail = db.ProductDetail.Find(id);
            if (productDetail == null)
            {
                return HttpNotFound();
            }
            return View(productDetail);
        }

        // POST: ProductDetails/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            ProductDetail productDetail = db.ProductDetail.Find(id);
            db.ProductDetail.Remove(productDetail);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
