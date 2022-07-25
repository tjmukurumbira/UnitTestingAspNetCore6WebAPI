using EmployeeManagement.DataAccess.Entities;

namespace EmployeeManagement.Test
{
    public class CourseTests
    {
        [Fact]
        public void CourseConstructor_ConstructCourse_IsNewMustBeTrue() 
        {
            var course = new Course("");

            Assert.True(course.IsNew);
        }
    }
}
