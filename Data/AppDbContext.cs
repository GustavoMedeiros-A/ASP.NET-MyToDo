using Microsoft.EntityFrameworkCore;
using MyTodo.Models;

namespace MyTodo.data
{
    public class AppDbContext : DbContext // Dbset representação da tabela // Criação da tabela no banco
    {
        public DbSet<Todo> Todos { get; set; }

        protected override void OnConfiguring( // Utilizar o dbContextOptions para fazer a setagem da conection string
            DbContextOptionsBuilder optionsBuilder) => // Arrow function  para usar apenas uma linha
             optionsBuilder.UseSqlite("DataSource=app.db;Cache=Shared"); // Database configuration

    }
}