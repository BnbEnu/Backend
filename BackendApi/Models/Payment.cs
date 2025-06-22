using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BackendApi.Models
{
    public enum PaymentStatus
    {
        Pending,
        Successful,
        Failed
    }

    public enum PaymentMethod
    {
        Card,
        Transfer,
    Wallet
}
    public class Payment
    {
        public Guid PaymentId { get; set; }

        [Required]
        public Guid BookingId { get; set; }

        [ForeignKey("BookingId")]
        public Booking Booking { get; set; }

        public decimal Amount { get; set; }

        public PaymentMethod Method { get; set; }

        public PaymentStatus Status { get; set; }

        public DateTime PaidAt { get; set; }
    }
}