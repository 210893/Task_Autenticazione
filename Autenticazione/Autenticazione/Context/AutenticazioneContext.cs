using Autenticazione.Models;
using Microsoft.EntityFrameworkCore;

namespace Autenticazione.Context
{
    public class AutenticazioneContext : DbContext
    {
        public AutenticazioneContext(DbContextOptions<AutenticazioneContext> options) : base(options) { }


        public DbSet<Utente> Utente { get; set; }
        public DbSet<Amministratore> Amministratore { get; set; }
    }
}
