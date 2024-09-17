using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StageManagmentTwo.Entities
{
    public class ProgramStage
    {
        [Key]
        public int ProgramStageId { get; set; }

        [Required, MinLength(2), MaxLength(100)]
        public string Name { get; set; }

        [Required]
        public decimal PriceEuro { get; set; }

        public decimal? StartPaidEuro { get; set; }

        public decimal? EndPaidEuro { get; set; }

        [Required]
        public TimeSpan Duration { get; set; }

        public bool IsPaid { get; set; }

        public int ArtistId { get; set; }
        public Artist Artist { get; set; }

        public ICollection<Performance> Performances { get; set; } = new List<Performance>();

        public override string ToString()
        {
            return Name;
        }
    }
}
