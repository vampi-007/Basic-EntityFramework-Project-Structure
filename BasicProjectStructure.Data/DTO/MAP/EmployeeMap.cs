using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicProjectStructure.Data.DTO.MAP
{
    internal class EmployeeMap : IEntityTypeConfiguration<Employee>
    {
        public void Configure(EntityTypeBuilder<Employee> builder)
        {
            // Table Name
            builder.ToTable("Employees");

            // Primary Key
            builder.HasKey(c => c.Id);

            // Basic Constraints
            builder.Property(c => c.Name).HasDefaultValue("name");

            // Make Relations
            builder.HasOne(c => c.Company).WithMany(c => c.Employees)
                .HasPrincipalKey(c => c.Id).HasForeignKey(e => e.CompanyId);
        }
    }
}
