using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using HRManagerCommon.DTO;

namespace HRManagerEntities
{
    public class Employee
    {

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        public int? DepartmentId { get; set; }

        [ForeignKey(nameof(DepartmentId))]
        public virtual Department Department { get; set; }

        public DateTime DateOfBirth { get; set; }

        [MaxLength(50)]
        public string FirstName { get; set; }


        [MaxLength(50)]
        public string LastName { get; set; }



        [MaxLength(50)]
        public string Address1 { get; set; }

        [MaxLength(50)]
        public string Address2 { get; set; }

        [MaxLength(50)]
        public string City { get; set; }

        [MaxLength(50)]
        public string Region { get; set; }

        [MaxLength(50)]
        public string AreaCode { get; set; }


 

        public EmployeeDTO ToDTO()
        {
            return new EmployeeDTO { Address1 = Address1, Address2 = Address2, City = City, Region = Region, AreaCode = AreaCode , DateOfBirth = DateOfBirth, DepartmentId = DepartmentId, FirstName = FirstName, Id = Id, LastName = LastName };
        }
    }
}
