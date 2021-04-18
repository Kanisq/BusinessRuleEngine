using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessRuleEngine
{
    public class Payment : IPayment
    {
        public string GetMessage()
        {
            return "Test Successful";
        }

        public void MakePayment()
        {
            throw new NotImplementedException();
        }
    }
}
