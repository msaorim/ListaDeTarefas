using ListaDeTarefas.Models;
using Microsoft.EntityFrameworkCore;

namespace ListaDeTarefas.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> _context) : base(_context)
        {
        }

        public DbSet<TarefaModel> Tarefas { get; set; }
    }
}
