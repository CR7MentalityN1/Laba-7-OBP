namespace StudentApp;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("=== Система управления студентами ===\n");

        Student student1 = new Student(1, "Иван Петров", "ИСП-211", 4.8);
        Student student2 = new Student(2, "Мария Сидорова", "ИСП-211", 4.3);
        Student student3 = new Student(3, "Алексей Иванов", "ИПИ-211", 5.0);

        Console.WriteLine("Информация о студентах:");
        Console.WriteLine("======================");
        
        student1.DisplayInfo();
        student2.DisplayInfo();
        student3.DisplayInfo();

        Console.WriteLine("\nРезультаты проверки на отличника:");
        Console.WriteLine("==================================");
        
        CheckExcellent(student1);
        CheckExcellent(student2);
        CheckExcellent(student3);

        Console.WriteLine("\nОбновление оценок:");
        Console.WriteLine("==================");
        
        student2.UpdateGrade(4.7);
        Console.WriteLine($"\nОбновлённая информация о {student2.Name}:");
        student2.DisplayInfo();
        

        Console.WriteLine($"\n{student2.Name} теперь отличник? {student2.IsExcellent()}");
    }

    static void CheckExcellent(Student student)
    {
        if (student.IsExcellent())
        {
            Console.WriteLine($"{student.Name} — отличник! (Средний балл: {student.AverageGrade:F2})");
        }
        else
        {
            Console.WriteLine($"{student.Name} — не отличник. (Средний балл: {student.AverageGrade:F2})");
        }
    }
}