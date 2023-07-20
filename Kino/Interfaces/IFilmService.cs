namespace Kino.Interfaces
{
    public interface IFilmService
    {

        public void AddFilm(string name, string description, double? rating, Guid director);
        public Film GetFilm(string name);
        public void RemoveFilm(string name);
        public IList<Film> GetFilmList();
        public void ChangeRating(string name, double rating);

    }
}
