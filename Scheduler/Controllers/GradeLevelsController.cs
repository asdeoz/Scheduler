using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using SchedulerModels.Entities;
using SchedulerDAL.Repositories;

namespace Scheduler.Controllers
{
    public class GradeLevelsController : Controller
    {
        GradeLevelsRepository repository = new GradeLevelsRepository();

        //
        // GET: /GradeLevels/

        public ActionResult Index()
        {
            return View(repository.GradeLevels);
        }

        //
        // GET: /GradeLevels/Details/5

        public ActionResult Details(int id)
        {
            return View(repository.GetGradeLevel(id));
        }

        //
        // GET: /GradeLevels/Create

        public ActionResult Create()
        {
            return View();
        } 

        //
        // POST: /GradeLevels/Create

        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here
                var gradeLevel = new GradeLevel
                {
                    Name = collection.Get("Name"),
                    Ages = collection.Get("Ages"),
                    Level = collection.Get("Level")
                };

                repository.SaveGradeLevel(gradeLevel);

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
        
        //
        // GET: /GradeLevels/Edit/5
 
        public ActionResult Edit(int id)
        {
            return View(repository.GetGradeLevel(id));
        }

        //
        // POST: /GradeLevels/Edit/5

        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here
                var gradeLevel = repository.GetGradeLevel(id);

                gradeLevel.Name = collection.Get("Name");
                gradeLevel.Ages = collection.Get("Ages");
                gradeLevel.Level = collection.Get("Level");

                repository.SaveGradeLevel(gradeLevel);
 
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        //
        // GET: /GradeLevels/Delete/5
 
        public ActionResult Delete(int id)
        {
            return View(repository.GetGradeLevel(id));
        }

        //
        // POST: /GradeLevels/Delete/5

        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here
                repository.DeleteGradeLevel(id);
 
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
