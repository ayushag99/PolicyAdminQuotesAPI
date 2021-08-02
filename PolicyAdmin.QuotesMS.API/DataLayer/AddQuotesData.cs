﻿using System;
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
            for (int i = 0; i < 200; i++)
            {
                context.QuotesMaster.Add(quotes[i]);
            }
            context.SaveChanges();
                
            
        }
            private static List<QuoteMaster> getQuotes()
        {
            return new List<QuoteMaster>() {
new QuoteMaster { Id=1,PropertyValueRangeFrom=3, PropertyValueRangeTo=3, BusinesssValueRangeFrom=5, BusinesssValueRangeTo=5, PropertyType=PropertyType.Equipment, Quote=866500 },
new QuoteMaster { Id=2,PropertyValueRangeFrom=5, PropertyValueRangeTo=5, BusinesssValueRangeFrom=7, BusinesssValueRangeTo=8, PropertyType=PropertyType.Equipment, Quote=687400 },
new QuoteMaster { Id=3,PropertyValueRangeFrom=6, PropertyValueRangeTo=6, BusinesssValueRangeFrom=0, BusinesssValueRangeTo=8, PropertyType=PropertyType.Furniture, Quote=58000 },
new QuoteMaster { Id=4,PropertyValueRangeFrom=0, PropertyValueRangeTo=5, BusinesssValueRangeFrom=0, BusinesssValueRangeTo=1, PropertyType=PropertyType.Building, Quote=61300 },
new QuoteMaster { Id=5,PropertyValueRangeFrom=6, PropertyValueRangeTo=6, BusinesssValueRangeFrom=2, BusinesssValueRangeTo=7, PropertyType=PropertyType.Furniture, Quote=539100 },
new QuoteMaster { Id=6,PropertyValueRangeFrom=0, PropertyValueRangeTo=0, BusinesssValueRangeFrom=4, BusinesssValueRangeTo=0, PropertyType=PropertyType.Furniture, Quote=468000 },
new QuoteMaster { Id=7,PropertyValueRangeFrom=3, PropertyValueRangeTo=6, BusinesssValueRangeFrom=0, BusinesssValueRangeTo=5, PropertyType=PropertyType.Building, Quote=970500 },
new QuoteMaster { Id=8,PropertyValueRangeFrom=4, PropertyValueRangeTo=8, BusinesssValueRangeFrom=0, BusinesssValueRangeTo=6, PropertyType=PropertyType.Singage, Quote=828700 },
new QuoteMaster { Id=9,PropertyValueRangeFrom=3, PropertyValueRangeTo=8, BusinesssValueRangeFrom=5, BusinesssValueRangeTo=5, PropertyType=PropertyType.Building, Quote=420700 },
new QuoteMaster { Id=10,PropertyValueRangeFrom=0, PropertyValueRangeTo=5, BusinesssValueRangeFrom=0, BusinesssValueRangeTo=5, PropertyType=PropertyType.Equipment, Quote=654200 },
new QuoteMaster { Id=11,PropertyValueRangeFrom=4, PropertyValueRangeTo=4, BusinesssValueRangeFrom=6, BusinesssValueRangeTo=5, PropertyType=PropertyType.Singage, Quote=870400 },
new QuoteMaster { Id=12,PropertyValueRangeFrom=0, PropertyValueRangeTo=5, BusinesssValueRangeFrom=5, BusinesssValueRangeTo=4, PropertyType=PropertyType.Equipment, Quote=711400 },
new QuoteMaster { Id=13,PropertyValueRangeFrom=6, PropertyValueRangeTo=7, BusinesssValueRangeFrom=7, BusinesssValueRangeTo=7, PropertyType=PropertyType.Building, Quote=91300 },
new QuoteMaster { Id=14,PropertyValueRangeFrom=4, PropertyValueRangeTo=4, BusinesssValueRangeFrom=7, BusinesssValueRangeTo=6, PropertyType=PropertyType.Inventory, Quote=247700 },
new QuoteMaster { Id=15,PropertyValueRangeFrom=6, PropertyValueRangeTo=6, BusinesssValueRangeFrom=4, BusinesssValueRangeTo=7, PropertyType=PropertyType.Singage, Quote=139500 },
new QuoteMaster { Id=16,PropertyValueRangeFrom=0, PropertyValueRangeTo=1, BusinesssValueRangeFrom=5, BusinesssValueRangeTo=5, PropertyType=PropertyType.Equipment, Quote=855500 },
new QuoteMaster { Id=17,PropertyValueRangeFrom=2, PropertyValueRangeTo=8, BusinesssValueRangeFrom=7, BusinesssValueRangeTo=6, PropertyType=PropertyType.Furniture, Quote=837600 },
new QuoteMaster { Id=18,PropertyValueRangeFrom=3, PropertyValueRangeTo=6, BusinesssValueRangeFrom=5, BusinesssValueRangeTo=7, PropertyType=PropertyType.Furniture, Quote=725100 },
new QuoteMaster { Id=19,PropertyValueRangeFrom=7, PropertyValueRangeTo=7, BusinesssValueRangeFrom=0, BusinesssValueRangeTo=7, PropertyType=PropertyType.Equipment, Quote=955000 },
new QuoteMaster { Id=20,PropertyValueRangeFrom=0, PropertyValueRangeTo=4, BusinesssValueRangeFrom=0, BusinesssValueRangeTo=7, PropertyType=PropertyType.Building, Quote=363800 },
new QuoteMaster { Id=21,PropertyValueRangeFrom=2, PropertyValueRangeTo=2, BusinesssValueRangeFrom=6, BusinesssValueRangeTo=5, PropertyType=PropertyType.Singage, Quote=209300 },
new QuoteMaster { Id=22,PropertyValueRangeFrom=7, PropertyValueRangeTo=8, BusinesssValueRangeFrom=2, BusinesssValueRangeTo=8, PropertyType=PropertyType.Furniture, Quote=177300 },
new QuoteMaster { Id=23,PropertyValueRangeFrom=2, PropertyValueRangeTo=7, BusinesssValueRangeFrom=1, BusinesssValueRangeTo=5, PropertyType=PropertyType.Singage, Quote=944200 },
new QuoteMaster { Id=24,PropertyValueRangeFrom=5, PropertyValueRangeTo=8, BusinesssValueRangeFrom=0, BusinesssValueRangeTo=8, PropertyType=PropertyType.Inventory, Quote=331900 },
new QuoteMaster { Id=25,PropertyValueRangeFrom=5, PropertyValueRangeTo=8, BusinesssValueRangeFrom=1, BusinesssValueRangeTo=5, PropertyType=PropertyType.Building, Quote=888800 },
new QuoteMaster { Id=26,PropertyValueRangeFrom=4, PropertyValueRangeTo=6, BusinesssValueRangeFrom=4, BusinesssValueRangeTo=8, PropertyType=PropertyType.Inventory, Quote=873100 },
new QuoteMaster { Id=27,PropertyValueRangeFrom=8, PropertyValueRangeTo=8, BusinesssValueRangeFrom=0, BusinesssValueRangeTo=8, PropertyType=PropertyType.Singage, Quote=282400 },
new QuoteMaster { Id=28,PropertyValueRangeFrom=7, PropertyValueRangeTo=8, BusinesssValueRangeFrom=6, BusinesssValueRangeTo=8, PropertyType=PropertyType.Building, Quote=341600 },
new QuoteMaster { Id=29,PropertyValueRangeFrom=2, PropertyValueRangeTo=2, BusinesssValueRangeFrom=1, BusinesssValueRangeTo=5, PropertyType=PropertyType.Equipment, Quote=444900 },
new QuoteMaster { Id=30,PropertyValueRangeFrom=6, PropertyValueRangeTo=8, BusinesssValueRangeFrom=7, BusinesssValueRangeTo=8, PropertyType=PropertyType.Building, Quote=39600 },
new QuoteMaster { Id=31,PropertyValueRangeFrom=1, PropertyValueRangeTo=6, BusinesssValueRangeFrom=2, BusinesssValueRangeTo=5, PropertyType=PropertyType.Equipment, Quote=700500 },
new QuoteMaster { Id=32,PropertyValueRangeFrom=3, PropertyValueRangeTo=4, BusinesssValueRangeFrom=6, BusinesssValueRangeTo=3, PropertyType=PropertyType.Building, Quote=26800 },
new QuoteMaster { Id=33,PropertyValueRangeFrom=2, PropertyValueRangeTo=3, BusinesssValueRangeFrom=6, BusinesssValueRangeTo=4, PropertyType=PropertyType.Singage, Quote=938500 },
new QuoteMaster { Id=34,PropertyValueRangeFrom=4, PropertyValueRangeTo=6, BusinesssValueRangeFrom=5, BusinesssValueRangeTo=8, PropertyType=PropertyType.Building, Quote=439400 },
new QuoteMaster { Id=35,PropertyValueRangeFrom=2, PropertyValueRangeTo=3, BusinesssValueRangeFrom=8, BusinesssValueRangeTo=3, PropertyType=PropertyType.Building, Quote=843500 },
new QuoteMaster { Id=36,PropertyValueRangeFrom=1, PropertyValueRangeTo=7, BusinesssValueRangeFrom=8, BusinesssValueRangeTo=7, PropertyType=PropertyType.Singage, Quote=857100 },
new QuoteMaster { Id=37,PropertyValueRangeFrom=6, PropertyValueRangeTo=6, BusinesssValueRangeFrom=0, BusinesssValueRangeTo=8, PropertyType=PropertyType.Furniture, Quote=359400 },
new QuoteMaster { Id=38,PropertyValueRangeFrom=2, PropertyValueRangeTo=8, BusinesssValueRangeFrom=4, BusinesssValueRangeTo=2, PropertyType=PropertyType.Singage, Quote=651700 },
new QuoteMaster { Id=39,PropertyValueRangeFrom=2, PropertyValueRangeTo=4, BusinesssValueRangeFrom=8, BusinesssValueRangeTo=2, PropertyType=PropertyType.Furniture, Quote=739600 },
new QuoteMaster { Id=40,PropertyValueRangeFrom=2, PropertyValueRangeTo=7, BusinesssValueRangeFrom=7, BusinesssValueRangeTo=8, PropertyType=PropertyType.Building, Quote=761600 },
new QuoteMaster { Id=41,PropertyValueRangeFrom=1, PropertyValueRangeTo=4, BusinesssValueRangeFrom=6, BusinesssValueRangeTo=2, PropertyType=PropertyType.Equipment, Quote=950800 },
new QuoteMaster { Id=42,PropertyValueRangeFrom=5, PropertyValueRangeTo=7, BusinesssValueRangeFrom=0, BusinesssValueRangeTo=7, PropertyType=PropertyType.Furniture, Quote=83400 },
new QuoteMaster { Id=43,PropertyValueRangeFrom=0, PropertyValueRangeTo=6, BusinesssValueRangeFrom=1, BusinesssValueRangeTo=8, PropertyType=PropertyType.Singage, Quote=154600 },
new QuoteMaster { Id=44,PropertyValueRangeFrom=5, PropertyValueRangeTo=6, BusinesssValueRangeFrom=1, BusinesssValueRangeTo=8, PropertyType=PropertyType.Singage, Quote=55000 },
new QuoteMaster { Id=45,PropertyValueRangeFrom=6, PropertyValueRangeTo=7, BusinesssValueRangeFrom=1, BusinesssValueRangeTo=8, PropertyType=PropertyType.Inventory, Quote=885400 },
new QuoteMaster { Id=46,PropertyValueRangeFrom=1, PropertyValueRangeTo=6, BusinesssValueRangeFrom=1, BusinesssValueRangeTo=7, PropertyType=PropertyType.Singage, Quote=976700 },
new QuoteMaster { Id=47,PropertyValueRangeFrom=4, PropertyValueRangeTo=5, BusinesssValueRangeFrom=1, BusinesssValueRangeTo=7, PropertyType=PropertyType.Equipment, Quote=655400 },
new QuoteMaster { Id=48,PropertyValueRangeFrom=0, PropertyValueRangeTo=6, BusinesssValueRangeFrom=8, BusinesssValueRangeTo=6, PropertyType=PropertyType.Inventory, Quote=257600 },
new QuoteMaster { Id=49,PropertyValueRangeFrom=8, PropertyValueRangeTo=8, BusinesssValueRangeFrom=4, BusinesssValueRangeTo=8, PropertyType=PropertyType.Inventory, Quote=273100 },
new QuoteMaster { Id=50,PropertyValueRangeFrom=2, PropertyValueRangeTo=6, BusinesssValueRangeFrom=0, BusinesssValueRangeTo=7, PropertyType=PropertyType.Furniture, Quote=12400 },
new QuoteMaster { Id=51,PropertyValueRangeFrom=7, PropertyValueRangeTo=8, BusinesssValueRangeFrom=4, BusinesssValueRangeTo=8, PropertyType=PropertyType.Equipment, Quote=432100 },
new QuoteMaster { Id=52,PropertyValueRangeFrom=1, PropertyValueRangeTo=1, BusinesssValueRangeFrom=3, BusinesssValueRangeTo=5, PropertyType=PropertyType.Furniture, Quote=600900 },
new QuoteMaster { Id=53,PropertyValueRangeFrom=5, PropertyValueRangeTo=7, BusinesssValueRangeFrom=0, BusinesssValueRangeTo=6, PropertyType=PropertyType.Building, Quote=188000 },
new QuoteMaster { Id=54,PropertyValueRangeFrom=2, PropertyValueRangeTo=4, BusinesssValueRangeFrom=5, BusinesssValueRangeTo=6, PropertyType=PropertyType.Inventory, Quote=609200 },
new QuoteMaster { Id=55,PropertyValueRangeFrom=1, PropertyValueRangeTo=8, BusinesssValueRangeFrom=0, BusinesssValueRangeTo=2, PropertyType=PropertyType.Building, Quote=327300 },
new QuoteMaster { Id=56,PropertyValueRangeFrom=4, PropertyValueRangeTo=6, BusinesssValueRangeFrom=0, BusinesssValueRangeTo=6, PropertyType=PropertyType.Furniture, Quote=502800 },
new QuoteMaster { Id=57,PropertyValueRangeFrom=2, PropertyValueRangeTo=5, BusinesssValueRangeFrom=4, BusinesssValueRangeTo=7, PropertyType=PropertyType.Inventory, Quote=289600 },
new QuoteMaster { Id=58,PropertyValueRangeFrom=0, PropertyValueRangeTo=6, BusinesssValueRangeFrom=1, BusinesssValueRangeTo=8, PropertyType=PropertyType.Building, Quote=469800 },
new QuoteMaster { Id=59,PropertyValueRangeFrom=7, PropertyValueRangeTo=8, BusinesssValueRangeFrom=2, BusinesssValueRangeTo=7, PropertyType=PropertyType.Inventory, Quote=339800 },
new QuoteMaster { Id=60,PropertyValueRangeFrom=0, PropertyValueRangeTo=2, BusinesssValueRangeFrom=6, BusinesssValueRangeTo=8, PropertyType=PropertyType.Furniture, Quote=76500 },
new QuoteMaster { Id=61,PropertyValueRangeFrom=2, PropertyValueRangeTo=6, BusinesssValueRangeFrom=4, BusinesssValueRangeTo=7, PropertyType=PropertyType.Inventory, Quote=233400 },
new QuoteMaster { Id=62,PropertyValueRangeFrom=6, PropertyValueRangeTo=6, BusinesssValueRangeFrom=5, BusinesssValueRangeTo=6, PropertyType=PropertyType.Inventory, Quote=727500 },
new QuoteMaster { Id=63,PropertyValueRangeFrom=3, PropertyValueRangeTo=4, BusinesssValueRangeFrom=2, BusinesssValueRangeTo=3, PropertyType=PropertyType.Building, Quote=854300 },
new QuoteMaster { Id=64,PropertyValueRangeFrom=4, PropertyValueRangeTo=4, BusinesssValueRangeFrom=8, BusinesssValueRangeTo=6, PropertyType=PropertyType.Equipment, Quote=588700 },
new QuoteMaster { Id=65,PropertyValueRangeFrom=6, PropertyValueRangeTo=8, BusinesssValueRangeFrom=7, BusinesssValueRangeTo=7, PropertyType=PropertyType.Singage, Quote=973200 },
new QuoteMaster { Id=66,PropertyValueRangeFrom=2, PropertyValueRangeTo=3, BusinesssValueRangeFrom=0, BusinesssValueRangeTo=4, PropertyType=PropertyType.Building, Quote=718800 },
new QuoteMaster { Id=67,PropertyValueRangeFrom=0, PropertyValueRangeTo=6, BusinesssValueRangeFrom=2, BusinesssValueRangeTo=0, PropertyType=PropertyType.Equipment, Quote=368100 },
new QuoteMaster { Id=68,PropertyValueRangeFrom=0, PropertyValueRangeTo=8, BusinesssValueRangeFrom=3, BusinesssValueRangeTo=7, PropertyType=PropertyType.Singage, Quote=884900 },
new QuoteMaster { Id=69,PropertyValueRangeFrom=2, PropertyValueRangeTo=6, BusinesssValueRangeFrom=8, BusinesssValueRangeTo=4, PropertyType=PropertyType.Building, Quote=757400 },
new QuoteMaster { Id=70,PropertyValueRangeFrom=2, PropertyValueRangeTo=6, BusinesssValueRangeFrom=2, BusinesssValueRangeTo=7, PropertyType=PropertyType.Furniture, Quote=30100 },
new QuoteMaster { Id=71,PropertyValueRangeFrom=6, PropertyValueRangeTo=8, BusinesssValueRangeFrom=7, BusinesssValueRangeTo=8, PropertyType=PropertyType.Equipment, Quote=931200 },
new QuoteMaster { Id=72,PropertyValueRangeFrom=5, PropertyValueRangeTo=5, BusinesssValueRangeFrom=4, BusinesssValueRangeTo=6, PropertyType=PropertyType.Equipment, Quote=651600 },
new QuoteMaster { Id=73,PropertyValueRangeFrom=3, PropertyValueRangeTo=5, BusinesssValueRangeFrom=6, BusinesssValueRangeTo=7, PropertyType=PropertyType.Furniture, Quote=844200 },
new QuoteMaster { Id=74,PropertyValueRangeFrom=1, PropertyValueRangeTo=6, BusinesssValueRangeFrom=2, BusinesssValueRangeTo=1, PropertyType=PropertyType.Furniture, Quote=243100 },
new QuoteMaster { Id=75,PropertyValueRangeFrom=6, PropertyValueRangeTo=6, BusinesssValueRangeFrom=5, BusinesssValueRangeTo=6, PropertyType=PropertyType.Furniture, Quote=43900 },
new QuoteMaster { Id=76,PropertyValueRangeFrom=7, PropertyValueRangeTo=8, BusinesssValueRangeFrom=3, BusinesssValueRangeTo=7, PropertyType=PropertyType.Building, Quote=414900 },
new QuoteMaster { Id=77,PropertyValueRangeFrom=5, PropertyValueRangeTo=5, BusinesssValueRangeFrom=8, BusinesssValueRangeTo=7, PropertyType=PropertyType.Building, Quote=364000 },
new QuoteMaster { Id=78,PropertyValueRangeFrom=7, PropertyValueRangeTo=7, BusinesssValueRangeFrom=0, BusinesssValueRangeTo=8, PropertyType=PropertyType.Equipment, Quote=956000 },
new QuoteMaster { Id=79,PropertyValueRangeFrom=3, PropertyValueRangeTo=3, BusinesssValueRangeFrom=0, BusinesssValueRangeTo=5, PropertyType=PropertyType.Building, Quote=501500 },
new QuoteMaster { Id=80,PropertyValueRangeFrom=0, PropertyValueRangeTo=6, BusinesssValueRangeFrom=4, BusinesssValueRangeTo=5, PropertyType=PropertyType.Building, Quote=331800 },
new QuoteMaster { Id=81,PropertyValueRangeFrom=3, PropertyValueRangeTo=3, BusinesssValueRangeFrom=6, BusinesssValueRangeTo=4, PropertyType=PropertyType.Furniture, Quote=138100 },
new QuoteMaster { Id=82,PropertyValueRangeFrom=5, PropertyValueRangeTo=6, BusinesssValueRangeFrom=0, BusinesssValueRangeTo=6, PropertyType=PropertyType.Building, Quote=93500 },
new QuoteMaster { Id=83,PropertyValueRangeFrom=6, PropertyValueRangeTo=6, BusinesssValueRangeFrom=3, BusinesssValueRangeTo=7, PropertyType=PropertyType.Inventory, Quote=101400 },
new QuoteMaster { Id=84,PropertyValueRangeFrom=3, PropertyValueRangeTo=8, BusinesssValueRangeFrom=5, BusinesssValueRangeTo=7, PropertyType=PropertyType.Building, Quote=312800 },
new QuoteMaster { Id=85,PropertyValueRangeFrom=6, PropertyValueRangeTo=8, BusinesssValueRangeFrom=7, BusinesssValueRangeTo=7, PropertyType=PropertyType.Inventory, Quote=381400 },
new QuoteMaster { Id=86,PropertyValueRangeFrom=1, PropertyValueRangeTo=5, BusinesssValueRangeFrom=5, BusinesssValueRangeTo=1, PropertyType=PropertyType.Inventory, Quote=583100 },
new QuoteMaster { Id=87,PropertyValueRangeFrom=5, PropertyValueRangeTo=5, BusinesssValueRangeFrom=6, BusinesssValueRangeTo=6, PropertyType=PropertyType.Singage, Quote=727300 },
new QuoteMaster { Id=88,PropertyValueRangeFrom=1, PropertyValueRangeTo=3, BusinesssValueRangeFrom=0, BusinesssValueRangeTo=6, PropertyType=PropertyType.Singage, Quote=892800 },
new QuoteMaster { Id=89,PropertyValueRangeFrom=3, PropertyValueRangeTo=5, BusinesssValueRangeFrom=1, BusinesssValueRangeTo=6, PropertyType=PropertyType.Building, Quote=683800 },
new QuoteMaster { Id=90,PropertyValueRangeFrom=4, PropertyValueRangeTo=7, BusinesssValueRangeFrom=8, BusinesssValueRangeTo=7, PropertyType=PropertyType.Building, Quote=76000 },
new QuoteMaster { Id=91,PropertyValueRangeFrom=0, PropertyValueRangeTo=4, BusinesssValueRangeFrom=3, BusinesssValueRangeTo=6, PropertyType=PropertyType.Equipment, Quote=99100 },
new QuoteMaster { Id=92,PropertyValueRangeFrom=1, PropertyValueRangeTo=2, BusinesssValueRangeFrom=2, BusinesssValueRangeTo=3, PropertyType=PropertyType.Furniture, Quote=838900 },
new QuoteMaster { Id=93,PropertyValueRangeFrom=4, PropertyValueRangeTo=4, BusinesssValueRangeFrom=1, BusinesssValueRangeTo=8, PropertyType=PropertyType.Building, Quote=270800 },
new QuoteMaster { Id=94,PropertyValueRangeFrom=7, PropertyValueRangeTo=8, BusinesssValueRangeFrom=3, BusinesssValueRangeTo=7, PropertyType=PropertyType.Inventory, Quote=114200 },
new QuoteMaster { Id=95,PropertyValueRangeFrom=1, PropertyValueRangeTo=7, BusinesssValueRangeFrom=4, BusinesssValueRangeTo=6, PropertyType=PropertyType.Building, Quote=273700 },
new QuoteMaster { Id=96,PropertyValueRangeFrom=3, PropertyValueRangeTo=3, BusinesssValueRangeFrom=6, BusinesssValueRangeTo=6, PropertyType=PropertyType.Inventory, Quote=656100 },
new QuoteMaster { Id=97,PropertyValueRangeFrom=3, PropertyValueRangeTo=4, BusinesssValueRangeFrom=7, BusinesssValueRangeTo=8, PropertyType=PropertyType.Equipment, Quote=487100 },
new QuoteMaster { Id=98,PropertyValueRangeFrom=2, PropertyValueRangeTo=4, BusinesssValueRangeFrom=5, BusinesssValueRangeTo=5, PropertyType=PropertyType.Building, Quote=453100 },
new QuoteMaster { Id=99,PropertyValueRangeFrom=2, PropertyValueRangeTo=3, BusinesssValueRangeFrom=0, BusinesssValueRangeTo=2, PropertyType=PropertyType.Furniture, Quote=758600 },
new QuoteMaster { Id=100,PropertyValueRangeFrom=4, PropertyValueRangeTo=5, BusinesssValueRangeFrom=8, BusinesssValueRangeTo=4, PropertyType=PropertyType.Inventory, Quote=21400 },
new QuoteMaster { Id=101,PropertyValueRangeFrom=1, PropertyValueRangeTo=4, BusinesssValueRangeFrom=2, BusinesssValueRangeTo=5, PropertyType=PropertyType.Singage, Quote=589300 },
new QuoteMaster { Id=102,PropertyValueRangeFrom=3, PropertyValueRangeTo=8, BusinesssValueRangeFrom=5, BusinesssValueRangeTo=5, PropertyType=PropertyType.Singage, Quote=232500 },
new QuoteMaster { Id=103,PropertyValueRangeFrom=5, PropertyValueRangeTo=7, BusinesssValueRangeFrom=4, BusinesssValueRangeTo=6, PropertyType=PropertyType.Singage, Quote=25200 },
new QuoteMaster { Id=104,PropertyValueRangeFrom=0, PropertyValueRangeTo=2, BusinesssValueRangeFrom=5, BusinesssValueRangeTo=6, PropertyType=PropertyType.Furniture, Quote=687100 },
new QuoteMaster { Id=105,PropertyValueRangeFrom=0, PropertyValueRangeTo=0, BusinesssValueRangeFrom=5, BusinesssValueRangeTo=4, PropertyType=PropertyType.Singage, Quote=722400 },
new QuoteMaster { Id=106,PropertyValueRangeFrom=8, PropertyValueRangeTo=8, BusinesssValueRangeFrom=5, BusinesssValueRangeTo=8, PropertyType=PropertyType.Singage, Quote=911600 },
new QuoteMaster { Id=107,PropertyValueRangeFrom=8, PropertyValueRangeTo=8, BusinesssValueRangeFrom=8, BusinesssValueRangeTo=8, PropertyType=PropertyType.Building, Quote=116100 },
new QuoteMaster { Id=108,PropertyValueRangeFrom=8, PropertyValueRangeTo=8, BusinesssValueRangeFrom=3, BusinesssValueRangeTo=8, PropertyType=PropertyType.Inventory, Quote=522800 },
new QuoteMaster { Id=109,PropertyValueRangeFrom=3, PropertyValueRangeTo=7, BusinesssValueRangeFrom=8, BusinesssValueRangeTo=8, PropertyType=PropertyType.Equipment, Quote=312100 },
new QuoteMaster { Id=110,PropertyValueRangeFrom=2, PropertyValueRangeTo=8, BusinesssValueRangeFrom=2, BusinesssValueRangeTo=3, PropertyType=PropertyType.Singage, Quote=481900 },
new QuoteMaster { Id=111,PropertyValueRangeFrom=5, PropertyValueRangeTo=7, BusinesssValueRangeFrom=4, BusinesssValueRangeTo=5, PropertyType=PropertyType.Building, Quote=392000 },
new QuoteMaster { Id=112,PropertyValueRangeFrom=8, PropertyValueRangeTo=8, BusinesssValueRangeFrom=4, BusinesssValueRangeTo=8, PropertyType=PropertyType.Equipment, Quote=218300 },
new QuoteMaster { Id=113,PropertyValueRangeFrom=8, PropertyValueRangeTo=8, BusinesssValueRangeFrom=0, BusinesssValueRangeTo=8, PropertyType=PropertyType.Equipment, Quote=95400 },
new QuoteMaster { Id=114,PropertyValueRangeFrom=6, PropertyValueRangeTo=7, BusinesssValueRangeFrom=1, BusinesssValueRangeTo=7, PropertyType=PropertyType.Singage, Quote=869500 },
new QuoteMaster { Id=115,PropertyValueRangeFrom=1, PropertyValueRangeTo=5, BusinesssValueRangeFrom=1, BusinesssValueRangeTo=4, PropertyType=PropertyType.Equipment, Quote=413600 },
new QuoteMaster { Id=116,PropertyValueRangeFrom=8, PropertyValueRangeTo=8, BusinesssValueRangeFrom=0, BusinesssValueRangeTo=8, PropertyType=PropertyType.Building, Quote=131900 },
new QuoteMaster { Id=117,PropertyValueRangeFrom=4, PropertyValueRangeTo=6, BusinesssValueRangeFrom=7, BusinesssValueRangeTo=8, PropertyType=PropertyType.Building, Quote=359500 },
new QuoteMaster { Id=118,PropertyValueRangeFrom=3, PropertyValueRangeTo=3, BusinesssValueRangeFrom=5, BusinesssValueRangeTo=4, PropertyType=PropertyType.Singage, Quote=967800 },
new QuoteMaster { Id=119,PropertyValueRangeFrom=8, PropertyValueRangeTo=8, BusinesssValueRangeFrom=5, BusinesssValueRangeTo=8, PropertyType=PropertyType.Building, Quote=707300 },
new QuoteMaster { Id=120,PropertyValueRangeFrom=5, PropertyValueRangeTo=7, BusinesssValueRangeFrom=1, BusinesssValueRangeTo=6, PropertyType=PropertyType.Inventory, Quote=75000 },
new QuoteMaster { Id=121,PropertyValueRangeFrom=0, PropertyValueRangeTo=2, BusinesssValueRangeFrom=3, BusinesssValueRangeTo=5, PropertyType=PropertyType.Building, Quote=105300 },
new QuoteMaster { Id=122,PropertyValueRangeFrom=5, PropertyValueRangeTo=5, BusinesssValueRangeFrom=4, BusinesssValueRangeTo=5, PropertyType=PropertyType.Inventory, Quote=607500 },
new QuoteMaster { Id=123,PropertyValueRangeFrom=2, PropertyValueRangeTo=4, BusinesssValueRangeFrom=2, BusinesssValueRangeTo=7, PropertyType=PropertyType.Building, Quote=72900 },
new QuoteMaster { Id=124,PropertyValueRangeFrom=4, PropertyValueRangeTo=8, BusinesssValueRangeFrom=3, BusinesssValueRangeTo=4, PropertyType=PropertyType.Inventory, Quote=166000 },
new QuoteMaster { Id=125,PropertyValueRangeFrom=2, PropertyValueRangeTo=8, BusinesssValueRangeFrom=5, BusinesssValueRangeTo=5, PropertyType=PropertyType.Singage, Quote=609000 },
new QuoteMaster { Id=126,PropertyValueRangeFrom=3, PropertyValueRangeTo=4, BusinesssValueRangeFrom=7, BusinesssValueRangeTo=4, PropertyType=PropertyType.Building, Quote=19900 },
new QuoteMaster { Id=127,PropertyValueRangeFrom=4, PropertyValueRangeTo=7, BusinesssValueRangeFrom=4, BusinesssValueRangeTo=8, PropertyType=PropertyType.Building, Quote=244700 },
new QuoteMaster { Id=128,PropertyValueRangeFrom=2, PropertyValueRangeTo=4, BusinesssValueRangeFrom=7, BusinesssValueRangeTo=5, PropertyType=PropertyType.Furniture, Quote=785900 },
new QuoteMaster { Id=129,PropertyValueRangeFrom=4, PropertyValueRangeTo=8, BusinesssValueRangeFrom=2, BusinesssValueRangeTo=4, PropertyType=PropertyType.Building, Quote=525700 },
new QuoteMaster { Id=130,PropertyValueRangeFrom=0, PropertyValueRangeTo=1, BusinesssValueRangeFrom=7, BusinesssValueRangeTo=7, PropertyType=PropertyType.Building, Quote=480700 },
new QuoteMaster { Id=131,PropertyValueRangeFrom=4, PropertyValueRangeTo=6, BusinesssValueRangeFrom=5, BusinesssValueRangeTo=8, PropertyType=PropertyType.Equipment, Quote=106300 },
new QuoteMaster { Id=132,PropertyValueRangeFrom=1, PropertyValueRangeTo=4, BusinesssValueRangeFrom=0, BusinesssValueRangeTo=3, PropertyType=PropertyType.Furniture, Quote=996200 },
new QuoteMaster { Id=133,PropertyValueRangeFrom=7, PropertyValueRangeTo=7, BusinesssValueRangeFrom=0, BusinesssValueRangeTo=8, PropertyType=PropertyType.Building, Quote=369200 },
new QuoteMaster { Id=134,PropertyValueRangeFrom=6, PropertyValueRangeTo=6, BusinesssValueRangeFrom=2, BusinesssValueRangeTo=7, PropertyType=PropertyType.Singage, Quote=959200 },
new QuoteMaster { Id=135,PropertyValueRangeFrom=8, PropertyValueRangeTo=8, BusinesssValueRangeFrom=3, BusinesssValueRangeTo=8, PropertyType=PropertyType.Furniture, Quote=911200 },
new QuoteMaster { Id=136,PropertyValueRangeFrom=5, PropertyValueRangeTo=7, BusinesssValueRangeFrom=1, BusinesssValueRangeTo=8, PropertyType=PropertyType.Furniture, Quote=682100 },
new QuoteMaster { Id=137,PropertyValueRangeFrom=1, PropertyValueRangeTo=1, BusinesssValueRangeFrom=7, BusinesssValueRangeTo=8, PropertyType=PropertyType.Equipment, Quote=720700 },
new QuoteMaster { Id=138,PropertyValueRangeFrom=8, PropertyValueRangeTo=8, BusinesssValueRangeFrom=8, BusinesssValueRangeTo=8, PropertyType=PropertyType.Furniture, Quote=458600 },
new QuoteMaster { Id=139,PropertyValueRangeFrom=8, PropertyValueRangeTo=8, BusinesssValueRangeFrom=4, BusinesssValueRangeTo=8, PropertyType=PropertyType.Inventory, Quote=67700 },
new QuoteMaster { Id=140,PropertyValueRangeFrom=8, PropertyValueRangeTo=8, BusinesssValueRangeFrom=0, BusinesssValueRangeTo=8, PropertyType=PropertyType.Building, Quote=365800 },
new QuoteMaster { Id=141,PropertyValueRangeFrom=8, PropertyValueRangeTo=8, BusinesssValueRangeFrom=2, BusinesssValueRangeTo=8, PropertyType=PropertyType.Equipment, Quote=314200 },
new QuoteMaster { Id=142,PropertyValueRangeFrom=4, PropertyValueRangeTo=5, BusinesssValueRangeFrom=8, BusinesssValueRangeTo=7, PropertyType=PropertyType.Building, Quote=353200 },
new QuoteMaster { Id=143,PropertyValueRangeFrom=4, PropertyValueRangeTo=6, BusinesssValueRangeFrom=6, BusinesssValueRangeTo=5, PropertyType=PropertyType.Inventory, Quote=417900 },
new QuoteMaster { Id=144,PropertyValueRangeFrom=6, PropertyValueRangeTo=7, BusinesssValueRangeFrom=7, BusinesssValueRangeTo=7, PropertyType=PropertyType.Furniture, Quote=460600 },
new QuoteMaster { Id=145,PropertyValueRangeFrom=5, PropertyValueRangeTo=7, BusinesssValueRangeFrom=7, BusinesssValueRangeTo=7, PropertyType=PropertyType.Singage, Quote=98200 },
new QuoteMaster { Id=146,PropertyValueRangeFrom=5, PropertyValueRangeTo=5, BusinesssValueRangeFrom=6, BusinesssValueRangeTo=5, PropertyType=PropertyType.Equipment, Quote=461900 },
new QuoteMaster { Id=147,PropertyValueRangeFrom=3, PropertyValueRangeTo=4, BusinesssValueRangeFrom=1, BusinesssValueRangeTo=7, PropertyType=PropertyType.Furniture, Quote=809500 },
new QuoteMaster { Id=148,PropertyValueRangeFrom=5, PropertyValueRangeTo=6, BusinesssValueRangeFrom=6, BusinesssValueRangeTo=7, PropertyType=PropertyType.Equipment, Quote=986100 },
new QuoteMaster { Id=149,PropertyValueRangeFrom=0, PropertyValueRangeTo=6, BusinesssValueRangeFrom=2, BusinesssValueRangeTo=7, PropertyType=PropertyType.Singage, Quote=85700 },
new QuoteMaster { Id=150,PropertyValueRangeFrom=8, PropertyValueRangeTo=8, BusinesssValueRangeFrom=7, BusinesssValueRangeTo=8, PropertyType=PropertyType.Equipment, Quote=565700 },
new QuoteMaster { Id=151,PropertyValueRangeFrom=5, PropertyValueRangeTo=6, BusinesssValueRangeFrom=3, BusinesssValueRangeTo=6, PropertyType=PropertyType.Furniture, Quote=23000 },
new QuoteMaster { Id=152,PropertyValueRangeFrom=8, PropertyValueRangeTo=8, BusinesssValueRangeFrom=7, BusinesssValueRangeTo=8, PropertyType=PropertyType.Inventory, Quote=95500 },
new QuoteMaster { Id=153,PropertyValueRangeFrom=7, PropertyValueRangeTo=8, BusinesssValueRangeFrom=2, BusinesssValueRangeTo=8, PropertyType=PropertyType.Singage, Quote=709400 },
new QuoteMaster { Id=154,PropertyValueRangeFrom=5, PropertyValueRangeTo=5, BusinesssValueRangeFrom=2, BusinesssValueRangeTo=6, PropertyType=PropertyType.Singage, Quote=188800 },
new QuoteMaster { Id=155,PropertyValueRangeFrom=2, PropertyValueRangeTo=2, BusinesssValueRangeFrom=8, BusinesssValueRangeTo=8, PropertyType=PropertyType.Singage, Quote=656500 },
new QuoteMaster { Id=156,PropertyValueRangeFrom=0, PropertyValueRangeTo=1, BusinesssValueRangeFrom=7, BusinesssValueRangeTo=6, PropertyType=PropertyType.Equipment, Quote=44500 },
new QuoteMaster { Id=157,PropertyValueRangeFrom=1, PropertyValueRangeTo=7, BusinesssValueRangeFrom=6, BusinesssValueRangeTo=3, PropertyType=PropertyType.Furniture, Quote=782400 },
new QuoteMaster { Id=158,PropertyValueRangeFrom=1, PropertyValueRangeTo=6, BusinesssValueRangeFrom=6, BusinesssValueRangeTo=8, PropertyType=PropertyType.Equipment, Quote=848800 },
new QuoteMaster { Id=159,PropertyValueRangeFrom=0, PropertyValueRangeTo=2, BusinesssValueRangeFrom=1, BusinesssValueRangeTo=4, PropertyType=PropertyType.Building, Quote=225600 },
new QuoteMaster { Id=160,PropertyValueRangeFrom=2, PropertyValueRangeTo=4, BusinesssValueRangeFrom=1, BusinesssValueRangeTo=4, PropertyType=PropertyType.Inventory, Quote=463000 },
new QuoteMaster { Id=161,PropertyValueRangeFrom=6, PropertyValueRangeTo=6, BusinesssValueRangeFrom=7, BusinesssValueRangeTo=8, PropertyType=PropertyType.Equipment, Quote=337400 },
new QuoteMaster { Id=162,PropertyValueRangeFrom=3, PropertyValueRangeTo=8, BusinesssValueRangeFrom=2, BusinesssValueRangeTo=5, PropertyType=PropertyType.Singage, Quote=628600 },
new QuoteMaster { Id=163,PropertyValueRangeFrom=7, PropertyValueRangeTo=8, BusinesssValueRangeFrom=0, BusinesssValueRangeTo=7, PropertyType=PropertyType.Singage, Quote=127300 },
new QuoteMaster { Id=164,PropertyValueRangeFrom=0, PropertyValueRangeTo=0, BusinesssValueRangeFrom=6, BusinesssValueRangeTo=5, PropertyType=PropertyType.Furniture, Quote=722600 },
new QuoteMaster { Id=165,PropertyValueRangeFrom=3, PropertyValueRangeTo=7, BusinesssValueRangeFrom=8, BusinesssValueRangeTo=8, PropertyType=PropertyType.Building, Quote=996100 },
new QuoteMaster { Id=166,PropertyValueRangeFrom=4, PropertyValueRangeTo=7, BusinesssValueRangeFrom=8, BusinesssValueRangeTo=4, PropertyType=PropertyType.Singage, Quote=694300 },
new QuoteMaster { Id=167,PropertyValueRangeFrom=8, PropertyValueRangeTo=8, BusinesssValueRangeFrom=0, BusinesssValueRangeTo=8, PropertyType=PropertyType.Furniture, Quote=103200 },
new QuoteMaster { Id=168,PropertyValueRangeFrom=8, PropertyValueRangeTo=8, BusinesssValueRangeFrom=8, BusinesssValueRangeTo=8, PropertyType=PropertyType.Inventory, Quote=867900 },
new QuoteMaster { Id=169,PropertyValueRangeFrom=5, PropertyValueRangeTo=7, BusinesssValueRangeFrom=6, BusinesssValueRangeTo=6, PropertyType=PropertyType.Equipment, Quote=189100 },
new QuoteMaster { Id=170,PropertyValueRangeFrom=0, PropertyValueRangeTo=0, BusinesssValueRangeFrom=3, BusinesssValueRangeTo=7, PropertyType=PropertyType.Building, Quote=71200 },
new QuoteMaster { Id=171,PropertyValueRangeFrom=8, PropertyValueRangeTo=8, BusinesssValueRangeFrom=4, BusinesssValueRangeTo=8, PropertyType=PropertyType.Equipment, Quote=509800 },
new QuoteMaster { Id=172,PropertyValueRangeFrom=3, PropertyValueRangeTo=5, BusinesssValueRangeFrom=2, BusinesssValueRangeTo=3, PropertyType=PropertyType.Equipment, Quote=799100 },
new QuoteMaster { Id=173,PropertyValueRangeFrom=4, PropertyValueRangeTo=7, BusinesssValueRangeFrom=7, BusinesssValueRangeTo=4, PropertyType=PropertyType.Inventory, Quote=122400 },
new QuoteMaster { Id=174,PropertyValueRangeFrom=5, PropertyValueRangeTo=8, BusinesssValueRangeFrom=3, BusinesssValueRangeTo=8, PropertyType=PropertyType.Equipment, Quote=365400 },
new QuoteMaster { Id=175,PropertyValueRangeFrom=8, PropertyValueRangeTo=8, BusinesssValueRangeFrom=3, BusinesssValueRangeTo=8, PropertyType=PropertyType.Building, Quote=466800 },
new QuoteMaster { Id=176,PropertyValueRangeFrom=0, PropertyValueRangeTo=5, BusinesssValueRangeFrom=7, BusinesssValueRangeTo=2, PropertyType=PropertyType.Inventory, Quote=308500 },
new QuoteMaster { Id=177,PropertyValueRangeFrom=6, PropertyValueRangeTo=8, BusinesssValueRangeFrom=6, BusinesssValueRangeTo=6, PropertyType=PropertyType.Building, Quote=301000 },
new QuoteMaster { Id=178,PropertyValueRangeFrom=6, PropertyValueRangeTo=6, BusinesssValueRangeFrom=6, BusinesssValueRangeTo=7, PropertyType=PropertyType.Inventory, Quote=704600 },
new QuoteMaster { Id=179,PropertyValueRangeFrom=0, PropertyValueRangeTo=6, BusinesssValueRangeFrom=3, BusinesssValueRangeTo=0, PropertyType=PropertyType.Furniture, Quote=79700 },
new QuoteMaster { Id=180,PropertyValueRangeFrom=3, PropertyValueRangeTo=3, BusinesssValueRangeFrom=0, BusinesssValueRangeTo=7, PropertyType=PropertyType.Furniture, Quote=474800 },
new QuoteMaster { Id=181,PropertyValueRangeFrom=3, PropertyValueRangeTo=8, BusinesssValueRangeFrom=2, BusinesssValueRangeTo=5, PropertyType=PropertyType.Singage, Quote=280800 },
new QuoteMaster { Id=182,PropertyValueRangeFrom=6, PropertyValueRangeTo=8, BusinesssValueRangeFrom=4, BusinesssValueRangeTo=8, PropertyType=PropertyType.Furniture, Quote=934700 },
new QuoteMaster { Id=183,PropertyValueRangeFrom=2, PropertyValueRangeTo=2, BusinesssValueRangeFrom=4, BusinesssValueRangeTo=3, PropertyType=PropertyType.Building, Quote=343500 },
new QuoteMaster { Id=184,PropertyValueRangeFrom=6, PropertyValueRangeTo=8, BusinesssValueRangeFrom=4, BusinesssValueRangeTo=7, PropertyType=PropertyType.Inventory, Quote=829200 },
new QuoteMaster { Id=185,PropertyValueRangeFrom=5, PropertyValueRangeTo=7, BusinesssValueRangeFrom=5, BusinesssValueRangeTo=5, PropertyType=PropertyType.Singage, Quote=71900 },
new QuoteMaster { Id=186,PropertyValueRangeFrom=6, PropertyValueRangeTo=8, BusinesssValueRangeFrom=7, BusinesssValueRangeTo=6, PropertyType=PropertyType.Singage, Quote=220200 },
new QuoteMaster { Id=187,PropertyValueRangeFrom=4, PropertyValueRangeTo=7, BusinesssValueRangeFrom=1, BusinesssValueRangeTo=8, PropertyType=PropertyType.Equipment, Quote=636400 },
new QuoteMaster { Id=188,PropertyValueRangeFrom=3, PropertyValueRangeTo=3, BusinesssValueRangeFrom=7, BusinesssValueRangeTo=7, PropertyType=PropertyType.Equipment, Quote=414700 },
new QuoteMaster { Id=189,PropertyValueRangeFrom=6, PropertyValueRangeTo=7, BusinesssValueRangeFrom=0, BusinesssValueRangeTo=8, PropertyType=PropertyType.Building, Quote=499800 },
new QuoteMaster { Id=190,PropertyValueRangeFrom=6, PropertyValueRangeTo=8, BusinesssValueRangeFrom=7, BusinesssValueRangeTo=6, PropertyType=PropertyType.Inventory, Quote=131900 },
new QuoteMaster { Id=191,PropertyValueRangeFrom=1, PropertyValueRangeTo=4, BusinesssValueRangeFrom=6, BusinesssValueRangeTo=8, PropertyType=PropertyType.Equipment, Quote=314400 },
new QuoteMaster { Id=192,PropertyValueRangeFrom=5, PropertyValueRangeTo=6, BusinesssValueRangeFrom=8, BusinesssValueRangeTo=7, PropertyType=PropertyType.Furniture, Quote=315600 },
new QuoteMaster { Id=193,PropertyValueRangeFrom=6, PropertyValueRangeTo=6, BusinesssValueRangeFrom=5, BusinesssValueRangeTo=7, PropertyType=PropertyType.Building, Quote=475000 },
new QuoteMaster { Id=194,PropertyValueRangeFrom=6, PropertyValueRangeTo=7, BusinesssValueRangeFrom=3, BusinesssValueRangeTo=6, PropertyType=PropertyType.Building, Quote=90100 },
new QuoteMaster { Id=195,PropertyValueRangeFrom=5, PropertyValueRangeTo=6, BusinesssValueRangeFrom=1, BusinesssValueRangeTo=5, PropertyType=PropertyType.Singage, Quote=843100 },
new QuoteMaster { Id=196,PropertyValueRangeFrom=6, PropertyValueRangeTo=6, BusinesssValueRangeFrom=5, BusinesssValueRangeTo=7, PropertyType=PropertyType.Furniture, Quote=728200 },
new QuoteMaster { Id=197,PropertyValueRangeFrom=3, PropertyValueRangeTo=8, BusinesssValueRangeFrom=4, BusinesssValueRangeTo=3, PropertyType=PropertyType.Singage, Quote=827200 },
new QuoteMaster { Id=198,PropertyValueRangeFrom=2, PropertyValueRangeTo=5, BusinesssValueRangeFrom=6, BusinesssValueRangeTo=8, PropertyType=PropertyType.Inventory, Quote=740000 },
new QuoteMaster { Id=199,PropertyValueRangeFrom=3, PropertyValueRangeTo=5, BusinesssValueRangeFrom=6, BusinesssValueRangeTo=6, PropertyType=PropertyType.Building, Quote=267000 },
new QuoteMaster { Id=200,PropertyValueRangeFrom=1, PropertyValueRangeTo=8, BusinesssValueRangeFrom=8, BusinesssValueRangeTo=3, PropertyType=PropertyType.Furniture, Quote=775000 }
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