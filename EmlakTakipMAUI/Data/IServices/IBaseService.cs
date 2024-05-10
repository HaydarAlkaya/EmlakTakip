namespace EmlakTakipMAUI.Data;

public interface IBaseService<T> 
{
    Task Add(T t);
    Task Delete(T t);
    Task Update(T t);
    Task<T> GetById(int id);
    Task<List<T>> GetAll();
}