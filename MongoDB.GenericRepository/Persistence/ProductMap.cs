using MongoDB.Bson.Serialization;
using SMCT.DataAccess.Model;

namespace MongoDB.GenericRepository.Persistence
{
    public class ProductMap
    {
        public static void Configure()
        {
            BsonClassMap.RegisterClassMap<Product>(map =>
            {
                map.AutoMap();
                map.SetIgnoreExtraElements(true);
                map.MapIdMember(x => x.Id);
                map.MapMember(x => x.Description).SetIsRequired(true);
            });
        }
    }
}