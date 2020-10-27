using RickLocalization.Data.Repositories;
using RickLocalization.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace RickLocalization.Business.Services
{
    public class DimensionService : ServiceBase<Dimension>, IDimensionService
    {
        public DimensionService(IRepositoryBase<Dimension> repository) : base(repository)
        {
        }
    }
}
