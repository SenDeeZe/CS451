using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Razor1.Data
{
    public interface IJsonDataProvider<T>
    {
        public List<T> GetData();
    }
}
