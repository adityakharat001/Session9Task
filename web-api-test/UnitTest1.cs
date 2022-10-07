using Microsoft.AspNetCore.Mvc;
using Session_8_partone.Controllers;
using Session_8_partone.Model;
using Session_8_partone.Services;

namespace web_api_test
{
    public class UnitTest1
    {

        private readonly CourseController _courseController;
        private readonly ICourseService _courseService;

        public UnitTest1()
        {

            _courseService = new CourseService();
            _courseController = new CourseController(_courseService);
        }

        [Fact]
        public void Test1()
        {
            var okResult = _courseController.GetAllCourses();
            // Assert
            Assert.IsType<OkObjectResult>(okResult as OkObjectResult);
        }
 

        [Fact]
        public void GetCountOfItems()
        {
            // Act
            var okResult = _courseController.GetAllCourses() as OkObjectResult;
            // Assert
            var items = Assert.IsType<List<Course>>(okResult.Value);
            Assert.Equal(1, items.Count);
        }
    }
}