using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using NodaTime;

namespace Test.RCS1201
{
    public class MyEntityConfig : IEntityTypeConfiguration<MyEntity>
    {
        public void Configure(EntityTypeBuilder<MyEntity> builder)
        {
            builder.Property(x => x.Col3).HasConversion(MyConverter);

            builder.HasIndex(x => new { x.Col1, x.Col2 });
            builder.HasIndex(x => new { x.Col1, x.Col3, x.Col2 }).IsUnique();
        }

        public ValueConverter<YearMonth, int> MyConverter { get; set; }
    }
}
