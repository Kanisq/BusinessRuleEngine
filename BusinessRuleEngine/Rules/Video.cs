using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessRuleEngine.Rules
{
    public class Video : IPaymentRule
    {
       
        public string  VideoName { get; set; }

        public Video(string videoName)
        {
            VideoName = videoName;
        }


        public bool IsRuleMatch(string paymentType)
        {
            return paymentType.StartsWith("Video", StringComparison.InvariantCultureIgnoreCase);
        }

        public PaymentDetail MakePayment()
        {
            PaymentDetail paymentDetail = new PaymentDetail();
            paymentDetail.PackingSlip = Utility.GenerateSlipNumber();
            paymentDetail.IsVideoAdded = Utility.IsVideoAdded(VideoName);

            return paymentDetail;
        }
    }
}
