using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdvancedC_01
{
    internal interface IRepository<T>
    {


        void Add(T item);
        T Get(int id);
        void Remove(int id);


    }
}
