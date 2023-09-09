namespace Domain.Entities;

public sealed class Account
{
    public Guid Id { get; set; }
    public string? FirstName { get; set; }
    public string? LastName { get; set; }
    public double AccountBalance { get; set; }
    public double FeesPaid { get; set; }
    public double TaxesPaid { get; set; }
    public bool IsBot { get; set; }
    public TradingMethod TradingMethod {get; set;}
}