using System;


namespace QDOT.Domain.Interface
{
    public interface IDomain<T>
    {
        T GetAllJson();

        T GetJsonFiltered();
    }
}
