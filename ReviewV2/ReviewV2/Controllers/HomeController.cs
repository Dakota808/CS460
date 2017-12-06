using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using ReviewV2.Models;

namespace ReviewV2.Controllers
{
    public class HomeController : Controller
    {
        private AuctionContext db = new AuctionContext();

        public ActionResult Homepage()
        {
            return View();
        }
        // GET: Home
        public ActionResult Item()
        {
            var bids = db.Bids.Include(b => b.Buyer).Include(b => b.Item);
            return View(bids.ToList());
        }

        // GET: Home/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Bid bid = db.Bids.Find(id);
            if (bid == null)
            {
                return HttpNotFound();
            }
            return View(bid);
        }

        // GET: Home/Create
        public ActionResult Create()
        {
            ViewBag.bider = new SelectList(db.Buyers, "BuyersID", "BuyersName");
            ViewBag.itemID = new SelectList(db.Items, "ItemID", "itemName");
            return View();
        }

        // POST: Home/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "itemBidID,itemID,bider,timeStamps,prices")] Bid bid)
        {
            if (ModelState.IsValid)
            {
                db.Bids.Add(bid);
                db.SaveChanges();
                return RedirectToAction("Item");
            }

            ViewBag.bider = new SelectList(db.Buyers, "BuyersID", "BuyersName", bid.bider);
            ViewBag.itemID = new SelectList(db.Items, "ItemID", "itemName", bid.itemID);
            return View(bid);
        }
        // GET: Bids/Create
        public ActionResult CreateBids()
        {
            ViewBag.bider = new SelectList(db.Buyers, "BuyersID", "BuyersName");
            ViewBag.itemID = new SelectList(db.Items, "ItemID", "itemName");
            return View();
        }

        // POST: Bids/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult CreateBids([Bind(Include = "itemBidID,itemID,bider,timeStamps,prices")] Bid bid)
        {
            if (ModelState.IsValid)
            {
                bid.timeStamps=DateTime.Now;
                db.Bids.Add(bid);
                db.SaveChanges();
                return RedirectToAction("Item");
            }

            ViewBag.bider = new SelectList(db.Buyers, "BuyersID", "BuyersName", bid.bider);
            ViewBag.itemID = new SelectList(db.Items, "ItemID", "itemName", bid.itemID);
            return View(bid);
        }
        // GET: Home/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Bid bid = db.Bids.Find(id);
            if (bid == null)
            {
                return HttpNotFound();
            }
            ViewBag.bider = new SelectList(db.Buyers, "BuyersID", "BuyersName", bid.bider);
            ViewBag.itemID = new SelectList(db.Items, "ItemID", "itemName", bid.itemID);
            return View(bid);
        }

        // POST: Home/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "itemBidID,itemID,bider,timeStamps,prices")] Bid bid)
        {
            if (ModelState.IsValid)
            {
                db.Entry(bid).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Item");
            }
            ViewBag.bider = new SelectList(db.Buyers, "BuyersID", "BuyersName", bid.bider);
            ViewBag.itemID = new SelectList(db.Items, "ItemID", "itemName", bid.itemID);
            return View(bid);
        }

        // GET: Home/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Bid bid = db.Bids.Find(id);
            if (bid == null)
            {
                return HttpNotFound();
            }
            return View(bid);
        }

        // POST: Home/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Bid bid = db.Bids.Find(id);
            db.Bids.Remove(bid);
            db.SaveChanges();
            return RedirectToAction("I");
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
