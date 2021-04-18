using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessRuleEngine
{
    public class Payment 
    {
        public string GetMessage()
        {
            return "Test Successful";
        }

        public void MakePayment(string paymentType)
        {
            string message;
            
            string duplicateslip;
            if (paymentType == "Physical Product")
            {
                message = GenerateSlip();
                int commision = CommisionToAgent();
            }
            if (paymentType == "Physical Product" && paymentType=="Book")
            {
                message = GenerateSlip();
                duplicateslip = message;
            }
            if (paymentType == "Membership")
            {
                message = ActivateMembership();

                NotifyMember(message);
            }
            if (paymentType == "Upgrade")
            {
                message = UpgradeMembership();
                NotifyMember(message);
            }
            if (paymentType == "video" && paymentType == "Learning to Ski,")
            {
                message = GenerateSlip();
                message = "First Aid" + message;
            }

        }

        public string GenerateSlip()
        {
            Random r = new Random(10);
            return "SlipNumber_" + r.ToString();
        }

        public string ActivateMembership()
        {
            return "Membership Activated";
        }

        public string UpgradeMembership()
        {
            return "Membership Upgraded";
        }

        public void NotifyMember(string message)
        {
           // Member Notified;
        }

        public int CommisionToAgent()
        {
            return 100;
        }
        
    }
}
