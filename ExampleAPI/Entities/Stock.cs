using System.ComponentModel.DataAnnotations;
using ExampleAPI.Core;

namespace ExampleAPI.Entities;

public class Stock : Entity<Guid>
{
    public Guid ProductId {get; set; }
	public required string Name { get; set; }
    public required ushort Quantity {get; set;}
    public virtual Order Order { get; set; }

}
