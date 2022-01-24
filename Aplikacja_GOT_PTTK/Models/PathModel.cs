using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Aplikacja_GOT_PTTK.Models
{
    public class PathModel
    {
        [Key]
        public int PathId { get; set; }
        
        [Required]
        [ForeignKey("AccountId")]
        public AccountModel OwnerAccount { get; set; }
        [Required]
        public DateTime StartDate { get; set; }
        [Required]
        public int GOTPoints { get; set; }

        [Required]
        public string punktPocz { get; set; }
        public GeoPointModel punktPP { get; set; }

        [Required]
        public string punktKonc { get; set; }
        public GeoPointModel punktPK { get; set; }

        public override string ToString()
        {
            return "Trasa " + GOTPoints;
        }
    }
}
