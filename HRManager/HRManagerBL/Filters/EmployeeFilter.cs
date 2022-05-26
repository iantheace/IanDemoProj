using HRManagerEntities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HRManagerCommon.DTO.Filters;
namespace HRManagerBL.Filters
{
    public class EmployeeFilters: FilterBase<Employee, EmployeeFilterParams>
    {

    

        public override IQueryable<Employee> Filter(IQueryable<Employee> employees, EmployeeFilterParams filterParams)
        {

            if (filterParams.Id != null) employees = employees.Where(x => x.Id == filterParams.Id);

            if (!string.IsNullOrEmpty(filterParams.FirstName)) employees = filterParams.WildCardMatches ? employees.Where(x => x.FirstName == filterParams.FirstName) : employees.Where(x => x.FirstName.Contains(filterParams.FirstName));

            if (!string.IsNullOrEmpty(filterParams.LastName)) employees = filterParams.WildCardMatches ? employees.Where(x => x.LastName == filterParams.FirstName) : employees.Where(x => x.LastName.Contains(filterParams.FirstName));



            return null;
        }
    }

   


  


}
