using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HRManagerEntities;
using HRManagerCommon.DTO.Filters;
namespace HRManagerBL.Filters
{
    public static class FilterExtensions
    {

        public static IQueryable<Employee> FilterEmployees(this IQueryable<Employee> employees, EmployeeFilterParams filter) => 
            new EmployeeFilters().Filter(employees, filter); 


    }
}
