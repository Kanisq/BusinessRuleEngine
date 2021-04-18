using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessRuleEngine.Rules
{
    public interface IPaymentRule
    {
        PaymentDetail MakePayment();
        bool IsRuleMatch(string paymentType);
    }
}
