namespace Kino.Interfaces
{
    public interface IDirectorService
    {
        public IList<Director> GetDirectors();
        public Director GetDirectorByName(string name);
        public void AddDirector(string name);
        public void RemoveDirector(string name);
    }
}
