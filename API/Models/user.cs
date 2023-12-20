using Microsoft.AspNetCore.Identity;
using System;
using System.ComponentModel.DataAnnotations;

namespace API.Models
{
    public class user : IdentityUser
    {
        [Required]
        public string FirstName {  get; set; }
        public string LastName { get; set; }
        public DateTime DateCreated { get; set; } = DateTime.UtcNow;

    }
}
