using StageManagmentTwo.Entities;

namespace StageManagmentTwo.Service
{
    public class ServiceArtist
    {
        private readonly DbContextStageManagmentTwo _context;

        public ServiceArtist(DbContextStageManagmentTwo context)
        {
            _context = context;
        }

        public List<Artist> GetAllArtists()
        {
            return _context.Artists.ToList();
        }

        public void AddArtist(Artist artist)
        {
            _context.Artists.Add(artist);
            _context.SaveChanges();
        }

        public void UpdateArtist(Artist artisttoUpdate)
        {
            var artist = FindArtistById(artisttoUpdate.ArtistId);

            if (artist is not null)
            {
                artist.ArtistId = artisttoUpdate.ArtistId;
                artist.ArtistName = artisttoUpdate.ArtistName;
                artist.ArtistCategorie = artisttoUpdate.ArtistCategorie;

                _context.SaveChanges();
            }
        }

        public void DeleteArtist(Artist artist)
        {
            _context.Artists.Remove(FindArtistById(artist.ArtistId));
            _context.SaveChanges();
        }

        public Artist FindArtistById(int id)
        {
            return _context.Artists.Find(id);
        }
    }
}
