namespace Pastelaria.Data.Configurations.Application
{
    public class TipoUsuarioConfiguration : IEntityTypeConfiguration<TipoUsuario>
    {
        public void Configure(EntityTypeBuilder<TipoUsuario> builder)
        {
            builder.ToTable("tipoUsuario");

            builder.HasKey(property => property.Id).HasName("pk_tipoUsuario");

            builder.Property(x => x.Id).HasColumnName("id");
            builder.Property(x => x.Descricao).HasColumnName("descricao").HasMaxLength(45);

            builder.HasMany(x => x.Usuarios).WithOne(x => x.TipoUsuario).HasForeignKey(x => x.IdTipoUsuario);
        }
    }
}
