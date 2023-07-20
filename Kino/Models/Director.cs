namespace Kino.Models
{
    public class Director
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public Director()
        { }
        public Director(string name)
        {
            Name = name;
        }
    }
}
