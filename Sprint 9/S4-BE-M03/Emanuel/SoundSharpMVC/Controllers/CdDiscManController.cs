using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using AudioDevices.Devices;
using SoundSharpMVC.Models;

namespace SoundSharpMVC.Controllers
{
    public class CdDiscManController : Controller
    {
        private static List<CdDiscMan> cddiscman;

        public CdDiscManController()
        {
            if(cddiscman == null)
            {
                cddiscman = DataProvider.GetDefaultCdDiscMans();
            }
        }

        // GET: CdDiscMan
        public ActionResult Index()
        {
            var VMCdDiscMan = new List<VMCdDiscMan>();
            foreach (var item in cddiscman)
            {
                VMCdDiscMan discman = new VMCdDiscMan();
                discman.SerialId = item.SerialId;
                discman.Make = item.Make;
                discman.Model = item.Model;
                discman.PriceExBtw = item.PriceExBtw;
                discman.CreationDate = item.CreationDate;
                discman.MbSize = item.MBSize;
                discman.DisplayWidth = item.DisplayWidth;
                discman.DisplayHeight = item.DisplayHeight;
                discman.TotalPixels = item.TotalPixels;
                discman.IsEjected = item.IsEjected;
                VMCdDiscMan.Add(discman);
            }
            return View(VMCdDiscMan);
        }

        // GET: CdDiscMan/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: CdDiscMan/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: CdDiscMan/Create
        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here
                CdDiscMan newCddiscman = new CdDiscMan();
                newCddiscman.Make = collection["Make"];
                newCddiscman.Model = collection["Model"];
                newCddiscman.PriceExBtw = Decimal.Parse(collection["PriceExBtw"]);
                newCddiscman.CreationDate = DateTime.Parse(collection["CreationDate"]);
                newCddiscman.DisplayWidth = int.Parse(collection["DisplayWidth"]);
                newCddiscman.DisplayHeight = int.Parse(collection["DisplayHeight"]);
                cddiscman.Add(newCddiscman);

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: CdDiscMan/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: CdDiscMan/Edit/5
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

        // GET: CdDiscMan/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: CdDiscMan/Delete/5
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
