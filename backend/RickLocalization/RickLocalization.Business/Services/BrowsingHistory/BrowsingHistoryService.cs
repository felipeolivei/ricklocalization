using RickLocalization.Data.Repositories;
using RickLocalization.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace RickLocalization.Business.Services
{
    public class BrowsingHistoryService : ServiceBase<BrowsingHistory>, IBrowsingHistoryService
    {
        private readonly IBrowsingHistoryRepository _browsingHistoryRepository;

        public BrowsingHistoryService(IRepositoryBase<BrowsingHistory> repository,
            IBrowsingHistoryRepository browsingHistoryRepository) : base(repository)
        {
            _browsingHistoryRepository = browsingHistoryRepository;
        }

        public IEnumerable<BrowsingHistory> GetHistory()
        {
            return _browsingHistoryRepository.GetHistory();
        }
    }
}
