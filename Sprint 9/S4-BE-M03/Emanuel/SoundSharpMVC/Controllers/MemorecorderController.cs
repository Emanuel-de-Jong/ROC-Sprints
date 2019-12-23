using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using AudioDevices.Devices;
using SoundSharpMVC.Models;

namespace SoundSharpMVC.Controllers
{
    public class MemorecorderController : Controller
    {
        private static List<MemoRecorder> memoRecorders;

        public MemorecorderController()
        {
            if(memoRecorders == null)
            {
                memoRecorders = DataProvider.GetDefaultMemorecorders();
            }
        }

        // GET: Memorecorder
        public ActionResult Index()
        {
            var vmMemorecorders = new List<VMMemorecorder>();
            foreach (var item in memoRecorders)
            {
                VMMemorecorder recorder = new VMMemorecorder();
                recorder.Make = item.Make;
                recorder.Model = item.Model;
                recorder.PriceExBtw = item.PriceExBtw;
                recorder.CreationDate = item.CreationDate;
                recorder.SerialId = item.SerialId;
                recorder.MemoCartridgetype = item.MaxCartridgeType;
                vmMemorecorders.Add(recorder);
            }
            return View(vmMemorecorders);
        }

        // GET: Memorecorder/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Memorecorder/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Memorecorder/Create
        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here
                MemoRecorder newRecorder = new MemoRecorder();
                newRecorder.Make = collection["Make"];
                newRecorder.Model = collection["Model"];
                newRecorder.CreationDate = DateTime.Parse(collection["CreationDate"]);
                newRecorder.PriceExBtw = Decimal.Parse(collection["PriceExBtw"]);
                newRecorder.MaxCartridgeType = (MemoCartridgeType)Enum.Parse(typeof(MemoCartridgeType), collection["MemoCartridgeType"]);
                memoRecorders.Add(newRecorder);
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Memorecorder/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Memorecorder/Edit/5
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

        // GET: Memorecorder/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Memorecorder/Delete/5
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
