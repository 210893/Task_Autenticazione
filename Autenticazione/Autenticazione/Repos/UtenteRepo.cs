using Autenticazione.Context;
using Autenticazione.Models;

namespace Autenticazione.Repos
{
    public class UtenteRepo : IReposLettura<Utente>, IreposScrittura<Utente>
    {
        private readonly AutenticazioneContext _context;

        public UtenteRepo(AutenticazioneContext context)
        {

            _context = context;
        }


        public Utente? GetByCodice(string codice)
        {
            return _context.Utente.FirstOrDefault(c => c.codice == codice);
        }

        public bool Create(Utente entity)
        {
            bool risultato = false;

            try
            {
                _context.Utente.Add(entity);
                _context.SaveChanges();

                risultato = true;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);

            }

            return risultato;
        }

        public bool Delete(int id)
        {
            bool result = false;


            try
            {

                Utente utent = _context.Utente.Single(U => U.utenteID == id);
                _context.Utente.Remove(utent);
                _context.SaveChanges();


                result = true;
            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.Message);
            }



            return result;
        }

        public IEnumerable<Utente> GetAll()
        {
            return _context.Utente.ToList();
        }

        public Utente? GetById(int id)
        {
            return _context.Utente.Find(id);
        }

        public bool Update(Utente entity)
        {
            bool result = false;
            try
            {
                Utente utent = _context.Utente.Single(mod => mod.codice == entity.codice);

                entity.utenteID = utent.utenteID;
                entity.codice = entity.codice is not null ? entity.codice : utent.codice;
                entity.username = entity.username is not null ? entity.username : utent.username;
                entity.pass = entity.pass is not null ? entity.pass : utent.pass;
                entity.email = entity.email is not null ? entity.email : utent.email;



                _context.Utente.Add(entity);
                _context.SaveChanges();

                result = true;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            return result;
        }
    }
}
