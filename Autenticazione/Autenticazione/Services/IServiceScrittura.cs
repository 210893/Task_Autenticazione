namespace Autenticazione.Services
{
    public interface IServiceScrittura<T>
    {
        bool Insert(T t);
        bool Update(T t);
        bool Delete(int id);
    }
}
