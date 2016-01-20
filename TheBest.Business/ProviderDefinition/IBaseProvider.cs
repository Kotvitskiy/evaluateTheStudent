using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.ProviderDefinition
{
    public interface IBaseProvider<T>
    {
        bool Create(T item);

        bool Update(T item);

        bool Delete(string id);

        T Get(string id);

        List<T> GetAll();
    }
}
