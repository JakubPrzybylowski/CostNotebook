using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace costnotebook_backend.Models
{
    public class Transaction
    {
        public int TransactionId { get; set; }
        public DateTime Data { get; set; }
        public string Description { get; set; }
        public CategoryTransaction Category { get; set; }
        public double Amount { get; set; }
        public int UserId { get; set; }
        public User User { get; set; }
    }
}
