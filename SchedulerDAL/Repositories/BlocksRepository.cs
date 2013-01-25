using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SchedulerModels.Entities;

namespace SchedulerDAL.Repositories
{
    public class BlocksRepository
    {
        private static SchedulerContext context;

        public BlocksRepository()
        {
            context = new SchedulerContext();
        }

        /// <summary>
        /// Constructor with a context as a parameter
        /// </summary>
        /// <param name="_context">Shared context between repositories</param>
        public BlocksRepository(SchedulerContext _context)
        {
            context = _context;
        }

        public IQueryable<Block> Blocks
        {
            get
            {
                return context.Blocks;
            }
        }

        public IQueryable<Block> BlocksLoaded
        {
            get
            {
                return context.Blocks.Include("Teacher").Include("Grade");
            }
        }

        public Block GetBlock(int id)
        {
            var block = context.Blocks.Where(b => b.BlockId == id).FirstOrDefault();

            return block;
        }

        public Block GetBlockLoaded(int id)
        {
            var block = context.Blocks.Include("Teacher").Include("Grade").Where(b => b.BlockId == id).FirstOrDefault();

            return block;
        }

        public void SaveBlock(Block block)
        {
            if (block.BlockId == 0)
            {
                context.Blocks.Add(block);
            }

            context.SaveChanges();
        }

        public void DeleteBlock(int id)
        {
            var block = GetBlock(id);

            context.Blocks.Remove(block);

            context.SaveChanges();
        }

        public IQueryable<Teacher> Teachers
        {
            get
            {
                return context.Teachers;
            }
        }

        public IQueryable<GradeLevel> GradeLevels
        {
            get
            {
                return context.GradeLevels;
            }
        }

        public Teacher GetTeacher(int id)
        {
            var teacher = context.Teachers.Where(t => t.PersonId == id).FirstOrDefault();

            return teacher;
        }

        public GradeLevel GetGradeLevel(int id)
        {
            var gradeLevel = context.GradeLevels.Where(gl => gl.GradeLevelId == id).FirstOrDefault();

            return gradeLevel;
        }

    }
}
