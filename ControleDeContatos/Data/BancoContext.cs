using ControleDeContatos.Models;
using Microsoft.EntityFrameworkCore;

namespace ControleDeContatos.Data
{
    public class BancoContext : DbContext
    {
        public BancoContext(DbContextOptions<BancoContext> aptions) : base(aptions)
        {

        }

        public DbSet<ContatoModel> Contatos { get; set; }

    }
}
