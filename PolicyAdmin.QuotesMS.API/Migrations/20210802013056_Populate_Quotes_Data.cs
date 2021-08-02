﻿using Microsoft.EntityFrameworkCore.Migrations;

namespace PolicyAdmin.QuotesMS.API.Migrations
{
    public partial class Populate_Quotes_Data : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
               table: "QuotesMaster",
               columns: new[] { "PropertyValueRangeFrom", "PropertyValueRangeTo", "BusinesssValueRangeFrom","BusinesssValueRangeTo", "PropertyType","Quote"},
               values: new object[,]
               {
                {5,5,7,8,1,687400},
{6,6,0,8,4,58000},
{0,5,0,1,0,61300},
{6,6,2,7,4,539100},
{0,0,4,0,4,468000},
{3,6,0,5,0,970500},
{4,8,0,6,2,828700},
{3,8,5,5,0,420700},
{0,5,0,5,1,654200},
{4,4,6,5,2,870400},
{0,5,5,4,1,711400},
{6,7,7,7,0,91300},
{4,4,7,6,3,247700},
{6,6,4,7,2,139500},
{0,1,5,5,1,855500},
{2,8,7,6,4,837600},
{3,6,5,7,4,725100},
{7,7,0,7,1,955000},
{0,4,0,7,0,363800},
{2,2,6,5,2,209300},
{7,8,2,8,4,177300},
{2,7,1,5,2,944200},
{5,8,0,8,3,331900},
{5,8,1,5,0,888800},
{4,6,4,8,3,873100},
{8,8,0,8,2,282400},
{7,8,6,8,0,341600},
{2,2,1,5,1,444900},
{6,8,7,8,0,39600},
{1,6,2,5,1,700500},
{3,4,6,3,0,26800},
{2,3,6,4,2,938500},
{4,6,5,8,0,439400},
{2,3,8,3,0,843500},
{1,7,8,7,2,857100},
{6,6,0,8,4,359400},
{2,8,4,2,2,651700},
{2,4,8,2,4,739600},
{2,7,7,8,0,761600},
{1,4,6,2,1,950800},
{5,7,0,7,4,83400},
{0,6,1,8,2,154600},
{5,6,1,8,2,55000},
{6,7,1,8,3,885400},
{1,6,1,7,2,976700},
{4,5,1,7,1,655400},
{0,6,8,6,3,257600},
{8,8,4,8,3,273100},
{2,6,0,7,4,12400},
{7,8,4,8,1,432100},
{1,1,3,5,4,600900},
{5,7,0,6,0,188000},
{2,4,5,6,3,609200},
{1,8,0,2,0,327300},
{4,6,0,6,4,502800},
{2,5,4,7,3,289600},
{0,6,1,8,0,469800},
{7,8,2,7,3,339800},
{0,2,6,8,4,76500},
{2,6,4,7,3,233400},
{6,6,5,6,3,727500},
{3,4,2,3,0,854300},
{4,4,8,6,1,588700},
{6,8,7,7,2,973200},
{2,3,0,4,0,718800},
{0,6,2,0,1,368100},
{0,8,3,7,2,884900},
{2,6,8,4,0,757400},
{2,6,2,7,4,30100},
{6,8,7,8,1,931200},
{5,5,4,6,1,651600},
{3,5,6,7,4,844200},
{1,6,2,1,4,243100},
{6,6,5,6,4,43900},
{7,8,3,7,0,414900},
{5,5,8,7,0,364000},
{7,7,0,8,1,956000},
{3,3,0,5,0,501500},
{0,6,4,5,0,331800},
{3,3,6,4,4,138100},
{5,6,0,6,0,93500},
{6,6,3,7,3,101400},
{3,8,5,7,0,312800},
{6,8,7,7,3,381400},
{1,5,5,1,3,583100},
{5,5,6,6,2,727300},
{1,3,0,6,2,892800},
{3,5,1,6,0,683800},
{4,7,8,7,0,76000},
{0,4,3,6,1,99100},
{1,2,2,3,4,838900},
{4,4,1,8,0,270800},
{7,8,3,7,3,114200},
{1,7,4,6,0,273700},
{3,3,6,6,3,656100},
{3,4,7,8,1,487100},
{2,4,5,5,0,453100},
{2,3,0,2,4,758600},
{4,5,8,4,3,21400},
{1,4,2,5,2,589300},
{3,8,5,5,2,232500},
{5,7,4,6,2,25200},
{0,2,5,6,4,687100},
{0,0,5,4,2,722400},
{8,8,5,8,2,911600},
{8,8,8,8,0,116100},
{8,8,3,8,3,522800},
{3,7,8,8,1,312100},
{2,8,2,3,2,481900},
{5,7,4,5,0,392000},
{8,8,4,8,1,218300},
{8,8,0,8,1,95400},
{6,7,1,7,2,869500},
{1,5,1,4,1,413600},
{8,8,0,8,0,131900},
{4,6,7,8,0,359500},
{3,3,5,4,2,967800},
{8,8,5,8,0,707300},
{5,7,1,6,3,75000},
{0,2,3,5,0,105300},
{5,5,4,5,3,607500},
{2,4,2,7,0,72900},
{4,8,3,4,3,166000},
{2,8,5,5,2,609000},
{3,4,7,4,0,19900},
{4,7,4,8,0,244700},
{2,4,7,5,4,785900},
{4,8,2,4,0,525700},
{0,1,7,7,0,480700},
{4,6,5,8,1,106300},
{1,4,0,3,4,996200},
{7,7,0,8,0,369200},
{6,6,2,7,2,959200},
{8,8,3,8,4,911200},
{5,7,1,8,4,682100},
{1,1,7,8,1,720700},
{8,8,8,8,4,458600},
{8,8,4,8,3,67700},
{8,8,0,8,0,365800},
{8,8,2,8,1,314200},
{4,5,8,7,0,353200},
{4,6,6,5,3,417900},
{6,7,7,7,4,460600},
{5,7,7,7,2,98200},
{5,5,6,5,1,461900},
{3,4,1,7,4,809500},
{5,6,6,7,1,986100},
{0,6,2,7,2,85700},
{8,8,7,8,1,565700},
{5,6,3,6,4,23000},
{8,8,7,8,3,95500},
{7,8,2,8,2,709400},
{5,5,2,6,2,188800},
{2,2,8,8,2,656500},
{0,1,7,6,1,44500},
{1,7,6,3,4,782400},
{1,6,6,8,1,848800},
{0,2,1,4,0,225600},
{2,4,1,4,3,463000},
{6,6,7,8,1,337400},
{3,8,2,5,2,628600},
{7,8,0,7,2,127300},
{0,0,6,5,4,722600},
{3,7,8,8,0,996100},
{4,7,8,4,2,694300},
{8,8,0,8,4,103200},
{8,8,8,8,3,867900},
{5,7,6,6,1,189100},
{0,0,3,7,0,71200},
{8,8,4,8,1,509800},
{3,5,2,3,1,799100},
{4,7,7,4,3,122400},
{5,8,3,8,1,365400},
{8,8,3,8,0,466800},
{0,5,7,2,3,308500},
{6,8,6,6,0,301000},
{6,6,6,7,3,704600},
{0,6,3,0,4,79700},
{3,3,0,7,4,474800},
{3,8,2,5,2,280800},
{6,8,4,8,4,934700},
{2,2,4,3,0,343500},
{6,8,4,7,3,829200},
{5,7,5,5,2,71900},
{6,8,7,6,2,220200},
{4,7,1,8,1,636400},
{3,3,7,7,1,414700},
{6,7,0,8,0,499800},
{6,8,7,6,3,131900},
{1,4,6,8,1,314400},
{5,6,8,7,4,315600},
{6,6,5,7,0,475000},
{6,7,3,6,0,90100},
{5,6,1,5,2,843100},
{6,6,5,7,4,728200},
{3,8,4,3,2,827200},
{2,5,6,8,3,740000},
{3,5,6,6,0,267000},
{1,8,8,3,4,775000},
           });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {

        }
    }
}
