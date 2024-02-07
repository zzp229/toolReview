// See https://aka.ms/new-console-template for more information
using System.Text.Json;

Console.WriteLine("Hello, World!");

Student[] students = new Student[2]
{
    new Student(){Id = 1, Name = "a"},
    new Student(){Id = 2, Name = "b"},
};

string jsonString = JsonSerializer.Serialize(students);
Console.WriteLine(jsonString);

string filePath = "student.json";

// 写入json文件
File.WriteAllText(filePath, jsonString);

// 读出来
jsonString = File.ReadAllText(filePath);
Student[] students1 = JsonSerializer.Deserialize<Student[]>(jsonString);

foreach (var item in students1)
{
    Console.WriteLine(item.Name + item.Id);
}

Console.ReadLine();



public class Student
{
    public int Id { get; set; }
    public string Name { get; set; }
}
