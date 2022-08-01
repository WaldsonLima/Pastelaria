namespace Pastelaria.Data.Configurations.Application
{
    public class UsuarioTarefaConfiguration : IEntityTypeConfiguration<UsuarioTarefa>
    {
        public void Configure(EntityTypeBuilder<UsuarioTarefa> builder)
        {
            builder.ToTable("usuarioTarefa");

            builder.HasKey(property => property.IdUsuario).HasName("pk_usuarioTarefa");
            builder.HasKey(property => property.IdTarefa).HasName("pk_usuarioTarefa");

            builder.Property(x => x.IdUsuario).HasColumnName("idUsuario").ValueGeneratedOnAdd();
            builder.Property(x => x.IdTarefa).HasColumnName("idTarefa").ValueGeneratedOnAdd();

            builder.HasOne(x => x.Usuario).WithMany(x => x.UsuarioTarefas).HasForeignKey(x => x.IdUsuario);
            builder.HasOne(x => x.Tarefa).WithMany(x => x.UsuarioTarefas).HasForeignKey(x => x.IdTarefa);
        }
    }
}
