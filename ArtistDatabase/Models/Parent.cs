using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ArtistDatabase.Models
{
    public class Parent
    {
        public IEnumerable<Artist> Artist { get; set; }
        public IEnumerable<Artwork> Artwork { get; set; }
    }
}