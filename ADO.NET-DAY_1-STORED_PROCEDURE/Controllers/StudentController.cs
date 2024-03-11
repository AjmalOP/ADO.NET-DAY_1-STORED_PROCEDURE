using ADO.NET_DAY_1_STORED_PROCEDURE.Model;
using ADO.NET_DAY_1_STORED_PROCEDURE.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ADO.NET_DAY_1_STORED_PROCEDURE.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentController : ControllerBase
    {
        private readonly IStudentService _studentService;
        public StudentController(IStudentService studentService)
        {
            _studentService = studentService;
        }
        [HttpGet]
        public IActionResult StoredProcedure_GetById(int id)
        {
            return Ok(_studentService.StoredProcedure_GetById(id));
        }
    }
}
