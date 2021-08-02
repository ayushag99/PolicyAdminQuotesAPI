﻿using Microsoft.Extensions.Configuration;
using PolicyAdmin.QuotesMS.API.Data;
using PolicyAdmin.QuotesMS.API.DataLayer;
using PolicyAdmin.QuotesMS.API.Interface;
using PolicyAdmin.QuotesMS.API.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PolicyAdmin.QuotesMS.API.Services
{
    public class QuotesDBService : IQuotesDBService
    {
        QuotesContext _context;
        public QuotesDBService(QuotesContext context)
        {
            _context = context;
          
        }

        public IEnumerable<QuoteMaster> GetAllQuotes()
        {
            var quotes = _context.QuotesMaster.Where(quote=> true);
            return quotes;
        }

        public IEnumerable<QuoteMaster> GetQuotes(Policy policy)
        {
            var quotes =  _context.QuotesMaster.Where(quote => 
                                        quote.PropertyType == policy.PropertyType &&
                                        quote.PropertyValueRangeFrom <=policy.PropertyValue &&
                                        policy.PropertyValue<=quote.PropertyValueRangeTo &&
                                        quote.BusinesssValueRangeFrom <= policy.BusinessValue &&
                                        policy.BusinessValue <= quote.BusinesssValueRangeTo
                                        );
            return quotes;
        }
    }
}

