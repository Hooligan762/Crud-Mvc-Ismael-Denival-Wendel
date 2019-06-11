using System.Data.Entity;
namespace ProjetoCrudApi.Models
{
    public class Contexto: DbContext
    {
        public DbSet<Pessoa> Pessoas { get; set; }
    }
}