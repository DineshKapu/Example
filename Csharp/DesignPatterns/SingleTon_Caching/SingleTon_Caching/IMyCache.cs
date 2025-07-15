using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingleTon_Caching
{
    public interface IMyCache
    {
        object Add(object key, object value);
        object AddOrUpdate(object key, object value);
        bool Remove(object key);
        object Get(object key);
    }
}
