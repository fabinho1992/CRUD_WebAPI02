using Microsoft.AspNetCore.Hosting.Server;
using Microsoft.EntityFrameworkCore;
using webAPI02.Models;

namespace webAPI02.Infraestrutura;

public class DbContextControle : DbContext
{
    public DbContextControle(DbContextOptions options) : base(options)
    {
    }

    public DbSet<Produtos> Produtos { get; set; }
    //protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    //{
    //    optionsBuilder.UseSqlServer("Server = (localdb)\\MSSQLLocalDB; Database = Cadastros; Trusted_connection = true;");
    //}
}
