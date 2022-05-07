using Dapper;
using DataAcessLayer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BussinessLogicLayer
{
    public class SQLiteConnector : IDataConnection
    {
        public SQLiteConnector()
        {
            GlobalConfig.SetConnection(true, this);
        }    

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
        public MasterAccModel SignIn(string mail, string password)
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
                conn.Execute("insert into MasterAccTBL (firstname,lastname,email,master_password) values (@firstname,@lastname,@email,@master_password)", masterAcc);
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

        public bool VerifySignUp(MasterAccModel masterAcc)
        {
            bool output = false;
            using (IDbConnection conn = new SQLiteConnection(GlobalConfig.CnnString()))
            {
                var acclist = conn.Query<MasterAccModel>("select * from masteracctbl where firstname = @firstname or lastname = @lastname or email = @email or master_password = @master_password", masterAcc).ToList();

                if (acclist.Count > 0)
                {
                    output = true;
                }
            }
            return output;
        }

        public bool VerifyStorePass(PassAccModel passAcc)
        {
            bool output = false;
            var parameters = new Dictionary<string, object>
            {
                {"@title",passAcc.title.ToLower()},
            };
            using (IDbConnection conn = new SQLiteConnection(GlobalConfig.CnnString()))
            {
                var acclist = conn.Query<MasterAccModel>("select * from passacctbl where lower(title) = @title", parameters).ToList();

                if (acclist.Count > 0)
                {
                    output = true;
                }
            }
            return output;
        }

        public MasterAccModel ValidateMail(string mail)
        {
            var parameters = new Dictionary<string, object>
            {
                {"@email",mail },
            };
            using (IDbConnection conn = new SQLiteConnection(GlobalConfig.CnnString()))
            {
                try
                {
                    var output = conn.QuerySingle<MasterAccModel>("select * from MasterAccTBL where email = @email", new DynamicParameters(parameters));
                    return output as MasterAccModel;
                }
                catch
                {
                    return null;
                }

            }
        }

        
    }
}
