using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CardGameApp.Utils
{
    public interface IMapper<T1, T2>
    {
        T1 Map(T2 mapFrom);
        T2 Map(T1 mapFrom);
    }
}
