using Management.Aplication.Servises;

namespace Management.Client
{
    public  class Program
    {
        static void Main(string[] args)
        {
           var studentService = new StudentService();
            studentService.AddStudent("John", "Doe");
        }
    }
}
