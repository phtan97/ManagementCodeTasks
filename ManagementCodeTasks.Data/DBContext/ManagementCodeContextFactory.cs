using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace ManagementCodeTasks.Data.DBContext
{
    public class ManagementCodeContextFactory : IDesignTimeDbContextFactory<ManagementCodeContext>
    {
        public ManagementCodeContext CreateDbContext(string[] args)
        {
            IConfigurationRoot configuration = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json")
                .Build();

            var connectionString = configuration.GetConnectionString("CodeTaskDbContext");

            var optionsBuilder = new DbContextOptionsBuilder<ManagementCodeContext>();
            optionsBuilder.UseSqlServer(connectionString);

            return new ManagementCodeContext(optionsBuilder.Options);
        }
    }
}
