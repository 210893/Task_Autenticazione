namespace Autenticazione.Models
{
    public class Utente
    {
        public int utenteID { get; set; }

        public string codice { get; set; } = null!;

        public string username { get; set; } = null!;

        public string pass { get; set; } = null!;

        public string email { get; set; } = null!;
    }
}
