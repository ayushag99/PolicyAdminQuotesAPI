using PolicyAdmin.QuotesMS.API.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PolicyAdmin.QuotesMS.API.Interface
{
    public interface IQuoteRepository
    {
        Task<IEnumerable<QuoteMaster>> GetQuotes(Policy policy);
        Task<IEnumerable<QuoteMaster>> GetAllQuotes();
        
    }
}
