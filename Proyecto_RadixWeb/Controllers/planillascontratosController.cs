﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.IO;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Proyecto_RadixWeb.Models;

namespace Proyecto_RadixWeb.Controllers
{
    public class planillascontratosController : Controller
    {
        private radixEntities db = new radixEntities();

        // GET: planillascontratos
        public ActionResult Index()
        {
            return View(db.planillascontratos.ToList());
        }

        // GET: planillascontratos/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            planillascontratos planillascontratos = db.planillascontratos.Find(id);
            if (planillascontratos == null)
            {
                return HttpNotFound();
            }
            return View(planillascontratos);
        }


        public ActionResult DescargarDocx(int? id)
        {

            var archivo = db.planillascontratos.Where(p => p.PC_Id == id).FirstOrDefault();


            return File(archivo.PC_Binario, "document/docx", archivo.PC_NombreArch + ".docx");
        }

        public ActionResult DescargarPdf(int? id)
        {

            var archivo = db.planillascontratos.Where(p => p.PC_Id == id).FirstOrDefault();


            return File(archivo.PC_Binario, "document/pdf", archivo.PC_NombreArch + ".pdf");
        }




        // GET: planillascontratos/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: planillascontratos/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "PC_Id,PC_NombreArch,PC_Rev,PC_Estado,PC_PesoArch")] planillascontratos planillascontratos,HttpPostedFileBase plantilla)
        {
            if (plantilla != null && plantilla.ContentLength > 0)
            {
                var length = plantilla.InputStream.Length; //Length: 103050706
               
                byte[] datoplantilla = null;
                using (var binaryImage = new BinaryReader(plantilla.InputStream))
                {
                    datoplantilla = binaryImage.ReadBytes(plantilla.ContentLength);
                }
                planillascontratos.PC_Binario = datoplantilla;

            }


            if (ModelState.IsValid)
            {
                db.planillascontratos.Add(planillascontratos);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(planillascontratos);
        }

        // GET: planillascontratos/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            planillascontratos planillascontratos = db.planillascontratos.Find(id);
            if (planillascontratos == null)
            {
                return HttpNotFound();
            }
            return View(planillascontratos);
        }

        // POST: planillascontratos/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "PC_Id,PC_NombreArch,PC_Rev,PC_Estado,PC_PesoArch,PC_Binario")] planillascontratos planillascontratos)
        {
            if (ModelState.IsValid)
            {
                db.Entry(planillascontratos).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(planillascontratos);
        }

        // GET: planillascontratos/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            planillascontratos planillascontratos = db.planillascontratos.Find(id);
            if (planillascontratos == null)
            {
                return HttpNotFound();
            }
            return View(planillascontratos);
        }

        // POST: planillascontratos/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            planillascontratos planillascontratos = db.planillascontratos.Find(id);
            db.planillascontratos.Remove(planillascontratos);
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
