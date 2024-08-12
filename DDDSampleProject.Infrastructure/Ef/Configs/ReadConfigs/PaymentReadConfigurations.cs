using DDDSampleProject.Infrastructure.Ef.Models.PaymentManagement;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DDDSampleProject.Infrastructure.Ef.Configs.ReadConfigs;

internal sealed partial class ReadConfigurations : IEntityTypeConfiguration<InvoiceReadModel>
{
    public void Configure(EntityTypeBuilder<InvoiceReadModel> builder)
    {
        builder.ToTable("Invoices");
        builder.HasKey(e => e.Id);
        builder.Property(e => e.Amount);
        builder.Property(e => e.Date);
        builder.Property(e => e.UserId);
        builder.Property(e => e.CourseId);

        builder.HasOne(e => e.User).WithMany(e=>e.Invoices);
        builder.HasOne(e => e.Course).WithMany(e => e.Invoices);
    }
}

