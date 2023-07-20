namespace Kino.Models
{
    public class Actor
    {
        public Actor() { }
        public Actor(string name) {
            Name = name;
        }
        public Guid Id { get; set; }
        public string Name { get; set; }
        public ICollection<ActorFilm> ActorFilm { get; set; }
    }
}
