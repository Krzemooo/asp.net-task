using System.Collections.Generic;

namespace LibApp_Gr3.Interfaces
{
    public interface IBaseContext<T>
    {
        IEnumerable<T> GetList();
        T GetItem(long id);
        void Insert(T item);
        void Update(T item);
        void Remove(long id);
    }
}
