
using Managment.Domain.Models;

namespace Management.Infrastucture1
{
    public class DbContext
    {
        public DbContext()
        {
            this.Students = new Student[12];
        }
          
        public Student[] Students { get; set; }



    }
}
