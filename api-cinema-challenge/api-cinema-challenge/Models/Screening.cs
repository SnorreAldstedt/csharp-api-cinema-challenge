using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace api_cinema_challenge.Models
{
    [Table("Screenings")]
    public class Screening
    {
        [Key]
        public int Id { get; set; }

        [Column("screenNumber")]
        public int ScreenNumber { get; set; }

        [Column("capacity")]
        public int Capacity {  get; set; }

        [Column("startsAt")]
        public DateTime StartsAt { get; set; }

        [Column("createdAt")]
        public DateTime CreatedAt { get; set; }

        [Column("updatedAt")]
        public DateTime UpdatedAt { get; set; }

    }
}
