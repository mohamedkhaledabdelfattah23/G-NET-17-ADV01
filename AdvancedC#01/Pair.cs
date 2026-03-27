using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdvancedC_01
{
    internal class Pair<TKey , TValue>
    {

        public TKey Key { get; set; }
        public TValue Value { get; set; }

    }
}
