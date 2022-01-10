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
    }
}
