// See https://aka.ms/new-console-template for more information

using StudentApp;

Student student1 = new Student("Long", 21, 3.5);
Student student2 = new Student("Nhat", 22, 10);

Console.WriteLine(student1.DisplayInformation());
Console.WriteLine(student2.ToString());
Console.ReadKey();
