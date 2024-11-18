using CarRentalManagement.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CarRentalManagement.Configurations.Entities
{
	public class ColorSeed : IEntityTypeConfiguration<Color>
	{
		public void Configure(EntityTypeBuilder<Color> builder)
		{
			builder.HasData(
				new Color
				{
					Id = 1,
					Name = "Black",
					DateCreated = DateTime.Now,
					DateUpdated = DateTime.Now,
					CreatedBy = "System",
					UpdatedBy = "System"
				},
				new Color
				{
					Id = 2,
					Name = "Blue",
					DateCreated = DateTime.Now,
					DateUpdated = DateTime.Now,
					CreatedBy = "System",
					UpdatedBy = "System"
				}
			);
		}
	}
}
