using Kino.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kino.Services
{
    public class ActorService : IActorService
    {
       private readonly HollywoodDB db;
        public ActorService(HollywoodDB hollywoodDB ) 
        {
            db = hollywoodDB;
        }
        //public ActorService(HollywoodDB hollywoodDB) 
        //{
        //    db = hollywoodDB;
        //}
        public void AddActor(string name)
        {
            db.Actors.Add(new Actor(name));
            db.SaveChanges();
        }
        public void RemoveActor(string name)
        {
            var actor = db.Actors.Where(x => x.Name == name).FirstOrDefault();
            db.Actors.Remove(actor);
            db.SaveChanges();
        }
        public Actor GetActor(string name) 
        {
            return db.Actors.FirstOrDefault(x => x.Name == name);
        }
        public IList<Actor> GetActors()
        {
            return (IList<Actor>)db.Actors.ToList();
        }

        //xavfli hudud
        public void AddFilm(Actor actor, Film film)
        {
            var act=db.Actors.First(x =>x.Id== actor.Id);
            db.ActorFilm.Add(new ActorFilm() { ActorId = actor.Id, FilmId = film.Id });

            db.SaveChanges();
        }
    }
}
