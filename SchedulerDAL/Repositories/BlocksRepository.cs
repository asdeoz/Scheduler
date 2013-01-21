using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SchedulerModels.Entities;

namespace SchedulerDAL.Repositories
{
    public class BlocksRepository
    {
        SchedulerContext context;

        public BlocksRepository()
        {
            context = new SchedulerContext();
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
    }
}
