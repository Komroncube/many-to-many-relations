// See https://aka.ms/new-console-template for more information
using System.Linq;
//Console.WriteLine("Hello, World!");
var db = new HollywoodDB();
var Actors = new ActorService(db);
var Films = new FilmService(db);
var Directors = new DirectorService();


//Directors.AddDirector("Kristofer");
var dir = Directors.GetDirectorByName("Kristofer");
//Films.AddFilm("Intersteller", "Kosmik kino", 3.4, dir.Id);
//Films.ChangeRating("Intersteller", 7);
//Directors.RemoveDirector("Kristofer");
var film = Films.GetFilm("Intersteller");
//Films.AddFilm("Donkihot", "Sayohat haqida", 5.6, dir.Id);
//var newfilm = Films.GetFilm("Donkihot");
//Actors.AddActor("Jony");
var act = Actors.GetActor("Jony");

//Actors.AddFilm(act, film);
//act.Films.Add(newfilm);
//act.Films.Add( film);
//db.SaveChanges();

var dirs = Directors.GetDirectors();
var films = Films.GetFilmList();
var actors = Actors.GetActors();
foreach(var item in actors)
{
    Console.WriteLine(item.Name);
}