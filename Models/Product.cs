using System.ComponentModel.DataAnnotations;

namespace e_business_movies.Models
{
    public class Product
    {
        [ScaffoldColumn(false)]
        public int ProductID { get; set; }

        [Required, StringLength(100), Display(Name="Заглавие на филм")]
        public string ProductName { get; set; }

        [Required, StringLength(10000), Display(Name = "Описание на филма"), DataType(DataType.MultilineText)]
        public string Description { get; set; }

        public string ImagePath { get; set; }

        [Required, Display(Name = "Цена")]
        public double Price { get; set; }

        public int CategoryID { get; set; }

        public int GenreID { get; set; }

        public virtual Category Category { get; set; }
        public virtual Genre Genre { get; set; }

    }
}