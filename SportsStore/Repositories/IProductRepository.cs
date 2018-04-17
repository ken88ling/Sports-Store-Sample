using System.Linq;
using SportsStore.Models;

namespace SportsStore.Repositories {

    public interface IProductRepository {

        IQueryable<Product> Products { get; }

        void SaveProduct(Product product);

        Product DeleteProduct(int productID);
    }
}
