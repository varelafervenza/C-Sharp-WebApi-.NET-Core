using QDOT.Domain.Interface;
using QDOT.DataAccess.Interface;
using System;

namespace QDOT.Domain
{
    public class Domain<T> : IDomain<T>, IDisposable
    {
        private IDataAccess<T> dataAccess;

        public Domain(IDataAccess<T> _dataAccess)
        {
            this.dataAccess = _dataAccess;
        }

        public void Dispose()
        {
            
        }

        public T GetAll()
        {
            return dataAccess.GetAll();
        }

        public T GetFiltered(T developers)
        {
            return dataAccess.GetFiltered(developers);
        }
    }
}
