using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex2
{
    public class Main<R,T>
    {
        public async Task<R> Compute(T[] elems, R initial)
        {
            R acc = initial;

            foreach (var elem in elems)
            {
                T t1 = await A(elem);

                T t2 = await B(t1);

                acc = await C(t2, acc);
            }
            return acc;
        }
    }
}
