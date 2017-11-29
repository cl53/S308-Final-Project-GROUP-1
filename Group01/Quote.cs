using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Group01
{
    public class Quote
    {
        public string RoomType { get; set; }
        public int NumberOfNights { get; set; }
        public DateTime CheckIn { get; set; }
        public DateTime CheckOut { get; set; }
        public double RatePerNight { get; set; }
        public double SubTotal { get; set; }
        public double Tax { get; set; }
        public double ConvenienceFee { get; set; }
        public double Total { get; set; }

        public Quote()
        {
            RoomType = "One King";
            SubTotal = 0;
            Total = 0;
            Tax = 0;
            ConvenienceFee = 0;
            RatePerNight = 0;
            NumberOfNights = 0;
            CheckIn = DateTime.MinValue;
            CheckOut = DateTime.MinValue;

        }

        public Quote(string roomtype, int numberofnights, DateTime checkin, DateTime checkout, double ratepernight, double subtotal, double tax, double conveniencefee, double total)
        {
            RoomType = roomtype;
            NumberOfNights = numberofnights;
            CheckIn = checkin;
            CheckOut = checkout;
            RatePerNight = ratepernight;
            SubTotal = subtotal;
            Tax = tax;
            ConvenienceFee = conveniencefee;
            Total = total;
        }
    }
}
