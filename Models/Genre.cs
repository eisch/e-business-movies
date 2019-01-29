using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace e_business_movies.Models
{
    public class Genre
    {
        [ScaffoldColumn(false)]
        public int GenreID { get; set; }

        [Required, StringLength(100), Display(Name = "Жанр")]
        public string GenreName { get; set; }

        public virtual ICollection<Product> Products { get; set; }
    }
}