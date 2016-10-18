using System.Data;
using node2_1;
using NUnit.Framework;

namespace Tests.node2_1
{
   [TestFixture]
   public class ReportingServicesSpecs
   {
      [Test]
      public void TestOne()
      {
         var reportService = new ReportingServices();
         reportService.Report(new DataTable(), "A path");
      }
   }
}