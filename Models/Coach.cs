using SkijumpingTeams.Validators;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SkijumpingTeams.Models
{
    public class Coach { 
    public int ID { get; set; }
    [Required]
    [StartWithBigLetter]
    [StringLength(20, ErrorMessage = "First Name is way too long.")]
    [Display(Name = "First Name")]
    public String FirstName { get; set; }
    [Required]
    [StartWithBigLetter]
    [StringLength(30, ErrorMessage = "Last Name is way too long.")]
    [Display(Name = "Last Name")]
    public String LastName { get; set; }
    [Required]
    [StringLength(30, ErrorMessage = "Postion is way too long.")]
    public String Postion { get; set; }
    [Required]
    [Display(Name = "Birth Date")]
    [DataType(DataType.Date)]
    public DateTime DateOfBirth { get; set; }
    [Url]
    [Display(Name = "Photo Link")]
    public String PhotoLink { get; set; }
    public int TeamID { get; set; }
    public Team Team { get; set; }
    }
}
