﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessRuleEngine
{
    public class PaymentDetail
    {
        public string PackingSlip { get; set; }
        public string DuplicatePackingSlip { get; set; }
        public int CommisionToAgent { get; set; }
        public bool IsMemberNotified { get; set; }
        public bool IsVideoAdded { get; set; }
        public string MembershipStatus { get; set; }
        

    }
}
