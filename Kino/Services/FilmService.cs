namespace Kino.Services
{
    public class FilmService : IFilmService
    {
        private readonly HollywoodDB db;
        public FilmService(HollywoodDB hollywoodDB)
        {
            db = hollywoodDB;
        }
        public void AddFilm(string name, string desc, double? rating, Guid dirId)
        {
            db.Films.Add(new Film()
            {
                Name = name,
                Description = desc,
                Rating = rating,
                DirectorId = dirId,
            });
            db.SaveChanges();
        }
        public void RemoveFilm(string name)
        {
            var film = db.Films.FirstOrDefault(x => x.Name == name);
            if (film != null)
            {
                db.Films.Remove(film);
                db.SaveChanges();
            }
        }
        public Film GetFilm(string name)
        {
            return db.Films.FirstOrDefault(x => x.Name == name);
        }
        public IList<Film> GetFilmList()
        {
            return db.Films.ToList();
        }
        public void ChangeRating(string name, double rating) 
        {
            var film = db.Films.FirstOrDefault(f => f.Name == name);
            if (film != null)
            {
                film.Rating = rating;
                db.SaveChanges();
            }
        }
    }
}
