
using AutoBem.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace AutoBem.Repository.Context.Mappings
{
    public class VeiculoMapping : IEntityTypeConfiguration<Veiculo>
    {
        public void Configure(EntityTypeBuilder<Veiculo> builder)
        {
            builder.ToTable("Veiculo");
            builder.HasKey(x => x.Id);

            builder.HasOne(x => x.Proprietario)
                .WithMany(x => x.Veiculos)
                .HasForeignKey(x => x.ProprietarioId)
                .IsRequired(false);
        }
    }
}
