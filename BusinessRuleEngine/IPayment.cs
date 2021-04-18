using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessRuleEngine
{
    public interface IPayment
    {
        PaymentDetail MakePayment();
        bool IsRuleMatch(string paymentType);
    }
}
