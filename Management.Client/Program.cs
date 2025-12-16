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
            Console.Write(" 'Kabutar' platformasiga xush kelipsiz :) Iltimos ismingizni kiriting : ");
            string name = Console.ReadLine();
            Console.Write($"Assalomu aleyko'm xurmatli {name} :) Shaxsiy profilizga kirmoqchimisiz ? / ha / yoq : ");
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

                    Console.Write("Shaxsiy parolingizni kiriting : ");
                    pasword = Console.ReadLine();
                    attempts++;
                    maxAttempts--;

                    if (attempts > 3)
                    {
                        Console.WriteLine("Urinishlar limiti tugadi. Kirish bloklandi ");
                        return;
                    }

                } while (pasword != PASSWORD);

                Console.WriteLine("///////////////////////////////////////////////////////////////////////////////////////");
                Console.WriteLine($"Tabriklaymiz {name} siz muvaffaqiyatli tizimga kirdingiz :) ");
                RunMenu();
            }
            else
            {
                Console.WriteLine("Hop . Xayr :)");
                return;
            }
        }

        public static void RunMenu()
        {
            bool continueWork = true;

            while (continueWork)
            {
                Console.WriteLine("\n Iltimos menyuni tanlang :\n" +
                    "1. Talaba kiritish\n" +
                    "2. O'quvchilar ro'yxati\n" +
                    "3. Qo'sha oladigan o'quvchilar soni");

                Console.Write("Tanlovingiz: ");
                string option = Console.ReadLine();

                switch (option)
                {
                    case "1":
                        AddStudent();
                        break;

                    case "2":
                        PrintAllStudents();
                        break;

                    case "3":
                        PrintStudentCapacity();
                        break;

                    default:
                        Console.WriteLine("Noto'g'ri tanlov.");
                        break;
                }

                continueWork = AskToContinue();
            }

            Console.WriteLine("\nDastur yakunlandi. Xayr salomat bo'ling :)");
        }


        private static void AddStudent()
        {
            Console.WriteLine("Iltimos talabani ismi va familiyasini kiriting :");
            string firstName = Console.ReadLine();
            string lastName = Console.ReadLine();

            studentService.AddStudent(firstName, lastName);

            Console.WriteLine("Tabriklaymiz :) . Talaba muvaffaqiyatli qo'shildi :)");
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

        private static bool AskToContinue()
        {
            Console.Write("\nYana bir amal bajarishni xohlaysizmi? (ha / yo'q): ");
            string answer = Console.ReadLine()?.ToLower();

            return answer == "ha";
        }

    }
}
