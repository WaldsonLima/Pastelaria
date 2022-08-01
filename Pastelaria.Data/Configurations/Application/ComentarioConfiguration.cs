namespace Pastelaria.Data.Configurations.Application
{
    public class ComentarioConfiguration : IEntityTypeConfiguration<Comentario>
    {
        public void Configure(EntityTypeBuilder<Comentario> builder)
        {
            builder.ToTable("comentario");

            builder.HasKey(property => property.Id).HasName("pk_comentario");

            builder.Property(x => x.Id).HasColumnName("id").ValueGeneratedOnAdd();
            builder.Property(x => x.IdTarefa).HasColumnName("idTarefa");
            builder.Property(x => x.IdComentarioRespondido).HasColumnName("idComentarioRespondido");
            builder.Property(x => x.Comentarioo).HasColumnName("comentario").HasMaxLength(200);
            builder.Property(x => x.IdUsuarioCadastro).HasColumnName("idUsuarioCadastro");

            builder.HasOne(x => x.Tarefa).WithMany(x => x.Comentarios).HasForeignKey(x => x.IdTarefa);
        }
    }
}
