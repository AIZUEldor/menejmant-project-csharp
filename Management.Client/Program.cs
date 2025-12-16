using Management.Aplication.Servises;
using Managment.Domain.Models;

namespace Management.Client
{
    public class Program
    {
        private const string PASSWORD = "admin123";
        static StudentService studentService = new StudentService();

        static void Main(string[] args)
        {
            Console.Write("Assalomu aleyko'm xurmatli o'qituvchi :) Shaxsiy profilizga kirmoqchimisiz ? / ha / yoq : ");
            string text = Console.ReadLine()?.ToLower();

            if (text == "ha")
            {
                int attempts = 0;
                string pasword;
                int maxAttempts = 4;

                do
                {
                    if (attempts > 0)
                        Console.WriteLine($"Parolingiz xato, iltimos qaytadan kiriting : {maxAttempts} Urunishingiz qoldi :) ");

                    Console.Write("Parol: ");
                    pasword = Console.ReadLine();
                    attempts++;
                    maxAttempts--;

                    if (attempts > 3)
                    {
                        Console.WriteLine("Urinishlar limiti tugadi. Kirish bloklandi ");
                        return;
                    }

                } while (pasword != PASSWORD);

                Console.WriteLine("Kirish muvaffaqiyatli ");
                ShowStudents();
            }
            else
            {
                Console.WriteLine("Xayr :)");
                return;
            }
        }

        public static void ShowStudents()
        {
            Console.WriteLine("\nSalom, iltimos menyuni tanlang :\n" +
                "1. Talaba kiritish\n" +
                "2. O'quvchilar ro'yxati\n" +
                "3. Qo'sha oladigan o'quvchilar soni");

            string option = Console.ReadLine();

            switch (option)
            {
                case "1":
                    AddStudent();
                    break;

                case "2":
                    var students = studentService.GetStudents();
                    foreach (var student in students)
                    {
                        if (student != null)
                        {
                            Console.WriteLine($"ID: {student.id}, Ismi: {student.firstName}, Familiyasi: {student.lastName}");
                        }
                    }
                    break;

                case "3":
                    PrintStudentCapacity();
                    break;

                default:
                    Console.WriteLine("Noto'g'ri tanlov, iltimos qaytadan urinib ko'ring.");
                    break;
            }
        }

        private static void AddStudent()
        {
            Console.Write("Iltimos talabani ismi va familiyasini kiriting :");
            string firstName = Console.ReadLine();
            string lastName = Console.ReadLine();

            studentService.AddStudent(firstName, lastName);

            Console.WriteLine("Talaba muvaffaqiyatli qo'shildi :)");
        }

        private static void PrintAllStudents()
        {
            Student[] students = studentService.GetStudents();
            foreach (var student in students)
            {
                if (student != null)
                {
                    Console.WriteLine($"ID: {student.id}, Ismi: {student.firstName}, Familiyasi: {student.lastName}");
                }
            }
        }

        private static void PrintStudentCapacity()
        {
            int availableSeats = studentService.GetAvailableSeats();
            Console.WriteLine($"Qo'sha oladigan o'quvchilar soni: {availableSeats}");
        }
    }
}
