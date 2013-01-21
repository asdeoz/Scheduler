using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using SchedulerDAL.Repositories;
using SchedulerModels.Entities;

namespace Scheduler.Controllers
{
    public class BlocksController : Controller
    {
        BlocksRepository repository = new BlocksRepository();
        TeachersRepositories tRepository = new TeachersRepositories();

        //
        // GET: /Blocks/

        public ActionResult Index()
        {
            return View(repository.BlocksLoaded);
        }

        //
        // GET: /Blocks/Details/5

        public ActionResult Details(int id)
        {
            return View();
        }

        //
        // GET: /Blocks/Create

        public ActionResult Create()
        {
            SelectList teacherList = new SelectList(tRepository.Teachers, "PersonId", "Fullname");
            ViewData["Teacher_List"] = teacherList;
            ViewData.Model = new Block();
            return View();
        } 

        //
        // POST: /Blocks/Create

        [HttpPost]
        public ActionResult Create(FormCollection collection) //Block newBlock)
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
        
        //
        // GET: /Blocks/Edit/5
 
        public ActionResult Edit(int id)
        {
            return View();
        }

        //
        // POST: /Blocks/Edit/5

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

        //
        // GET: /Blocks/Delete/5
 
        public ActionResult Delete(int id)
        {
            return View();
        }

        //
        // POST: /Blocks/Delete/5

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
