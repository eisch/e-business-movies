using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace e_business_movies.Models
{
    public class Category
    {
        [ScaffoldColumn(false)]
        public int CategoryID { get; set; }

        [Required, StringLength(100), Display(Name = "Категория")]
        public string CategoryName { get; set; }

        [Display(Name = "Описание на продукта")]
        public string Description { get; set; }

        public virtual ICollection<Product> Products { get; set; }
    }
}