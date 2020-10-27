using RickLocalization.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace RickLocalization.Business.Services
{
    public interface IBrowsingHistoryService : IServiceBase<BrowsingHistory>
    {
        IEnumerable<BrowsingHistory> GetHistory();
    }
}
