using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RFIDAttendanceSystem.DataBase
{
    public class DatabaseConnector
    {
        public string ConnectionString = ConfigurationManager.ConnectionStrings["DBConnection"].ConnectionString;
        public string GetConnection()
        {
            return ConnectionString ?? string.Empty;
        }
    }
}
