using RickLocalization.Data.Context;
using RickLocalization.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace RickLocalization.Data.Repositories
{
    public class DimensionRepository : RepositoryBase<Dimension>, IDimensionRepository
    {
        public DimensionRepository(RickLocalizationDbContext dbContext) : base(dbContext)
        {
        }
    }
}
