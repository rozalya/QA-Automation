using Dapper;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BartlettAreTheQAs.Models
{
  public class AccessExcelData
    {
        public static string TestDataFileConnection()
        {

            var path = ConfigurationManager.AppSettings["TestDataSheetPath"];
            var fileName = "UserData.xlsx";
            var con = string.Format(@"Provider=Microsoft.ACE.OLEDB.12.0;
		                               Data Source = {0}; 
		                               Extended Properties=Excel 12.0;", path + fileName);
            return con;
        }

        public static RegisterPageUserModel GetTestData(string keyName)
        {
            using (var connection = new
                          OleDbConnection(TestDataFileConnection()))
            {
                connection.Open();
                var query = string.Format("select * from [DataSet$]where key = '{0}'", keyName);
                var value = connection.Query<RegisterPageUserModel>(query).FirstOrDefault();
                connection.Close(); return value;
            }
        }

    }
}
