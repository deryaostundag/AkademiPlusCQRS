using AkademiPlusCQRS.CQRSPattern.Commands;
using AkademiPlusCQRS.DAL;

namespace AkademiPlusCQRS.CQRSPattern.Handlers
{
    public class CreateProductCommandHandler
    {
        private readonly Context _context;

        public CreateProductCommandHandler(Context context)
        {
            _context = context;
        }
        public void Handle(CreateProductCommand command)
        {
            _context.Products.Add(new Product()
            {
                Name = command.Name,
                Price = command.Price,
                Brand = command.Brand,
                Stock = command.Stock,
                Category= command.Category,

            });
            _context.SaveChanges();
        }
    }
}
