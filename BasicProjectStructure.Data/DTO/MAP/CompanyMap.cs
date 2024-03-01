using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicProjectStructure.Data.DTO.MAP
{
    internal class CompanyMap : IEntityTypeConfiguration<Company>
    {
        public void Configure(EntityTypeBuilder<Company> builder)
        {
            // Table Name
            builder.ToTable("Companies");

            // Primary Key
            builder.HasKey(c => c.Id);

            // Basic Constraints
            builder.Property(c => c.Name).HasDefaultValue("name");

            // Make Relations
            builder.HasMany(c => c.Employees).WithOne(c => c.Company)
                .HasPrincipalKey(c => c.Id).HasForeignKey(e => e.CompanyId);
        }
    }
}
