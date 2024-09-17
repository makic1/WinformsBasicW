using System.ComponentModel.DataAnnotations;

namespace StageManagmentTwo.Entities
{
    public class Ticket
    {
        [Key]
        public int TicketId { get; set; }
        [Required]
        public SeatRow SeatRow { get; set; }
        [Required]
        public int SeatNumber { get; set; }

        [Required, MinLength(2), MaxLength(50)]
        public string CustomerFirstname { get; set; }

        [Required, MinLength(2), MaxLength(50)]
        public string CustomerLastname { get; set; }

        [Required]
        public CustomerCategorie CustomerCategorie { get; set; }

        [Required, MinLength(5), MaxLength(80)]
        public string CustomerAddress { get; set; }

        [Required, MinLength(1), MaxLength(30)]
        public string CustomerCountry { get; set; }

        [Required]
        public int CustomerPLZ { get; set; }

        [Required]
        public decimal PriceEuro { get; set; }

        public decimal? PayedPriceEuro { get; set; }

        public int PerformanceId { get; set; }
        public Performance Performance { get; set; }
    }

    /// <summary>
    /// Seats A - K
    /// </summary>
    public enum SeatRow
    {
        A, B, C, D, E, F, G, H, I, J, K
    }

    public enum CustomerCategorie
    {
        Normal,
        Schueler,
        Pensionist,
        Student
    }
}
