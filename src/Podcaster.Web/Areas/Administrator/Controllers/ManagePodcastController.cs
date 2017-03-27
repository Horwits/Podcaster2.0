using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

using Podcaster.Common.Constants;

namespace Podcaster.Web.Areas.Administrator.Controllers
{
    [Authorize(Roles = GlobalConstants.AdminRole)]
    public class ManagePodcastController : Controller
    {
        // GET: Administrator/PodcastManage
        public ActionResult Index()
        {
            return View();
        }

        // GET: Administrator/PodcastManage/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Administrator/PodcastManage/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Administrator/PodcastManage/Create
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

        // GET: Administrator/PodcastManage/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Administrator/PodcastManage/Edit/5
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

        // GET: Administrator/PodcastManage/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Administrator/PodcastManage/Delete/5
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
