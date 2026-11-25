using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using System.ComponentModel.DataAnnotations;

namespace ZombieParty.Models
{
    public class HuntingLog
    {
          public int Id { get; set; }
        [StringLength(25, MinimumLength = 5)]
        [Required(AllowEmptyStrings =false, ErrorMessage ="ValidationRequired")]

        [Display(Name ="Title")]
        public string Title { get; set; }
        [Display (Name = "HuntingDescription")]
        [StringLength(255)]
        public string Description { get; set; }
        public DateTime AdventureDate { get; set; }

        [ValidateNever]
        [Display(Name ="Zombies")]
        public virtual List<Zombie> Zombies { get; set; }
    }
}
