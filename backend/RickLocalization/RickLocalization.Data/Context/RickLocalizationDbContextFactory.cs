using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace RickLocalization.Data.Context
{
    internal class RickLocalizationDbContextFactory : IDesignTimeDbContextFactory<RickLocalizationDbContext>
    {

        public RickLocalizationDbContextFactory()
        {
        }

        public RickLocalizationDbContext CreateDbContext(string[] args)
        {
            IConfigurationRoot configuration = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json")
                .Build();

            var optionsBuilder = new DbContextOptionsBuilder<RickLocalizationDbContext>();

            optionsBuilder.UseSqlServer(configuration.GetConnectionString("DefaultConnection"));

            return new RickLocalizationDbContext(optionsBuilder.Options);
        }
    }
}
