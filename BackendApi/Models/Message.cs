using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BackendApi.Models
{
    public class Message
    {
        public Guid MessageId { get; set; }
        public Guid SenderId { get; set; }
        public User? Sender { get; set; }
        public Guid ReceiverId { get; set; }
        public User? Receiver { get; set; }
        public string Content { get; set; } = string.Empty;
        public DateTime SentAt { get; set; } = DateTime.UtcNow;
    }
}