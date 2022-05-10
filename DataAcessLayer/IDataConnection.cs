using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAcessLayer
{
    public interface IDataConnection
    {
        void StorePass(PassAccModel passAcc);
        List<PassAccModel> GetPassAcc(int m_id);
        void RemovePass(PassAccModel passAcc);
        void SignUp(MasterAccModel masterAcc);
        MasterAccModel SignIn(string mail, string password);
        PassAccModel GetAccInfo(PassAccModel passAcc, int m_id);
        PassAccModel GetAccInfo(int pass_id, int m_id);
        bool VerifySignUp(MasterAccModel masterAcc);
        bool VerifyStorePass(PassAccModel passAcc);
        MasterAccModel ValidateMail(string mail);
        void ResetMasterPass(int u_id, string mpass);
        void UpdatePass(PassAccModel passAcc);
        void UpdateMasterAcc(MasterAccModel masterAcc);
    }
}
