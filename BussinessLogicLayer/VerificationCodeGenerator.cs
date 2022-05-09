using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BussinessLogicLayer
{
    public static class VerificationCodeGenerator
    {
        public static int GenerateCode()
        {
            Random random = new Random();
            int randNum = random.Next(1000, 9999);
            return randNum;
        }
    }
}
