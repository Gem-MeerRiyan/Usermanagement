using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Usermanagement.Models;

namespace Usermanagement.Controllers
{
    public class riyan_user_detailsController : Controller
    {
        // GET: riyan_user_details
        public ActionResult Index()
        {
            using (training_dbEntities dbmodel = new training_dbEntities())
            {
                return View(dbmodel.riyan_user_details.ToList());
            }
        }

        // GET: riyan_user_details/Details/5
        public ActionResult Details(int id)
        {
            using (training_dbEntities dbModel = new training_dbEntities())
            {
                return View(dbModel.riyan_user_details.Where(x => x.UserID == id).FirstOrDefault());
            }
           
        }

        // GET: riyan_user_details/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: riyan_user_details/Create
        [HttpPost]
        public ActionResult Create(riyan_user_details customer)
        {
            try
            {
                using (training_dbEntities dbModel = new training_dbEntities())
                {
                    dbModel.riyan_user_details.Add(customer);
                    dbModel.SaveChanges();
                }

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: riyan_user_details/Edit/5
        public ActionResult Edit(int id)
        {
            using (training_dbEntities dbModel = new training_dbEntities())
            {
                return View(dbModel.riyan_user_details.Where(x => x.UserID == id).FirstOrDefault());
            }

        }

        // POST: Insertion/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, riyan_user_details customer)
        {
            try
            {
                using (training_dbEntities dbModel = new training_dbEntities())
                {
                    dbModel.Entry(customer).State = EntityState.Modified;
                    dbModel.SaveChanges();
                }
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: riyan_user_details/Delete/5
        public ActionResult Delete(int id)
        {
            using (training_dbEntities dbModel = new training_dbEntities())
            {
                return View(dbModel.riyan_user_details.Where(x => x.UserID == id).FirstOrDefault());
            }
        }

        // POST: Insertion/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                using (training_dbEntities dbModel = new training_dbEntities())
                {
                    riyan_user_details customer = dbModel.riyan_user_details.Where(x => x.UserID == id).FirstOrDefault();
                    dbModel.riyan_user_details.Remove(customer);
                    dbModel.SaveChanges();
                }
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
