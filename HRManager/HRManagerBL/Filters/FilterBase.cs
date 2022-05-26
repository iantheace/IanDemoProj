using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRManagerBL.Filters
{
    public abstract class FilterBase<T, S> : IFilterable<T, S>
    {
        public abstract IQueryable<T> Filter(IQueryable<T> query, S filterParams);
    }
}
