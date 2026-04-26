using EECommerceAPI.Domain.Entities.Common;

namespace EECommerceAPI.Domain.Entities;

public class Customer : BaseEntity
{ 
    public string Name { get; set; } = null!;
    public ICollection<Order> Orders { get; set; } = null!;
}
