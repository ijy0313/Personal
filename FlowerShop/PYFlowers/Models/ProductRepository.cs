using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PYFlowers.Models
{
    public class ProductRepository : IProductRepository
    {
        public IQueryable<Product> Products => InputProducts.AsQueryable();
        public static void AddProduct(Product product)
        {
            InputProducts.Add(product);
        }
        public static List<Product> InputProducts = new List<Product> {
            new Product
            {
                Name = "Daffodil",
                Description = "Showy yellow or white, with six petals",
                Category = "Spring Flowers",
                Price = 10,
                Stock = 312,
                Wrap = "Yes",
                Gift = "Yes"
            },
            new Product
            {
                Name = "Tulip",
                Description = "Cup-shaped with three petals",
                Category = "Spring Flowers",
                Price = 14,
                Stock = 122,
                Wrap = "Yes",
                Gift = "Yes"
            },
            new Product
            {
                Name = "Eranthis",
                Description = "Frost-tolerant and readily survive in snow",
                Category = "Spring Flowers",
                Price = 18,
                Stock = 43,
                Wrap = "Yes",
                Gift = "Yes"
            },
            new Product
            {
                Name = "Crocus",
                Description = "Brightest and earliest spring bloomers",
                Category = "Spring Flowers",
                Price = 9,
                Stock = 89,
                Wrap = "Yes",
                Gift = "No"
            },
            new Product
            {
                Name = "Dahlias",
                Description = "Tuberous-rooted tender perennials",
                Category = "Summer Flowers",
                Price = 22,
                Stock = 11,
                Wrap = "Yes",
                Gift = "Yes"
            },
            new Product
            {
                Name = "Zinnia",
                Description = "Low-maintenance flower with brilliant colours",
                Category = "Summer Flowers",
                Price = 12,
                Stock = 99,
                Wrap = "Yes",
                Gift = "Yes"
            },
            new Product
            {
                Name = "Marigold",
                Description = "Yellow, orange, or cream puff balls",
                Category = "Summer Flowers",
                Price = 16,
                Stock = 67,
                Wrap = "Yes",
                Gift = "Yes"
            },
            new Product
            {
                Name = "Daylilies",
                Description = "Flower that looks like a starfish",
                Category = "Summer Flowers",
                Price = 22,
                Stock = 400,
                Wrap = "No",
                Gift = "Yes"

            },
            new Product
            {
                Name = "Helleborus",
                Description = "Christmas Rose that comes in white, green and red",
                Category = "Winter Flowers",
                Price = 17,
                Stock = 44,
                Wrap = "No",
                Gift = "No"

            },
            new Product
            {
                Name = "Mahonia",
                Description = "Evergreen shrubs that are sunny yellow",
                Category = "Winter Flowers",
                Price = 9,
                Stock = 21,
                Wrap = "Yes",
                Gift = "Yes"
            },
            new Product
            {
                Name = "Daphne",
                Description = "Extremely fragrant flower",
                Category = "Winter Flowers",
                Price = 18,
                Stock = 90,
                Wrap = "Yes",
                Gift = "Yes"
            },
            new Product
            {
                Name = "Winter Jasmine",
                Description = "Yellow star-shaped leaves",
                Category = "Winter Flowers",
                Price = 18,
                Stock = 55,
                Wrap = "Yes",
                Gift = "Yes"
            }
        };
    }
}
