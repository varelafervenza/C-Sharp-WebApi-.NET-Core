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

        public T GetAllJson()
        {
            return dataAccess.GetAll();
        }

        public T GetJsonFiltered()
        {
            return dataAccess.GetFiltered();
        }
    }
}
