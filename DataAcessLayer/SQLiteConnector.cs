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

        public void RemovePass(PassAccModel passAcc)
        {
            using (IDbConnection conn = new SQLiteConnection(GlobalConfig.CnnString()))
            {
                conn.Execute("delete from PassAccTBL where id = @id", passAcc);
            }

        }
        public MasterAccModel SignIn(string mail,string password)
        { 
            var parameters = new Dictionary<string, object>
            {
                {"@email",mail },
                {"@master_password",HashPasswordLogic.HashPass(password) }
            };
            using (IDbConnection conn = new SQLiteConnection(GlobalConfig.CnnString()))
            {
                try
                {
                    var output = conn.QuerySingle<MasterAccModel>("select * from MasterAccTBL where email = @email and master_password = @master_password", new DynamicParameters(parameters));
                    return output as MasterAccModel;
                }
                catch
                {
                    return null;
                }
        
            }
        }
        public void SignUp(MasterAccModel masterAcc)
        {
            using (IDbConnection conn = new SQLiteConnection(GlobalConfig.CnnString()))
            {
                conn.Execute("insert into MasterAccTBL (firstname,lastname,email,master_password) values (@firstname,@lastname,@email,@master_password)",masterAcc);
            }
        }

        public PassAccModel GetAccInfo(PassAccModel passAcc)
        {
            var parameters = new Dictionary<string, object>
            {
                {"@id",passAcc.id }
            };

            using (IDbConnection conn = new SQLiteConnection(GlobalConfig.CnnString()))
            {
                var output = conn.QuerySingle<PassAccModel>("select * from passacctbl where id = @id", new DynamicParameters(parameters));
                return output as PassAccModel;
            }
        }
    }
}
