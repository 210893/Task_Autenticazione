using Autenticazione.Models;
using Autenticazione.Repos;

namespace Autenticazione.Services
{
    public class AmministratoreServices
    {
        private readonly AmministratoreRepo _repo;

        public AmministratoreServices(AmministratoreRepo repo)
        {
            _repo = repo;
        }

        public bool VerificaUsernamePassword(AmministratoreDTO adDto)
        {
            bool risultato = false;

            if (adDto.username is not null && adDto.pass is not null)
            {
                Amministratore? adm = _repo.GetByUsernamePassword(adDto.username, adDto.pass);
                if (adm is not null)
                    risultato = true;
            }

            return risultato;
        }
    }
}
