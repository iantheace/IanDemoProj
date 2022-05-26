using HRManagerBL.Orderables;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRManagerBL.Sorters
{
    public abstract class FilterBase<T,S> : ISorter<T,S>
    {
        public abstract IQueryable<T> OrderBy(IQueryable<T> query, S order);

    }
}
