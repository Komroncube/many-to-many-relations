namespace Kino.Interfaces
{
    public interface IActorService
    {
        public void AddActor(string name);
        public void RemoveActor(string name);
        public Actor GetActor(string name);
        public IList<Actor> GetActors();
        public void AddFilm(Actor actor, Film film);

    }
}
