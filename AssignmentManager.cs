using MauiApp1;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp1
{
    public static class AssignmentManager
    {
        private static readonly DBContext dBContext;
        
        public static void Add(Assignment task)
        {
            using var context = new DBContext();
            context.Tasks.Add(task);
            context.SaveChanges();
        }

        public static void Update(Assignment task)
        {
            using var context = new DBContext();
            context.Tasks.Update(task);
            context.SaveChanges();
        }

        public static void Delete(Assignment task)
        {
            using var context = new DBContext();
            context.Tasks.Remove(task);
            context.SaveChanges();
        }

        public static List<Assignment> Get()
        {
            using var context = new DBContext();
            return [.. context.Tasks
            .Include(task => task.Priority)
            .Include(task => task.Status)];
        }
    }
}
