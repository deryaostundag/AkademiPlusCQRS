namespace AkademiPlusCQRS.CQRSPattern.Commands
{
    public class CreateProductCommand
    {
        public string Brand { get; set; }
        public string Name { get; set; }
        public int Stock { get; set; }
        public decimal Price { get; set; }
        public string Category { get; set; }
    }
}
