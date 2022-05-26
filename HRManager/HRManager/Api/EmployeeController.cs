using Microsoft.AspNetCore.Mvc;
using HRManagerCommon.DTO;
using HRManagerCommon;
using System.Collections.Generic;
using HRManagerEntities;
// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860
using HRManagerBL.Filters;
using HRManagerCommon.DTO.Filters;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using System.Linq;

namespace HRManager.Api
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeController : ControllerBase
    {
        private HRDBContext _context;
        public EmployeeController(HRDBContext context)
        {
            _context = context;
        }

        /// <summary>
        /// Get Employees with filter params from a JSON body, Use the filter sorta repo extension, and then cast the entities to DTO's and then an IEnumerable list.
        /// </summary>
        /// <param name="filter"></param>
        /// <returns></returns>
        [HttpGet]
        public async Task<ResponseDTO<IEnumerable<EmployeeDTO>>> GetEmployees([FromBody] EmployeeFilterParams filter)
        {
            var employees = await _context.Employees.FilterEmployees(filter).Select(x => x.ToDTO()).ToListAsync();

            return new ResponseDTO<IEnumerable<EmployeeDTO>>() { Data = employees };
        }



   
        [HttpGet("{id}")]
        public async Task<ResponseDTO<EmployeeDTO>> Get(int id)
        {
            var employees = await _context.Employees.FilterEmployees(new EmployeeFilterParams() {  Id = id}).Select(x => x.ToDTO()).FirstOrDefaultAsync();

            return new ResponseDTO<EmployeeDTO>() { Data = employees };
        }

        // POST api/<EmployeeController>
        [HttpPost]
        public void Post([FromBody] EmployeeDTO value)
        {
        }

        // PUT api/<EmployeeController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] EmployeeDTO value)
        {
        }

        // DELETE api/<EmployeeController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
