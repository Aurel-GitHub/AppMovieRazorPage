using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MyCoreApp.Models
{
    public class Movie
    {
        public int ID { get; set; }
        public string Title { get; set; }

        /***
         *Récupération de la date,genre et prix
         */
        [Display(Name = "Release Date")]
        [DataType(DataType.Date)]
        public DateTime ReleaseDate { get; set; }
        public string Genre { get; set; }

        [Column(TypeName = "decimal(18, 2)")]
        public decimal Price { get; set; }
        public string Rating { get; set; }
    }
}