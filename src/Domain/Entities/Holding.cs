namespace Domain.Entities;

public sealed class Holding
{
    public Guid Id { get; set; }
    public Account? Account { get; set; }
    public Guid AccountId { get; set; }
    public string? Code { get; set; }
    public string? Name { get; set; }
    public DateTime DatePurchased { get; set; }
    public double Quantity { get; set; }
    public double Price { get; set; }
    public double StopLossPrice { get; set; }
}