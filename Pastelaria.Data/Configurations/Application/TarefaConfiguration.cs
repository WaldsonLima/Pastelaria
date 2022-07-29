namespace Pastelaria.Data.Configurations.Application
{
    public class TarefaConfiguration
    {
        public void Configure(EntityTypeBuilder<Tarefa> builder)
        {
            builder.ToTable("tarefa");

            builder.HasKey(property => property.Id).HasName("pk_usuario");

            builder.Property(x => x.Id).HasColumnName("id").ValueGeneratedOnAdd();
            
        }
    }
}
