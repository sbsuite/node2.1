using System.Data;
using node3_1;

namespace node2_1
{
   public interface IReportingServices
   {
      bool Report(DataTable dataTable, string fileWhereReportWillBeExported);
   }

   public class ReportingServices : IReportingServices
   {
      private readonly FileHelper _helper;

      public ReportingServices()
      {
         _helper = new node3_1.FileHelper();
      }

      public bool Report(DataTable dataTable, string fileWhereReportWillBeExported)
      {
         return _helper.SaveFile(fileWhereReportWillBeExported);
      }
   }
}
