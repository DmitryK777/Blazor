using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace Academy.Models
{
    public class Directions
    {
        [Key]
        public byte direction_id {  get; set; }

        [Required]
        [StringLength(50, MinimumLength = 5)]
    }
}
