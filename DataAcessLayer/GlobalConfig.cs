using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAcessLayer
{
    public static class GlobalConfig
    {
        public static List<IDataConnection> dBConnections { get; private set; } = new List<IDataConnection>();

        public static void SetConnection(bool sqlight)
        {
            if (sqlight)
            {
                SQLiteConnector sql = new SQLiteConnector();
                dBConnections.Add(sql);
            }

        }
        public static string CnnString(string id = "Default")
        {
            return ConfigurationManager.ConnectionStrings[id].ConnectionString;
        }
    }
}
