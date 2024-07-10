using OnionArchitectureApp.Domain.Common;

namespace OnionArchitectureApp.Domain.Entities;

public class Product : BaseEntity
{
    public string Name { get; set; } = null!;
    public decimal Value { get; set; }
    public int Quantity { get; set; }
}
