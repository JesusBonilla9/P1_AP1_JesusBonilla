using Microsoft.EntityFrameworkCore;
using P1_AP1_JesusBonilla.Models;
namespace P1_AP1_JesusBonilla.DAL
{
    public class Contexto : DbContext
    {
        Contexto(DbContextOptions<Contexto> options) : base(options) { }
        DbSet<Registro> Registros { get; set; }
    }
}
