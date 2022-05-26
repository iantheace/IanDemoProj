using HRManagerEntities.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRManagerEntities
{
    public class HREntityBase : IDeleteable
    {
        public bool IsDeleted { get; set; }


    }
}
