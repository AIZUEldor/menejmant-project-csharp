

using Management.Infrastucture1;
using Managment.Domain.Models;

namespace Management.Aplication.Servises
{
    public class StudentService
    {
        public DbContext DbContext { get; set; }

        public StudentService()
        {
            DbContext = new DbContext();
        }
        public void AddStudent(string firstName, string lastName)
        {
            var newStudent = new Student
            {
                id = new Random().Next(1, 1000).ToString(),
                firstName = firstName,
                lastName = lastName
            };
            this.DbContext.Students[0] = newStudent;
        }
    }
}
