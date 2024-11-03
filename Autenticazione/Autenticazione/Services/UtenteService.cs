using Autenticazione.Models;
using Autenticazione.Repos;

namespace Autenticazione.Services
{
        public class UtenteService : IServiceLettura<UtenteDTO>, IServiceScrittura<UtenteDTO>
        {

            private readonly UtenteRepo _repoUT;

            public UtenteService(UtenteRepo repoUT)
            {
                _repoUT = repoUT;
            }
            public bool Delete(int id)
            {
                bool risultato = false;

                Utente? delUT = _repoUT.GetById(id);
                if (delUT is not null)
                {
                    risultato = _repoUT.Delete(delUT.utenteID);
                }

                return risultato;
            }

            public UtenteDTO? Details(int id)
            {
                throw new NotImplementedException();

                //PROFILO UTENTE?
            }

            public bool Insert(UtenteDTO t)
            {
                Utente nuovo = new Utente()
                {
                    codice = t.codice is not null ? t.codice : Guid.NewGuid().ToString().ToUpper(),
                    username = t.username,
                    pass = t.pass,
                    email = t.email
                };


                return _repoUT.Create(nuovo);
            }

            public IEnumerable<UtenteDTO> List()
            {
                return (IEnumerable<UtenteDTO>)_repoUT.GetAll();
            }

            public bool Update(UtenteDTO t)
            {
                bool risultato = false;

                if (t.codice is not null)
                {
                    Utente? upUT = _repoUT.GetByCodice(t.codice);

                    if (upUT is not null && t.username is not null && t.pass is not null)
                    {
                        upUT.username = t.username is not null ? t.username : upUT.username;
                        upUT.pass = t.pass is not null ? t.pass : upUT.pass;

                        //todo controlla se funge

                        risultato = _repoUT.Update(upUT);
                    };
                }
                return risultato;
            }


            public UtenteDTO? CercaPerCodice(string codice)
            {
                UtenteDTO? risultato = null;

                Utente? utente = _repoUT.GetByCodice(codice);
                if (utente is not null)
                {
                    risultato = new UtenteDTO()
                    {
                        codice = utente.codice,
                        username = utente.username,
                        email = utente.email,
                        pass = utente.pass,
                    };
                }

                return risultato;
            }

        }
}
