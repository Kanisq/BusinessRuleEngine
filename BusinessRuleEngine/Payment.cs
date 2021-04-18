using BusinessRuleEngine.Rules;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessRuleEngine
{
    public class Payment 
    {
        private List<IPayment> lstPaymentRules;

        public Payment()
        {
            lstPaymentRules = new List<IPayment>();
            lstPaymentRules.Add(new PhysicalProduct());
            lstPaymentRules.Add(new Book());
            lstPaymentRules.Add(new Membership());
            lstPaymentRules.Add(new Upgrade());
            lstPaymentRules.Add(new Video("Learning to Ski,"));
        }
        
        public string GetMessage()
        {
            return "Test Successful";
        }

        public PaymentDetail MakePayment(string paymentType)
        {
         
            return lstPaymentRules.First(x => x.IsRuleMatch(paymentType)).MakePayment();
                        
        }

       
        
    }
}
