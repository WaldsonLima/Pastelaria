namespace Pastelaria.Data.Configurations.Application
{
    public class TarefaStatusConfiguration : IEntityTypeConfiguration<TarefaStatus>
    {
        public void Configure(EntityTypeBuilder<TarefaStatus> builder)
        {
            builder.ToTable("tarefaStatus");

            builder.HasKey(property => property.Id).HasName("pk_tarefaStatus");

            builder.Property(x => x.Id).HasColumnName("id");
            builder.Property(x => x.Descricao).HasColumnName("descricao").HasMaxLength(45);

            builder.HasMany(x => x.Tarefas).WithOne(x => x.TarefaStatus).HasForeignKey(x => x.IdTarefaStatus);
        }
    }
}
