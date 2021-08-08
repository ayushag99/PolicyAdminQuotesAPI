using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using PolicyAdmin.QuotesMS.API.Data;
using PolicyAdmin.QuotesMS.API.Models;
using PolicyAdmin.QuotesMS.API.Models.Enum;

namespace PolicyAdmin.QuotesMS.API.DataLayer
{
    public class DataGenerator
    {
        public DataGenerator( ) { }
        public static void Initialize(QuotesContext context)
        {
            List<QuoteMaster> quotes = getQuotes();
            for (int i = 0; i < quotes.Count; i++)
            {
                context.QuotesMaster.Add(quotes[i]);
            }
            context.SaveChanges();
                
            
        }
            private static List<QuoteMaster> getQuotes()
        {
            return new List<QuoteMaster>() {
                new QuoteMaster { Id=1,PropertyValueRangeFrom=0, PropertyValueRangeTo=2, BusinessValueRangeFrom=0, BusinessValueRangeTo=2, PropertyType=PropertyType.Building, Quote=30300 },
                new QuoteMaster { Id=2,PropertyValueRangeFrom=0, PropertyValueRangeTo=2, BusinessValueRangeFrom=3, BusinessValueRangeTo=5, PropertyType=PropertyType.Building, Quote=73900 },
                new QuoteMaster { Id=3,PropertyValueRangeFrom=0, PropertyValueRangeTo=2, BusinessValueRangeFrom=6, BusinessValueRangeTo=8, PropertyType=PropertyType.Building, Quote=91500 },
                new QuoteMaster { Id=4,PropertyValueRangeFrom=0, PropertyValueRangeTo=2, BusinessValueRangeFrom=9, BusinessValueRangeTo=10, PropertyType=PropertyType.Building, Quote=85300 },
                new QuoteMaster { Id=5,PropertyValueRangeFrom=3, PropertyValueRangeTo=5, BusinessValueRangeFrom=0, BusinessValueRangeTo=2, PropertyType=PropertyType.Building, Quote=99300 },
                new QuoteMaster { Id=6,PropertyValueRangeFrom=3, PropertyValueRangeTo=5, BusinessValueRangeFrom=3, BusinessValueRangeTo=5, PropertyType=PropertyType.Building, Quote=40000 },
                new QuoteMaster { Id=7,PropertyValueRangeFrom=3, PropertyValueRangeTo=5, BusinessValueRangeFrom=6, BusinessValueRangeTo=8, PropertyType=PropertyType.Building, Quote=89100 },
                new QuoteMaster { Id=8,PropertyValueRangeFrom=3, PropertyValueRangeTo=5, BusinessValueRangeFrom=9, BusinessValueRangeTo=10, PropertyType=PropertyType.Building, Quote=22400 },
                new QuoteMaster { Id=9,PropertyValueRangeFrom=6, PropertyValueRangeTo=8, BusinessValueRangeFrom=0, BusinessValueRangeTo=2, PropertyType=PropertyType.Building, Quote=14700 },
                new QuoteMaster { Id=10,PropertyValueRangeFrom=6, PropertyValueRangeTo=8, BusinessValueRangeFrom=3, BusinessValueRangeTo=5, PropertyType=PropertyType.Building, Quote=83700 },
                new QuoteMaster { Id=11,PropertyValueRangeFrom=6, PropertyValueRangeTo=8, BusinessValueRangeFrom=6, BusinessValueRangeTo=8, PropertyType=PropertyType.Building, Quote=21800 },
                new QuoteMaster { Id=12,PropertyValueRangeFrom=6, PropertyValueRangeTo=8, BusinessValueRangeFrom=9, BusinessValueRangeTo=10, PropertyType=PropertyType.Building, Quote=98700 },
                new QuoteMaster { Id=13,PropertyValueRangeFrom=9, PropertyValueRangeTo=10, BusinessValueRangeFrom=0, BusinessValueRangeTo=2, PropertyType=PropertyType.Building, Quote=56200 },
                new QuoteMaster { Id=14,PropertyValueRangeFrom=9, PropertyValueRangeTo=10, BusinessValueRangeFrom=3, BusinessValueRangeTo=5, PropertyType=PropertyType.Building, Quote=77100 },
                new QuoteMaster { Id=15,PropertyValueRangeFrom=9, PropertyValueRangeTo=10, BusinessValueRangeFrom=6, BusinessValueRangeTo=8, PropertyType=PropertyType.Building, Quote=46800 },
                new QuoteMaster { Id=16,PropertyValueRangeFrom=9, PropertyValueRangeTo=10, BusinessValueRangeFrom=9, BusinessValueRangeTo=10, PropertyType=PropertyType.Building, Quote=78200 },
            };
        }
    }

}



// Generate Random Values Python Script

//propertyType = {
//    0:"PropertyType.Building",
//    1:"PropertyType.Equipment",
//    2:"PropertyType.Singage",
//    3:"PropertyType.Inventory",
//    4:"PropertyType.Furniture"
//}
//a = []
//b = []
//for i in range(200):
//    pvrf = random.randint(0, 8)
//    pvrt = random.randint(pvrf, 8)
//    bvrf = random.randint(0, 8)
//    bvrt = random.randint(pvrf, 8)
//    pt = random.randint(0, 4)
//    quote = random.randint(100, 9999) * 100


//    a.append("new QuoteMaster {{ Id={0},PropertyValueRangeFrom={1}, PropertyValueRangeTo={2}, BusinesssValueRangeFrom={3}, BusinesssValueRangeTo={4}, PropertyType={5}, Quote={6} }}".format(i + 1, pvrf, pvrt, bvrf, bvrt, propertyType[pt], quote))
//    b.append("({},{},{},{},{},{})".format(pvrf, pvrt, bvrf, bvrt, pt, quote))

//print(*a, sep = ",\n")
//print(*b, sep = ",\n")