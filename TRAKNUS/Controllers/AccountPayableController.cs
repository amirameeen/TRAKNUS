using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;

namespace TRAKNUS.Controllers
{
    public class AccountPayableController : Controller
    {
        
        // GET: EMPLOYEEs
        public ActionResult Index()
        {
            return View();
        }

        // GET: EMPLOYEEs/Details/5
        public ActionResult Details(int? id)
        {
            
        }

        // GET: EMPLOYEEs/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: EMPLOYEEs/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ID,NAME,ADDRESS")] EMPLOYEE eMPLOYEE)
        {
           
        }

        // GET: EMPLOYEEs/Edit/5
        public ActionResult Edit(int? id)
        {
          
        }

        // POST: EMPLOYEEs/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ID,NAME,ADDRESS")] EMPLOYEE eMPLOYEE)
        {
           
        }

        // GET: EMPLOYEEs/Delete/5
        public ActionResult Delete(int? id)
        {
           
        }

        // POST: EMPLOYEEs/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
           
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