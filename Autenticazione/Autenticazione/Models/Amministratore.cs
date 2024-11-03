namespace Autenticazione.Models
{
    public class Amministratore
    {
        public int amministratoreID { get; set; }

        public string codice { get; set; } = null!;

        public string username { get; set; } = null!;

        public string pass { get; set; } = null!;

        public string email { get; set; } = null!;
    }
}
