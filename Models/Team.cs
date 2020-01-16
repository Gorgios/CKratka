using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SkijumpingTeams.Models
{
    public class Team
    {
        public int ID { get; set; }
        [Required]
        [StringLength(50, ErrorMessage = "Max lenght of Nation is 50")]
        public string Nation { get; set; }
        [Url]
        [Display(Name = "Image link")]
        public string PhotoLink { get; set; }
        public IEnumerable<Jumper> Jumpers { get; set; }
        public IEnumerable<Coach> Coaches { get; set; }
    }
}
