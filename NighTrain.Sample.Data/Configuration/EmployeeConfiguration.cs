using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using NighTrain.Sample.Domain.Entities;

namespace NighTrain.Sample.Data.Configuration
{
    public class EmployeeConfiguration : IEntityTypeConfiguration<Employee>
    {
        public void Configure(EntityTypeBuilder<Employee> builder)
        {
            builder.HasKey(i => i.Id);

            builder.Property(p => p.Name)
                .HasColumnType("varchar(150)")
                .IsRequired();

            builder.Property(p => p.Surname)
                .HasColumnType("varchar(150)")
                .IsRequired();

            builder.Property(p => p.Birthday)
                .IsRequired();

            builder.HasData(
                new Employee() {Id = 1, Name = "Name", Surname = "Surname", Birthday = DateTime.Now },
                new Employee() {Id = 2, Name = "Name2", Surname = "Surname2", Birthday = DateTime.Now },
                new Employee() {Id = 3, Name = "Name3", Surname = "Surname3", Birthday = DateTime.Now },
                new Employee() {Id = 4, Name = "Name4", Surname = "Surname4", Birthday = DateTime.Now },
                new Employee() { Id = 5, Name = "Name5", Surname = "Surname5", Birthday = DateTime.Now }
            );
        }
    }
}
