
namespace QDOT.Domain.Interface
{
    public interface IDomain<T>
    {
        T GetAll();

        T GetFiltered(T developers);
    }
}
