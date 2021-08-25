using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CapstoneBackend.Controllers
{
    public class TopicController : Controller
    {
        // GET: TopicController
        public ActionResult Index()
        {
            return View();
        }

        // GET: TopicController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: TopicController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: TopicController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: TopicController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: TopicController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: TopicController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: TopicController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
