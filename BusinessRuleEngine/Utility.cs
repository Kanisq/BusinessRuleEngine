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
    }
}
