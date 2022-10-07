using Session_8_partone.Model;

namespace Session_8_partone.Services
{
    public class CourseService : ICourseService
    {
        private readonly List<Course> courses;
        public CourseService()
        {
            courses = new List<Course>()
            {
                new Course() {Id=1,CourseName="Web Development",Author="Abc",Price=3000}
            };
        }
        public IEnumerable<Course> GetAllCourses()
        {
            return courses;
        }
    }
}

