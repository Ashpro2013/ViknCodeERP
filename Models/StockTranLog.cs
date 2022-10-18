namespace InventoryBeginners.Models
{
    public class StockTranLog
    {
        public int Id { get; set; }
        public DateTime Date { get; set; }
        public int ProductId { get; set; }
        public Product product { get; set; }
        public int PoHeaderId { get; set; }
        public PoHeader poHeader { get; set; }
        public int UnitId { get; set; }
        public Unit unit { get; set; }
        public decimal Quantity { get; set; }
    }
}
