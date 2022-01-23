using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Aplikacja_GOT_PTTK.Models
{
    public class GeoPointModel
    {
        [Key]
        public int GeoPointId { get; set; }
        [Required]
        public string Latitude { get; set; }
        [Required]
        public string Longitude { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public string Height { get; set; }

        public override string ToString()
        {
            return "Point: " + Name + " lat: " + Latitude + " long: " + Longitude + " height: " + Height;
        }
        //public GeoPointModel(double lat, double longi, string name)
        //{
        //    Latitude = lat;
        //    Longitude = longi;
        //    Name = name;
        //}
    }
}
