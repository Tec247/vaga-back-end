using AutoBem.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace AutoBem.Repository.Context.Mappings
{
    public class ProprietarioMapping : IEntityTypeConfiguration<Proprietario>
    {
        public void Configure(EntityTypeBuilder<Proprietario> builder)
        {
            builder.ToTable("Proprietario");
            builder.HasKey(x => x.Id);

            builder.Property(x => x.Cpf)
                .HasMaxLength(11)
                .IsRequired();

            builder.HasMany(x => x.Veiculos)
                .WithOne(x => x.Proprietario)
                .HasForeignKey(x => x.ProprietarioId)
                .OnDelete(DeleteBehavior.Cascade);
        }
    }
}
