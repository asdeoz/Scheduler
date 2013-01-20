using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using SchedulerDAL.Repositories;
using SchedulerModels.Entities;

namespace Scheduler.Controllers
{
    public class StudentsController : Controller
    {
        StudentsRepositories repository = new StudentsRepositories();

        //
        // GET: /Students/

        public ActionResult Index()
        {
            return View(repository.Students);
        }

        //
        // GET: /Students/Details/5

        public ActionResult Details(int id)
        {
            return View(repository.GetStudent(id));
        }

        //
        // GET: /Students/Create

        public ActionResult Create()
        {
            return View();
        } 

        //
        // POST: /Students/Create

        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here
                var student = new Student
                {
                    Name = collection.Get("Name"),
                    Surname1 = collection.Get("Surname1"),
                    Surname2 = collection.Get("Surname2"),
                    IdNumber = collection.Get("IdNumber"),
                    Email = collection.Get("Email"),
                    Phone = collection.Get("Phone"),
                    FatherName = collection.Get("FatherName"),
                    MotherName = collection.Get("MotherName")
                };

                repository.SaveStudent(student);

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
        
        //
        // GET: /Students/Edit/5
 
        public ActionResult Edit(int id)
        {
            return View(repository.GetStudent(id));
        }

        //
        // POST: /Students/Edit/5

        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here
                var student = repository.GetStudent(id);

                student.Name = collection.Get("Name");
                student.Surname1 = collection.Get("Surname1");
                student.Surname2 = collection.Get("Surname2");
                student.IdNumber = collection.Get("IdNumber");
                student.Email = collection.Get("Email");
                student.Phone = collection.Get("Phone");
                student.FatherName = collection.Get("FatherName");
                student.MotherName = collection.Get("MotherName");

                repository.SaveStudent(student);
 
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        //
        // GET: /Students/Delete/5
 
        public ActionResult Delete(int id)
        {
            return View(repository.GetStudent(id));
        }

        //
        // POST: /Students/Delete/5

        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here
                repository.DeleteStudent(id);
 
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
