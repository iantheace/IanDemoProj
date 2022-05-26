using System;
using System.Collections.Generic;
using System.Text;

namespace HRManagerCommon.DTO
{
    public class EmployeeDTO
    {

        public int Id { get; set; }

        public int? DepartmentId { get; set; }



        public DateTime DateOfBirth { get; set; }

    
        public string FirstName { get; set; }


 
        public string LastName { get; set; }



    
        public string Address1 { get; set; }

     
        public string Address2 { get; set; }

        public string City { get; set; }

        public string Region { get; set; }

        public string AreaCode { get; set; }
    }
}
