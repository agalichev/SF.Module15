namespace SF.Module15
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var classes = new[]
            {
                new Classroom { Student = { "Evgeniy", "Sergey", "Andrew" }, },
                new Classroom { Student = { "Anna", "Viktor", "Vladimir" }, },
                new Classroom { Student = { "Bulat", "Alex", "Galina" } }   
            };

            // Получаем массив имен всех студентов
            var allStudents = GetAllStudents(classes);

            Console.WriteLine("Вот список всех студентов:");
            Console.WriteLine(string.Join(" ", allStudents));

            Console.ReadLine();
        }

        // Метод, который делает выборку с нескольких коллекций и возвращает все в одном массиве строк
        static string[] GetAllStudents(Classroom[] classes)
        {
            return (from classroom in classes
                    from student in classroom.Student
                    select student).ToArray();
        }
    }
}