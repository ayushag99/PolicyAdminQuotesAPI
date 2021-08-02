using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PolicyAdmin.QuotesMS.API.Interface;
using PolicyAdmin.QuotesMS.API.Models;
using PolicyAdmin.QuotesMS.API.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PolicyAdmin.QuotesMS.API.Controllers
{
    [Route("api/[controller]/[Action]")]
    [ApiController]
    public class QuotesController : Controller
    {
        private readonly IQuoteRepository _repository;

        public QuotesController(IQuoteRepository repository)
        {
            _repository = repository;
        }

        [HttpGet]
        public async Task<IEnumerable<QuoteMaster>> getQuotesForPolicy([FromBody] Policy policy)
        {
            IEnumerable<QuoteMaster> quotes = await _repository.GetQuotes(policy);
            return quotes;
        }

        [HttpGet]
        public async Task<IEnumerable<QuoteMaster>> getAllQuotes()
        {
            IEnumerable<QuoteMaster> quotes = await _repository.GetAllQuotes();
            return quotes;
        }
    }
}
