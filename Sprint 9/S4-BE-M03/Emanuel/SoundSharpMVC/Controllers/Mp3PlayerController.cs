using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using AudioDevices.Devices;
using SoundSharpMVC.Models;

namespace SoundSharpMVC.Controllers
{
    public class Mp3PlayerController : Controller
    {
        private static List<Mp3Player> mp3Players;

        public Mp3PlayerController()
        {
            if (mp3Players == null)
            {
                mp3Players = DataProvider.GetDefaultMp3Players();
            }
        }

        // GET: Mp3Player
        public ActionResult Index()
        {
            var vmMp3Players = new List<VMMp3Player>();
            foreach (var item in mp3Players)
            {
                VMMp3Player Player = new VMMp3Player();
                Player.Make = item.Make;
                Player.Model = item.Model;
                Player.PriceExBtw = item.PriceExBtw;
                Player.CreationDate = item.CreationDate;
                Player.SerialId = item.SerialId;
                Player.MbSize = item.MBSize;
                Player.DisplayHeight = item.DisplayHeight;
                Player.DisplayWidth = item.DisplayWidth;
                vmMp3Players.Add(Player);
            }
            return View(vmMp3Players);
        }

        // GET: Mp3Player/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Mp3Player/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Mp3Player/Create
        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here
                Mp3Player newPlayer = new Mp3Player();
                newPlayer.Make = collection["Make"];
                newPlayer.Model = collection["Model"];
                newPlayer.CreationDate = DateTime.Parse(collection["CreationDate"]);
                newPlayer.PriceExBtw = Decimal.Parse(collection["PriceExBtw"]);
                newPlayer.MBSize = int.Parse(collection["MBSize"]);
                newPlayer.DisplayWidth = int.Parse(collection["DisplayWidth"]);
                newPlayer.DisplayHeight = int.Parse(collection["DisplayHeight"]);
                mp3Players.Add(newPlayer);
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Mp3Player/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Mp3Player/Edit/5
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

        // GET: Mp3Player/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Mp3Player/Delete/5
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
