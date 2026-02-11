using System;
using System.Collections.Generic;
using System.IO;

class Program
{
    static List<Student> students = new List<Student>();

    static void Main()
    {
        bool running = true;

        while (running)
        {
            Console.Clear();
            Console.WriteLine("=== Gestionnaire de notes ===");
            Console.WriteLine("1. Ajouter un étudiant");
            Console.WriteLine("2. Afficher les bulletins");
            Console.WriteLine("3. Exporter les bulletins dans un fichier");
            Console.WriteLine("4. Quitter");
            Console.Write("\nChoix : ");

            string choice = Console.ReadLine() ?? "";

            switch (choice)
            {
                case "1":
                    AddStudent();
                    break;
                case "2":
                    DisplayReports();
                    break;
                case "3":
                    ExportReports();
                    break;
                case "4":
                    running = false;
                    break;
                default:
                    Console.WriteLine("Choix invalide.");
                    Console.ReadKey();
                    break;
            }
        }
    }

    static void AddStudent()
    {
        Console.Clear();
        Console.Write("Nom de l'étudiant : ");
        string name = Console.ReadLine() ?? "Sans nom";

        var student = new Student { Name = name };

        Console.WriteLine("Entre les notes (0 à 20). Tape 'fin' pour terminer.");

        while (true)
        {
            Console.Write("Note : ");
            string input = Console.ReadLine() ?? "";

            if (input.Trim().ToLower() == "fin")
                break;

            if (int.TryParse(input, out int grade) && grade >= 0 && grade <= 20)
            {
                student.Grades.Add(grade);
            }
            else
            {
                Console.WriteLine("Note invalide.");
            }
        }

        students.Add(student);
        Console.WriteLine("\nÉtudiant ajouté !");
        Console.ReadKey();
    }

    static void DisplayReports()
    {
        Console.Clear();

        if (students.Count == 0)
        {
            Console.WriteLine("Aucun étudiant.");
        }
        else
        {
            foreach (var student in students)
            {
                Console.WriteLine(student.GetReport());
            }
        }

        Console.WriteLine("Appuie sur une touche...");
        Console.ReadKey();
    }

    static void ExportReports()
    {
        Console.Clear();

        if (students.Count == 0)
        {
            Console.WriteLine("Aucun étudiant à exporter.");
        }
        else
        {
            string fileName = "bulletins.txt";

            using (var writer = new StreamWriter(fileName))
            {
                foreach (var student in students)
                {
                    writer.WriteLine(student.GetReport());
                }
            }

            Console.WriteLine($"Bulletins exportés dans {fileName}");
        }

        Console.WriteLine("Appuie sur une touche...");
        Console.ReadKey();
    }
}
