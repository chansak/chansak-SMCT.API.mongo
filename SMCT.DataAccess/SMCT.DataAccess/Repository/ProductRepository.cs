using SMCT.DataAccess.Interfaces;
using SMCT.DataAccess.Model;

namespace SMCT.DataAccess.Repository
{
    public class ProductRepository : BaseRepository<Product>, IProductRepository
    {
        public ProductRepository(IMongoContext context) : base(context)
        {
        }
    }
}
