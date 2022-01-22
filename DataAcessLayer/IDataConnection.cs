using BussinessLogicLayer;
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
        List<PassAccModel> GetPassAcc();
        void RemovePass(PassAccModel passAcc);
        void SignUp(MasterAccModel masterAcc);
        MasterAccModel SignIn(string mail, string password);
        PassAccModel GetAccInfo(PassAccModel passAcc);
        bool VerifySignUp(MasterAccModel masterAcc);
        bool VerifyStorePass(PassAccModel passAcc);
    }
}
