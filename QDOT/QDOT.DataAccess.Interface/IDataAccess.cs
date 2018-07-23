using System;
using System.Collections.Generic;
using System.Text;

namespace QDOT.DataAccess.Interface
{
    public interface  IDataAccess<T>
    {
        T GetAll();

        T GetFiltered();
    }
}
