using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRManagerBL.Filters
{
    public interface IFilterable<T, S>
    {

        public IQueryable<T> Filter(IQueryable<T> query, S filterParams);

    }
}
