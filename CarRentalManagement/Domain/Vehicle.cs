using Microsoft.AspNetCore.Mvc.ModelBinding.Metadata;

namespace CarRentalManagement.Domain
{
	public class Vehicle : BaseDomainModel
	{
		public int Year { get; set; }
		public string? LicensePLateNumeber { get; set; }
		public int MakeId { get; set; }
		public int ModelId { get; set; }
		public int ColorId { get; set; }
	}
}
