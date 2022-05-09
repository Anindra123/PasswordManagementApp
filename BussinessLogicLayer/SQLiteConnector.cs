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

        public List<PassAccModel> GetPassAcc(int m_id)
        {
            var parameters = new Dictionary<string, object>
            {
                {"@m_id",m_id}
            };

            using (IDbConnection conn = new SQLiteConnection(GlobalConfig.CnnString()))
            {
                var output = conn.Query<PassAccModel>("select * from passacctbl where m_id = @m_id", new DynamicParameters(parameters));
                return output.ToList();
            }
        }

        public void StorePass(PassAccModel passAcc)
        {
            using (IDbConnection conn = new SQLiteConnection(GlobalConfig.CnnString()))
            {
                conn.Execute("insert into PassAccTBL (title,link,password,m_id) values(@title,@link,@password,@m_id)", passAcc);
            }
        }

        public void RemovePass(PassAccModel passAcc)
        {
            using (IDbConnection conn = new SQLiteConnection(GlobalConfig.CnnString()))
            {
                conn.Execute("delete from PassAccTBL where id = @id and m_id = @m_id", passAcc);
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

        public PassAccModel GetAccInfo(PassAccModel passAcc,int m_id)
        {
            var parameters = new Dictionary<string, object>
            {
                {"@id",passAcc.id },
                {"@m_id",m_id }
            };

            using (IDbConnection conn = new SQLiteConnection(GlobalConfig.CnnString()))
            {
                var output = conn.QuerySingle<PassAccModel>("select * from passacctbl where id = @id and m_id = @m_id", new DynamicParameters(parameters));
                return output as PassAccModel;
            }
        }

        public PassAccModel GetAccInfo(int pass_id,int m_id)
        {
            var parameters = new Dictionary<string, object>
            {
                {"@id",pass_id},
                {"@m_id",m_id }
            };

            using (IDbConnection conn = new SQLiteConnection(GlobalConfig.CnnString()))
            {
                var output = conn.QuerySingle<PassAccModel>("select * from passacctbl where id = @id and m_id = @m_id", new DynamicParameters(parameters));
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
                {"@m_id",passAcc.m_id }
            };
            using (IDbConnection conn = new SQLiteConnection(GlobalConfig.CnnString()))
            {
                var acclist = conn.Query<MasterAccModel>("select * from passacctbl where m_id=@m_id and lower(title) = @title", parameters).ToList();

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
                {"@email",mail }
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

        public void ResetMasterPass(int u_id,string mpass)
        {
            var parameters = new DynamicParameters();
            parameters.Add("u_id", u_id);
            parameters.Add("mpass", mpass);
            using (IDbConnection conn = new SQLiteConnection(GlobalConfig.CnnString()))
            {
                conn.Execute("update MasterAccTBL set master_password = @mpass where id = @u_id",parameters);
            }

        }
    }
}
