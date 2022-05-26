using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRManagerEntities.Interfaces
{
    public interface IDeleteable
    {

        public bool IsDeleted { get; set; }
    }
}
