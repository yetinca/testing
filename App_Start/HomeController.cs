﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace testowanie.App_Start
{
    public class HomeController : Controller
    {
      
        // GET: Home
        public ActionResult Index()
        {
          //  var dataContext = new BazaTestEntities();
          //  var osoby = dataContext.osoba.ToList();
          //  string lista = "";
          //foreach (var n in dataContext.osoba){
          //      lista += n;
          //  }
          //  Console.WriteLine(lista);
            return View();
        }
        public JsonResult GetData()
        {
            var db = new BazaTestEntities();
            var osoby = db.osoba.ToList();
            return Json(osoby, JsonRequestBehavior.AllowGet);
        }

        // GET: Home/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Home/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Home/Create
        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Home/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Home/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Home/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Home/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
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
