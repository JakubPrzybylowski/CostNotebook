using Microsoft.AspNetCore.Identity;
using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;

namespace costnotebook_backend.Models
{
    public class User
    {
        public int UserID { get; set; }
        public string? FirstName { get; set; }
        public string? Password { get; set; }
        public string? LastName { get; set; }

        public string? UserEmail { get; set; }
        [JsonIgnore]
        public List<Transaction> Transactions { get; set; }
    }
}
