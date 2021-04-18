using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessRuleEngine
{
    public static class Utility
    {
        public static string GenerateSlipNumber()
        {
            Random r = new Random(10);
            return "SlipNumber_" + r.ToString();
        }

        public static int CommisionToAgent()
        {
            return 100;
        }

        public static string ActivateMembership()
        {
            return "Membership Activated";
        }

        public static string UpgradeMembership()
        {
            return "Membership Upgraded";
        }

        public static bool NotifyMember(string message)
        {
            if (message.Equals("Membership Activated", StringComparison.InvariantCultureIgnoreCase) || message.Equals("Membership Upgraded", StringComparison.InvariantCultureIgnoreCase))
            {
                return true;
            }
            return false;
        }


        public static bool IsVideoAdded(string videoName)
        {
            if (videoName.Equals("Learning to Ski,", StringComparison.InvariantCultureIgnoreCase))
            {
                return true;
            }
            return false;
        }

    }
}
