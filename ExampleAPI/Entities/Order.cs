using System.ComponentModel.DataAnnotations;
using ExampleAPI.Core;

namespace ExampleAPI.Entities;

public class Order : Entity<Guid>
{ 
	public Guid ProductId {get; set; }
	public required string Name { get; set; }
    public required ushort Quantity {get; set;}

	public virtual ICollection<Stock> Stocks { get; set; }

	public Order()
	{
		Stocks = new HashSet<Stock>();
	}
}
