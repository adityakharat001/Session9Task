using Session_8_partone.Model;

namespace Session_8_partone.Services
{
    public interface ICourseService
    {
        IEnumerable<Course> GetAllCourses();
    }
}
