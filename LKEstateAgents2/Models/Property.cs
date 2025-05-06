using System.ComponentModel.DataAnnotations;

namespace LKEstateAgents2.Models
{
    public class Property
    {

        public int Id { get; set; }
        
        [Required]
        [MaxLength(150)]
        [Display(Name = "Owner's Name")]
        [DataType(DataType.Text)]
        public string? OwnerName { get; set; }

        [Required]
        [MaxLength(150)]
        [Display(Name = "Location")]
        [DataType(DataType.Text)]

        public string? Location { get; set; }

        [Required]
        [Display(Name = "Price")]
        [DataType(DataType.Currency)]
        public int Price { get; set; }
    }
}
