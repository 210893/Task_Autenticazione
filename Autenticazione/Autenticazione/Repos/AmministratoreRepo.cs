using Autenticazione.Context;
using Autenticazione.Models;

namespace Autenticazione.Repos
{
    public class AmministratoreRepo
    {
        private readonly AutenticazioneContext _context;

        public AmministratoreRepo(AutenticazioneContext context)
        {
            _context = context;
        }


        public Amministratore? GetByUsernamePassword(string user, string pass)
        {
            return _context.Amministratore.FirstOrDefault(a => a.username == user && a.pass == pass);
        }

    }
}
