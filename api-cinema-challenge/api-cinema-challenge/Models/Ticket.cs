using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace api_cinema_challenge.Models
{
    [Table("Tickets")]
    public class Ticket
    {
        [Key]
        public int Id { get; set; }

        [Column("numSeats")]
        public int NumSeats {  get; set; }

        [ForeignKey("Customers")]
        public int CustomerId {  get; set; }

        public Customer Customer { get; set; }

        [ForeignKey("Screening")]
        public int ScreeningId { get; set; }

        public Screening Screening { get; set; }

    }
}
