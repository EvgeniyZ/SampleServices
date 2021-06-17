namespace UniversityService.Controllers
{
    using System.Threading;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Authorization;
    using Microsoft.AspNetCore.Mvc;
    using UniversityService.Data;

    [ApiController]
    [Route("[controller]")]
    [Authorize]
    public sealed class StudentController : ControllerBase
    {
        private readonly StudentRepository studentRepository;

        public StudentController(StudentRepository studentRepository)
        {
            this.studentRepository = studentRepository;
        }

        [HttpGet]
        public async Task<IActionResult> GetAll([FromQuery] int skip = 0, [FromQuery] int take = 100, CancellationToken cancellationToken = default)
        {
            var students = await studentRepository.GetAllPaged(skip, take, cancellationToken);
            return Ok(students);
        }
    }
}
