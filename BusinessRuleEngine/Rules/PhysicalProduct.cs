using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessRuleEngine
{
    public class PhysicalProduct : IPayment
    {
        public bool IsRuleMatch()
        {
            throw new NotImplementedException();
        }

        public void MakePayment()
        {
            throw new NotImplementedException();
        }
    }
}
