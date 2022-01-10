using BussinessLogicLayer;
using Dapper;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAcessLayer
{
    public class SQLiteConnector : IDataConnection
    {
        public List<PassAccModel> GetPassAcc()
        {
            using (IDbConnection conn = new SQLiteConnection(GlobalConfig.CnnString()))
            {
                var output = conn.Query<PassAccModel>("select * from passacctbl", new DynamicParameters());
                return output.ToList();
            }
        }

        public void StorePass(PassAccModel passAcc)
        {
            using (IDbConnection conn = new SQLiteConnection(GlobalConfig.CnnString()))
            {
                conn.Execute("insert into PassAccTBL (title,link,password) values(@title,@link,@password)", passAcc);
            }
        }


    }
}
