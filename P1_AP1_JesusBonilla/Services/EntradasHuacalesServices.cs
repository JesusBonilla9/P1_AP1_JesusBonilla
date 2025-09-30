using Microsoft.EntityFrameworkCore;
using P1_AP1_JesusBonilla.DAL;
using P1_AP1_JesusBonilla.Models;
using System.Linq.Expressions;

namespace P1_AP1_JesusBonilla.Services;

public class EntradasHuacalesServices(IDbContextFactory <Contexto> DbFactory) 
{
    public async Task<bool> Guardar(EntradasHuacales Entrada)
    {
        if (!await Existe(Entrada.EntradaId))
        {
            return await Insertar(Entrada);
        }
        else
        {
            return await Modificar(Entrada);
        }
    }
    public async Task<bool> Existe(int EntradaId)
    {
        await using var contexto = await DbFactory.CreateDbContextAsync();
        return await contexto.EntradasHuacales.AnyAsync(p => p.EntradaId == EntradaId);
    }
    private async Task<bool> Insertar(EntradasHuacales Entrada)
    {
        await using var contexto = await DbFactory.CreateDbContextAsync();
        contexto.EntradasHuacales.Add(Entrada);
        return await contexto.SaveChangesAsync() > 0;
    }
    private async Task<bool> Modificar(EntradasHuacales Entrada)
    {
        await using var contexto = await DbFactory.CreateDbContextAsync();
        contexto.Update(Entrada);
        return await contexto.SaveChangesAsync() > 0;
    }
    public async Task<EntradasHuacales?> Buscar(int EntradaId)
    {
        await using var contexto = await DbFactory.CreateDbContextAsync();
        return await contexto.EntradasHuacales.FirstOrDefaultAsync(p => p.EntradaId == EntradaId);

    }
    public async Task<bool> Eliminar(int EntradaId)
    {
        await using var contexto = await DbFactory.CreateDbContextAsync();
        return await contexto.EntradasHuacales.AsNoTracking().Where(p => p.EntradaId == EntradaId).ExecuteDeleteAsync() > 0;
    }
    public async Task<List<EntradasHuacales>> Listar(Expression<Func<EntradasHuacales, bool>> criterio)
    {
        await using var contexto = await DbFactory.CreateDbContextAsync();
        return await contexto.EntradasHuacales.Where(criterio).AsNoTracking().ToListAsync();
    }
}
