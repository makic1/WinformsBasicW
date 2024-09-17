using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StageManagmentTwo.Entities
{
    public class Artist
    {
        [Key]
        public int ArtistId { get; set; }

        [Required, MaxLength(100), MinLength(3)]
        public string ArtistName { get; set; }

        [Required]
        public ArtistCategorie ArtistCategorie { get; set; }

        public ICollection<ProgramStage> ProgramStages { get; set; } = new List<ProgramStage>();

        public override string ToString()
        {
            return ArtistName;
        }

    }

    public enum ArtistCategorie
    {
        Band,
        Musiker,
        Kabatterist,
        Schriftsteller
    }
}
