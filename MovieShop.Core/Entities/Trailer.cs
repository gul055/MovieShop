using System;
using System.Collections.Generic;
using System.Text;

namespace MovieShop.Core.Entities
{
    //One Movie Can Have Multiple Trailers
    public class Trailer
    {
        public int Id { get; set; }

        // Foreign Key from Movie table which is Id as PK there.
        //public int MovieId { get; set; }

        public string TrailerUrl { get; set; }

        public string Name { get; set; }

        // Navigation Properties, help is navigate to related entities.
        // trailerId 24 => get me Movie Title and Movie Overview
        //public Movie Movie { get; set; }
    }
}
