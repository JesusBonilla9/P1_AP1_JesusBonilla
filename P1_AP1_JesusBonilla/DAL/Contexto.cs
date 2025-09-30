using Microsoft.EntityFrameworkCore;
using P1_AP1_JesusBonilla.Models;
namespace P1_AP1_JesusBonilla.DAL;

public class Contexto : DbContext
{
    public DbSet<EntradasHuacales> EntradasHuacales { get; set; }
    public Contexto(DbContextOptions<Contexto> options) : base(options) { }
    
}
