using Asp.NetCoreFromScratch.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Asp.NetCoreFromScratch.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeController : ControllerBase
    {
        //public string GetEmployees()
        //{
        //    return "Get Employees";
        //    ;
        //}
        public List<EmployeeModel> GetEmployeesList()
        {
            return new List<EmployeeModel>() {
                new EmployeeModel() { Id = 1, Name = "Employee 1" },
                new EmployeeModel() { Id = 2, Name = "Employee 2"}}
            ;
        }

        //[Route("{id}/basic")]
        //public ActionResult<EmployeeModel> GetEmployeeBasicDetails(int id)
        //{
        //    if (id == 0)
        //    {
        //        return NotFound();
        //    }

        //    return new EmployeeModel() { Id = 1, Name = "Employee 1" };
        //}

        //[HttpGet("name")]
        //public IActionResult GetName([FromServices] IProductRepository _productRepository)
        //{
        //    var name = _productRepository.GetName();
        //    return Ok(name);
        //}
    }
}
