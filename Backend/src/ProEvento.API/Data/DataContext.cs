using Microsoft.EntityFrameworkCore;
using ProEvento.API.Models; // importando o Model para a propriedade DbSet<Evento>

public class DataContext : DbContext
{
    public DataContext(DbContextOptions<DataContext> options) : base (options)
    {
    }

    // Cria o DbSet
    public DbSet<Evento> Evento {get; set;}
    
}
