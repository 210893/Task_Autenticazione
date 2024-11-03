namespace Autenticazione.Repos
{
    public interface IreposScrittura<T>
    {
        bool Create(T entity);
        bool Delete(int id);
        bool Update(T entity);
    }
}
