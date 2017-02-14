using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity;

namespace ArtistDatabase.Models
{
    public class Artist
    {
        [Key]
        public int ArtistID { get; set; }
        //----------------------------------------------------------------------------------------------
        [Required,StringLength(60, MinimumLength = 3), Display(Name = "Artist")]
        public string Name { get; set; }
        //----------------------------------------------------------------------------------------------
        [DataType(DataType.ImageUrl)]
        public string Picture { get; set; }
        //----------------------------------------------------------------------------------------------
        [System.ComponentModel.DataAnnotations.Schema.Column(TypeName = "datetime2")]
        [Display(Name = "Date of Birth"),DataType(DataType.Date),DisplayFormat(DataFormatString = "{0:dd-MM-yyyy}", ApplyFormatInEditMode = true)]
        public DateTime BirthDate { get; set; }
        //----------------------------------------------------------------------------------------------
        [Required,StringLength(30)]
        public string Nationality { get; set; }
        //----------------------------------------------------------------------------------------------
        [Display(Name = "Style/Movement")]
        public string ArtStyle { get; set; }
        //----------------------------------------------------------------------------------------------
        [DataType(DataType.MultilineText)]
        public string Info { get; set; }
        //----------------------------------------------------------------------------------------------
        [RegularExpression(@"^[A-Z]+[a-zA-Z''-'\s]*$")]
        [StringLength(5)]
        public string Rating { get; set; }
        //----------------------------------------------------------------------------------------------
        [Display(Name = "Famous work: "),DataType(DataType.ImageUrl)]
        public string Artwork1 { get; set; }
        //----------------------------------------------------------------------------------------------
        [Display(Name = " "), DataType(DataType.ImageUrl)]
        public string Artwork2 { get; set; }
        //----------------------------------------------------------------------------------------------
        [Display(Name = " "), DataType(DataType.ImageUrl)]
        public string Artwork3 { get; set; }
        //----------------------------------------------------------------------------------------------
        public virtual ICollection<Artwork> Artworks { get; set; }
    }

    public class ArtistDBContext : DbContext
    {
        public DbSet<Artist> Artists { get; set; }
        public DbSet<Artwork> Artworks { get; set; }
    }
}