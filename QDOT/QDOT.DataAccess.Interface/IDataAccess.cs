
namespace QDOT.DataAccess.Interface
{
    public interface  IDataAccess<T>
    {
        T GetAll();

        T GetFiltered(T developers);
    }
}
