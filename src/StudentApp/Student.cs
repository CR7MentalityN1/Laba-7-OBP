namespace StudentApp;

public class Student
{
    // Свойства
    public int Id { get; set; }
    public string Name { get; set; }
    public string Group { get; set; }
    public double AverageGrade { get; set; }

    // Конструктор с параметрами для всех свойств
    public Student(int id, string name, string group, double averageGrade)
    {
        Id = id;
        Name = name;
        Group = group;
        AverageGrade = averageGrade;
    }

    // Метод для вывода информации о студенте
    public void DisplayInfo()
    {
        Console.WriteLine($"ID: {Id}");
        Console.WriteLine($"Имя: {Name}");
        Console.WriteLine($"Группа: {Group}");
        Console.WriteLine($"Средний балл: {AverageGrade:F2}");
        Console.WriteLine(new string('-', 30));
    }

    // Метод проверки — отличник ли студент (средний балл >= 4.5)
    public bool IsExcellent()
    {
        return AverageGrade >= 4.5;
    }

    // Метод для обновления среднего балла
    public void UpdateGrade(double newGrade)
    {
        AverageGrade = newGrade;
        Console.WriteLine($"Студенту {Name} успешно обновлён средний балл на {AverageGrade:F2}");
    }
}