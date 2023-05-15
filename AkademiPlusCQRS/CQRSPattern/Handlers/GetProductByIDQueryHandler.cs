using AkademiPlusCQRS.CQRSPattern.Queries;
using AkademiPlusCQRS.CQRSPattern.Results;
using AkademiPlusCQRS.DAL;

namespace AkademiPlusCQRS.CQRSPattern.Handlers
{
    public class GetProductByIDQueryHandler
    {
        private readonly Context _context;

        public GetProductByIDQueryHandler(Context context)
        {
            _context = context;
        }
        public GetProductByIDQueryResult Handle(GetProductByIDQuery query)
        {
            var values=_context.Set<Product>().Find(query.Id);
            return new GetProductByIDQueryResult
            {
                Brand = values.Brand,
                Name = values.Name,
                ProductID = values.ProductID,
            };
        }
    }
}
