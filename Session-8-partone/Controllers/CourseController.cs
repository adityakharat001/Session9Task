using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Session_8_partone.Services;

namespace Session_8_partone.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CourseController : ControllerBase
    {
        private readonly ICourseService _courseService;
        public CourseController(ICourseService courseService)
        {
            _courseService = courseService;
        }
        [HttpGet]
        public IActionResult GetAllCourses()
        {
            var courses = _courseService.GetAllCourses();
            return Ok(courses);
        }
    }
}
