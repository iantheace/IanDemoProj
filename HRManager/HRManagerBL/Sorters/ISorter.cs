using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRManagerBL.Orderables
{
    public interface ISorter<T, S>
    {
        public IQueryable<T> OrderBy(IQueryable<T> query, S order);





    }
}
