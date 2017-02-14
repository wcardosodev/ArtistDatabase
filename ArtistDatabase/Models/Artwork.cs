using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ArtistDatabase.Models
{
    public class Artwork
    {
        [Key]
        public int ArtworkID { get; set; }
        //------------------------------------------------------------------------
        ////foreign key for Artists
        public int ArtistID { get; set; }
        //------------------------------------------------------------------------
        [StringLength(60), Display(Name = "Artwork Name")]
        public string Name { get; set; }
        //------------------------------------------------------------------------
        //[StringLength(60), Display(ArtistName = "Artist Name")]
        public string ArtistName { get; set; }
        //------------------------------------------------------------------------
        [Required, DataType(DataType.ImageUrl)]
        public string Picture { get; set; }
        //------------------------------------------------------------------------
        [DataType(DataType.MultilineText)]
        public string Info { get; set; }
        //------------------------------------------------------------------------
        public virtual Artist Artist { get; set;}
    }
}