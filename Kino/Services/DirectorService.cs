namespace Kino.Services
{
    public class DirectorService : IDirectorService
    {
        HollywoodDB db;
        public DirectorService() 
        {
            db = new HollywoodDB();
        }
        public void AddDirector(string name)
        {
            db.Directors.Add(new Director(name));
            db.SaveChanges();

        }
        public void RemoveDirector(string name)
        {
            var dir = db.Directors.FirstOrDefault(d => d.Name == name);
            if(dir!=null)
                db.Directors.Remove(dir);
            db.SaveChanges();
        }
        public Director GetDirectorByName(string name)
        {
            return db.Directors.FirstOrDefault(d => d.Name == name);
        }
        public IList<Director> GetDirectors()
        {
            return (IList<Director>)db.Directors.ToList();
        }

    }
}
