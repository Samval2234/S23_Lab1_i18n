using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;

namespace ZombieParty.Models
{
    public class Zombie
    {
        public int Id { get; set; }

        [StringLength(20, MinimumLength = 5)]
        [Display(Name = "Name")]
        public string Name { get; set; }

        [StringLength(255)]
        [Display(Name = "ShortDesc")]
        [Required(AllowEmptyStrings = false, ErrorMessage ="ValidationRequired")]
        public string ShortDesc { get; set; }

        [Range(1, 20, ErrorMessage = "RangeValidation")]

        [Display(Name = "Point")]
        public int Point { get; set; }
        [Display(Name ="Force")]        
        public int Force { get; set; }

        [ValidateNever]
        [Display(Name="Image")]
        public string Image { get; set; }

        // FACULTATIF on peut formellement identifier le champ lien
        // sinon le champ de foreignKey sera auto généré dans la BD
        [Display(Name = "ZombieType")]
        [ForeignKey("ZombieType")]
        public int ZombieTypeId { get; set; }
        [ValidateNever]
        public virtual ZombieType? ZombieType { get; set; }

        [Display(Name="Journaux de chasse")]
        [ValidateNever] 
        public virtual List<HuntingLog> HuntingLogs { get; set; }
    }
}
