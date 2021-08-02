using PolicyAdmin.QuotesMS.API.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PolicyAdmin.QuotesMS.API.Interface

{
    public interface IQuotesDBService
    {
        IEnumerable<QuoteMaster> GetQuotes(Policy policy);
        IEnumerable<QuoteMaster> GetAllQuotes();

      
    }
}
