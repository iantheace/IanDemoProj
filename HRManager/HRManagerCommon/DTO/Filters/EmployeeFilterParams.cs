using System;
using System.Collections.Generic;
using System.Text;

namespace HRManagerCommon.DTO.Filters
{
    public class EmployeeFilterParams
    {
        public int? Id { get; set; }


        public string FirstName { get; set; }

        public string LastName { get; set; }



        public bool WildCardMatches { get; set; }
    }

}
