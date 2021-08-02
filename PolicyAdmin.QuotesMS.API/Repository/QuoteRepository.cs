using PolicyAdmin.QuotesMS.API.Interface;
using PolicyAdmin.QuotesMS.API.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PolicyAdmin.QuotesMS.API.Repository
{
    public class QuoteRepository : IQuoteRepository
    {
        IQuotesDBService _provider;
        public QuoteRepository(IQuotesDBService provider)
        {
            _provider = provider;
        }

        public async Task<IEnumerable<QuoteMaster>> GetAllQuotes()
        {
            return _provider.GetAllQuotes();
        }

        public async Task<IEnumerable<QuoteMaster>> GetQuotes(Policy policy)
        {
            return _provider.GetQuotes(policy);
        }
    }
}
