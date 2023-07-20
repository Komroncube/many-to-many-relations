using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kino.Models
{
    public class ActorFilm
    {
        public Guid FilmId { get; set; }
        public Film Film { get; set; }

        public Guid ActorId { get; set; }
        public Actor Actor { get; set; }
    }
}
