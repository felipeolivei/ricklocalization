using RickLocalization.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace RickLocalization.Data.Repositories
{
    public interface IBrowsingHistoryRepository : IRepositoryBase<BrowsingHistory>
    {
        IEnumerable<BrowsingHistory> GetHistory();
    }
}
