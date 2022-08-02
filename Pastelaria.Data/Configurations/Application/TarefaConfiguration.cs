namespace Pastelaria.Data.Configurations.Application
{
    public class TarefaConfiguration : IEntityTypeConfiguration<Tarefa>
    {
        public void Configure(EntityTypeBuilder<Tarefa> builder)
        {
            builder.ToTable("tarefa");

            builder.HasKey(property => property.Id).HasName("pk_tarefa");

            builder.Property(x => x.Id).HasColumnName("id").ValueGeneratedOnAdd();
            builder.Property(x => x.IdTarefaStatus).HasColumnName("idTarefaStatus");
            builder.Property(x => x.Descricao).HasColumnName("descricao").HasMaxLength(45);
            builder.Property(x => x.DataInicio).HasColumnName("dataInicio");
            builder.Property(x => x.DataConclusao).HasColumnName("dataConclusao");
            builder.Property(x => x.IdUsuarioCadastro).HasColumnName("idUsuarioCadastro");

            builder.HasMany(x => x.UsuariosTarefas).WithOne(x => x.Tarefa).HasForeignKey(x => x.IdTarefa);
            builder.HasOne(x => x.TarefaStatus).WithMany(x => x.Tarefas).HasForeignKey(x => x.IdTarefaStatus);
            builder.HasMany(x => x.Comentarios).WithOne(x => x.Tarefa).HasForeignKey(x => x.IdTarefa);      
        }
    }
}
