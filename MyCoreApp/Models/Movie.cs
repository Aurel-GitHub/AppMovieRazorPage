using System;
using System.ComponentModel.DataAnnotations;

namespace MyCoreApp.Models
{
    public class Movie
    {
        public int ID { get; set; }
        public string Title { get; set; }

        /***
         *Récupération de la date,genre et prix
         */
        [DataType(DataType.Date)]
        public DateTime ReleaseDate { get; set; }
        public string Genre { get; set; }
        public decimal Price { get; set; }
    }
}