

using EmployeeManagement.DataAccess.Entities;

namespace EmployeeManagement.Test
{
    public class EmployeeTests
    {
        [Fact]
        public void EmployeeFullNamePropertyGetter_InputFirstNameAndLastName_FullNameIsConcatenation() 
        {
            var employee = new InternalEmployee("James", "Mukurumbira",0,3000,false,1);

            Assert.Equal("James Mukurumbira", employee.FullName);

        }
    }
}
