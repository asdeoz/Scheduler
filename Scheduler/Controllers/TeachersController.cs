using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

using SchedulerModels.Entities;
using SchedulerDAL.Repositories;

namespace Scheduler.Controllers
{
    public class TeachersController : Controller
    {
        TeachersRepositories repository = new TeachersRepositories();

        //
        // GET: /Teachers/

        public ActionResult Index()
        {
            return View(repository.Teachers);
        }

        //
        // GET: /Teachers/Details/5

        public ActionResult Details(int id)
        {
            return View(repository.GetTeacher(id));
        }

        //
        // GET: /Teachers/Create

        public ActionResult Create()
        {
            return View();
        } 

        //
        // POST: /Teachers/Create

        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here
                var teacher = new Teacher
                {
                    Name = collection.Get("Name"),
                    Surname1 = collection.Get("Surname1"),
                    Surname2 = collection.Get("Surname2"),
                    Phone = collection.Get("Phone"),
                    IdNumber = collection.Get("IdNumber"),
                    Email = collection.Get("Email"),
                    Education = collection.Get("Education")
                };

                repository.SaveTeacher(teacher);

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
        
        //
        // GET: /Teachers/Edit/5
 
        public ActionResult Edit(int id)
        {
            return View(repository.GetTeacher(id));
        }

        //
        // POST: /Teachers/Edit/5

        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here
                var teacher = repository.GetTeacher(id);

                teacher.Name = collection.Get("Name");
                teacher.Surname1 = collection.Get("Surname1");
                teacher.Surname2 = collection.Get("Surname2");
                teacher.Phone = collection.Get("Phone");
                teacher.Email = collection.Get("Email");
                teacher.Education = collection.Get("Education");
                teacher.IdNumber = collection.Get("IdNumber");

                repository.SaveTeacher(teacher);
 
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        //
        // GET: /Teachers/Delete/5
 
        public ActionResult Delete(int id)
        {
            return View(repository.GetTeacher(id));
        }

        //
        // POST: /Teachers/Delete/5

        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here
                repository.DeleteTeacher(id);
 
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
