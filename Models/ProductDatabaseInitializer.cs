using System.Collections.Generic;
using System.Data.Entity;

namespace e_business_movies.Models
{
    public class ProductDatabaseInitializer : DropCreateDatabaseAlways<ProductContext>
    {
        protected override void Seed(ProductContext context)
        {
            GetCategories().ForEach(c => context.Categories.Add(c));
            GetGenres().ForEach(g => context.Genres.Add(g));
            GetProducts().ForEach(p => context.Products.Add(p));
        }

        private static List<Category> GetCategories()
        {
            var categories = new List<Category>
            {
                new Category
                {
                    CategoryID = 1,
                    CategoryName = "Български филми"
                },
                new Category
                {
                    CategoryID = 2,
                    CategoryName = "Чуждестранни филми"
                }
            };
            return categories;
        }

        private static List<Genre> GetGenres()
        {
            var genres = new List<Genre>
            {
                new Genre
                {
                    GenreID = 1,
                    GenreName = "Комедия"
                },
                new Genre
                {
                    GenreID = 2,
                    GenreName = "Екшън"
                },
                new Genre
                {
                    GenreID = 3,
                    GenreName = "Драма"
                }
            };
            return genres;
        }

        private static List<Product> GetProducts()
        {
            var products = new List<Product>
            {
               new Product
               {
                    ProductID = 1,
                    ProductName = "Кецове",
                    Description = "В началото на лятото шестима младeжи бягат от своите провали: в семейството, в любовта, парите, амбициите. Бягат от агресията на Града. Всеки един от младежите по свой път бяга на Изток от Ада... Към най-далечната от Града възможна точка. Бягат към морския бряг и към свободата си.Един девствен залив ги събира, сближава и преоткрива за тях надеждата. Но дали бягството от агресията и града е възможно?",
                    ImagePath="Images/ketsove-dvd-31.jpeg",
                    Price = 4.99,
                    CategoryID = 1,
                    GenreID = 3
               },
               new Product
               {
                    ProductID = 2,
                    ProductName = "Мисия Лондон",
                    Description = "Когато властната съпруга на българския президент Деворина Селянска (Ернестина Шинова) решава да даде високопоставен прием в Лондон, новоназначеният с протекциите й посланик Варадин Димитров (Юлиан Вергов) получава една единствена задача – да уреди присъствието на Нейно Величество Елизабет II.",
                    ImagePath="Images/misiya-london-dvd-31.jpeg",
                    Price = 9.99,
                    CategoryID = 1,
                    GenreID = 1
               },
               new Product
               {
                    ProductID = 3,
                    ProductName = "Под игото",
                    Description = "България е под турско робство. В село Бяла Черква се завръща от Диарбекир Иван Краличът. В училището има открит урок. Учениците на Рада Госпожина се притесняват от заплетените въпроси на гръкофила Киряк Стефчов. Тогава се намесва новият учител Бойчо Огнянов, който помага на момичетата. Доктор Соколов и Огнянов организират хората в таен комитет за вдигане на въстание. ",
                    ImagePath="Images/pod-igoto-dvd-31.jpeg",
                    Price = 12.99,
                    CategoryID = 1,
                    GenreID = 3
               },
            };
            return products;
        }
    }
}