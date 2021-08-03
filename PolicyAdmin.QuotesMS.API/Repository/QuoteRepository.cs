using PolicyAdmin.QuotesMS.API.Interface;
using PolicyAdmin.QuotesMS.API.Models;
using PolicyAdmin.QuotesMS.API.Models.Enum;
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

        public async Task<IEnumerable<QuoteMaster>> GetQuotes(PropertyType propertyType, int propertyValue, int businessValue)
        {
            return _provider.GetQuotes( propertyType,  propertyValue,  businessValue);
        }
    }
}
