using Net.Data.Infrastructure;
using Net.Model.Models;

namespace Net.Data.Repositories
{
    public class ProductRepsitory : RepositoryBase<Product>
    {
        public ProductRepsitory(IDbFactory dbFactory) : base(dbFactory)
        {
        }
    }
}