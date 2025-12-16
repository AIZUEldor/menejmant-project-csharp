using Management.Infrastucture1.Date;
using Managment.Domain.Models;

namespace Management.Aplication.Servises
{
    public class StudentService
    {
        public DbContext DbContext { get; set; }
        private int index = 0;

        public StudentService()
        {
            this.DbContext = new DbContext();
        }
        public void AddStudent(string firstName, string lastName)
        {
            if (index >= DbContext.Students.Length)
            {
                return;
            }
            var newStudent = new Student
            {
                id = new Random().Next(1, 1000).ToString(),
                firstName = firstName,
                lastName = lastName
            };

            this.DbContext.Students[index] = newStudent;
            index++;

        }

        public Student[] GetStudents()
        {
            if (this.DbContext.Students[0] == null)
            {
                Console.WriteLine("Hozircha hech qanday talaba qo'shilmagan ");
            }
            return this.DbContext.Students;
        }

        public int GetAvailableSeats()
        {
            return this.DbContext.Students.Length - this.index;
        }

    }
}
