using Microsoft.EntityFrameworkCore;
using RickLocalization.Data.Context;
using RickLocalization.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace RickLocalization.Data.Repositories
{
    public class BrowsingHistoryRepository : RepositoryBase<BrowsingHistory>, IBrowsingHistoryRepository
    {
        public BrowsingHistoryRepository(RickLocalizationDbContext dbContext) : base(dbContext)
        {
        }

        public IEnumerable<BrowsingHistory> GetHistory()
        {
            return DbSet
                 .Include(x => x.DimensionFrom)
                 .Include(x => x.DimensionTo)
                 .ToList();
        }
    }
}
