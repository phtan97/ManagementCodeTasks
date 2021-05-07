using ManagementCodeTasks.Data.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ManagementCodeTasks.Data.DBContext
{
    public class ManagementCodeContext : DbContext
    {
        public ManagementCodeContext(DbContextOptions<ManagementCodeContext> options) : base(options)
        {

        }

        public DbSet<Code> Code { get; set; }
        public DbSet<Comment> Comment { get; set; }
        public DbSet<FileImage> FileImage { get; set; }
        public DbSet<LanguageCode> LanguageCode { get; set; }
        public DbSet<TaskManage> TaskManage { get; set; }
        public DbSet<User> User { get; set; }
    }
}
