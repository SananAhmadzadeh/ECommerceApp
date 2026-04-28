using ECommerceAPI.Domain.Entities.Common;

namespace ECommerceAPI.Domain.Entities;

public class Order : BaseEntity
{
    public Guid CustomerId { get; set; }
    public string Description { get; set; } = null!;
    public string Address { get; set; } = null!;
    public Customer Customer { get; set; } = null!;
    public ICollection<Product> Products { get; set; } = null!;
}
