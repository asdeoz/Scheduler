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
        BlocksRepository bRepository = new BlocksRepository();
        TeachersRepositories tRepository = new TeachersRepositories();
        GradeLevelsRepository gRepository = new GradeLevelsRepository();

        //
        // GET: /Blocks/

        public ActionResult Index()
        {
            return View(bRepository.Blocks);
        }

        //
        // GET: /Blocks/Details/5

        public ActionResult Details(int id)
        {
            //return View(bRepository.GetBlockLoaded(id));
            return View(bRepository.GetBlock(id));
        }

        //
        // GET: /Blocks/Create

        public ActionResult Create()
        {
            FillDropDowns();
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
                var block = new Block
                {
                    Name = collection.Get("Name"),
                    Description = collection.Get("Description"),
                    IsActive = string.Compare(collection.Get("IsActive"), "false") == 0 ? false : true
                };

                DateTime start, end;

                if (!DateTime.TryParse(collection.Get("StartDate"), out start) || !DateTime.TryParse(collection.Get("EndDate"), out end))
                {
                    ModelState.AddModelError("", "Start date and End date must be dates with the format [dd/mm/yyyy].");
                    FillDropDowns();
                    return View(block);
                }

                block.StartDate = start;
                block.EndDate = end;

                if (start > end)
                {
                    ModelState.AddModelError("", "The end date must be later than the start date."); 
                    FillDropDowns();
                    return View(block);
                }
                
                int teacherId, gradeId;

                if (!int.TryParse(collection.Get("teacherId"), out teacherId) || !int.TryParse(collection.Get("gradeId"), out gradeId))
                {
                    ModelState.AddModelError("", "The selected choices for Teacher and/or Grade are not correct.");
                    FillDropDowns();
                    return View(block);
                }

                if (gradeId == 0 || teacherId == 0)
                {
                    ModelState.AddModelError("", "The selected choices for Teacher and/or Grade are not correct.");
                    FillDropDowns();
                    return View(block);
                }

                //var teacher = repository.GetTeacher(teacherId);
                //var grade = repository.GetGradeLevel(gradeId);

                //if (teacher == null || grade == null)
                //{
                //    ModelState.AddModelError("", "The selected choices for Teacher and/or Grade are not correct.");
                //    FillDropDowns();
                //    return View(block);
                //}
                
                //block.Teacher = teacher;
                //block.Grade = grade;
                block.TeacherId = teacherId;
                block.GradeLevelId = gradeId;

                bRepository.SaveBlock(block);

                return RedirectToAction("Index");
            }
            catch
            {
                FillDropDowns();
                return View();
            }
        }
        
        //
        // GET: /Blocks/Edit/5
 
        public ActionResult Edit(int id)
        {
            //var block = bRepository.GetBlockLoaded(id);
            var block = bRepository.GetBlock(id);
            FillDropDowns(block.TeacherId, block.GradeLevelId);

            return View(block);
        }

        //
        // POST: /Blocks/Edit/5

        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                //var block = bRepository.GetBlockLoaded(id);
                var block = bRepository.GetBlock(id);

                block.Name = collection.Get("Name");
                block.Description = collection.Get("Description");
                block.IsActive = string.Compare(collection.Get("IsActive"), "false") == 0 ? false : true;

                DateTime start, end;

                if (!DateTime.TryParse(collection.Get("StartDate"), out start) || !DateTime.TryParse(collection.Get("EndDate"), out end))
                {
                    ModelState.AddModelError("", "Start date and End date must be dates with the format [dd/mm/yyyy].");
                    FillDropDowns(block.TeacherId, block.GradeLevelId);
                    return View(block);
                }

                block.StartDate = start;
                block.EndDate = end;

                if (start > end)
                {
                    ModelState.AddModelError("", "The end date must be later than the start date.");
                    FillDropDowns(block.TeacherId, block.GradeLevelId);
                    return View(block);
                }

                int teacherId, gradeId;

                if (!int.TryParse(collection.Get("teacherId"), out teacherId) || !int.TryParse(collection.Get("gradeId"), out gradeId))
                {
                    ModelState.AddModelError("", "The selected choices for Teacher and/or Grade are not correct.");
                    FillDropDowns(block.TeacherId, block.GradeLevelId);
                    return View(block);
                }

                if (gradeId == 0 || teacherId == 0)
                {
                    ModelState.AddModelError("", "The selected choices for Teacher and/or Grade are not correct.");
                    FillDropDowns(block.TeacherId, block.GradeLevelId);
                    return View(block);
                }


                //var teacher = repository.GetTeacher(teacherId);
                //var grade = repository.GetGradeLevel(gradeId);

                //if (teacher == null || grade == null)
                //{
                //    ModelState.AddModelError("", "The selected choices for Teacher and/or Grade are not correct.");
                //    FillDropDowns(block.Teacher, block.Grade);
                //    return View(block);
                //}

                //block.Teacher = teacher;
                //block.Grade = grade;
                block.TeacherId = teacherId;
                block.GradeLevelId = gradeId;

                bRepository.SaveBlock(block);

                return RedirectToAction("Index");
            }
            catch
            {
                var block = bRepository.GetBlock(id);
                FillDropDowns(block.TeacherId, block.GradeLevelId);
                return View();
            }
        }

        //
        // GET: /Blocks/Delete/5
 
        public ActionResult Delete(int id)
        {
            //return View(bRepository.GetBlockLoaded(id));
            return View(bRepository.GetBlock(id));
        }

        //
        // POST: /Blocks/Delete/5

        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                bRepository.DeleteBlock(id);
 
                return RedirectToAction("Index");
            }
            catch
            {
                var block = bRepository.GetBlock(id);
                FillDropDowns(block.TeacherId, block.GradeLevelId);
                return View();
            }
        }

        private void FillDropDowns()
        {
            SelectList teacherList = new SelectList(tRepository.Teachers, "PersonId", "Fullname");
            ViewData["Teacher_List"] = teacherList;
            SelectList gradesList = new SelectList(gRepository.GradeLevels, "GradeLevelId", "Name");
            ViewData["Grade_List"] = gradesList;
        }

        private void FillDropDowns(int? teacherId, int? gradeId)
        {
            SelectList teacherList = new SelectList(tRepository.Teachers, "PersonId", "Fullname", teacherId);
            ViewData["Teacher_List"] = teacherList;
            SelectList gradesList = new SelectList(gRepository.GradeLevels, "GradeLevelId", "Name", gradeId);
            ViewData["Grade_List"] = gradesList;
        }

    }
}
