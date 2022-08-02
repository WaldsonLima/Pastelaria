namespace Pastelaria.Data.Configurations.Application
{
    public class UsuarioTarefaConfiguration : IEntityTypeConfiguration<UsuarioTarefa>
    {
        public void Configure(EntityTypeBuilder<UsuarioTarefa> builder)
        {
            builder.ToTable("usuarioTarefa");

            builder.HasKey(property => property.IdUsuario).HasName("pk_usuarioTarefa");

            builder.Property(x => x.Id).HasColumnName("id");
            builder.Property(x => x.IdUsuario).HasColumnName("idUsuario");
            builder.Property(x => x.IdTarefa).HasColumnName("idTarefa");

            builder.HasOne(x => x.Usuario).WithMany(x => x.UsuariosTarefas).HasForeignKey(x => x.IdUsuario);
            builder.HasOne(x => x.Tarefa).WithMany(x => x.UsuariosTarefas).HasForeignKey(x => x.IdTarefa);
        }
    }
}
