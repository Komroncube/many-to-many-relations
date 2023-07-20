namespace Kino.Models
{
    public class Film
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        private double? _rating;
        public double? Rating { get { return _rating; } 
            set
            {
                if(value < 0)
                    _rating = 0;
                else if(value >10)
                    _rating = 10;
                else _rating = value;
            } }
        public Guid DirectorId { get; set; }
        public Director Director { get; set; }
        public ICollection<ActorFilm> ActorFilm { get; set; }
    }
}
