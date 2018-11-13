using System.Linq;
namespace PYFlowers.Models
{
    public interface IProductRepository
    {
        IQueryable<Product> Products { get; }
    }
}