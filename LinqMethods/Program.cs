using LinqMethods.Entities;
using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
        // Create a list of students
        List<Student> students = new List<Student>
        {
            new Student { Id = 1, Name = "Şeyma", Grade = 85 },
            new Student { Id = 2, Name = "Asel", Grade = 92 },
            new Student { Id = 3, Name = "İdil", Grade = 78 },
            new Student { Id = 4, Name = "Hüma", Grade = 95 },
            new Student { Id = 5, Name = "Ayşe", Grade = 88 }
        };

        // Select students with grades higher than 80
        var highPerformers = students.Where(student => student.Grade > 80);

        // List students with grades higher than 80
        Console.WriteLine("Students with grades higher than 80:");
        foreach (var student in highPerformers)
        {
            Console.WriteLine($"ID: {student.Id}, Name: {student.Name}, Grade: {student.Grade}");
        }

        // Find the student with the name "Bob"
        var bob = students.FirstOrDefault(student => student.Name == "Bob");

        // Check if Bob exists
        if (bob != null)
        {
            Console.WriteLine("\nA student named Bob is found.");
        }
        else
        {
            Console.WriteLine("\nNo student named Bob is found.");
        }
    }
}
