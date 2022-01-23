using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Aplikacja_GOT_PTTK.Models
{
    public class AccountModel
    {
        [Key]
        public int AccountId { get; set; }
        [ForeignKey("AccountId")]
        IdentityUser Owner { get; set; }
        [Required]
        [MaxLength(30)]
        [MinLength(2)]
        public string Name { get; set; }
        [Required]
        [MaxLength(30)]
        [MinLength(2)]
        public string LastName { get; set; }
        [Required]
        DateTime BirthDate { get; set; }
    }
}
