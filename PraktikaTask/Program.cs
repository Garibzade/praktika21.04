using PraktikaTask.Models;
using System.Threading.Channels;

namespace PraktikaTask
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Group ab106 = new("AB106");
            Group ab105 = new("AB105");

            List<Student> students = new();
            students.Add(new Student("emil", "pasayev", 20, 200, ab106));
            students.Add(new Student("Garib", "Garibzada", 20, 300, ab106));
            students.Add(new Student("Shahin", "Alizada", 20, 400, ab105));
            students.Add(new Student("samir", "veliyev", 15, 160, ab106));
            students.FindAll(s => s.Group == ab106).ForEach(s => Console.WriteLine(s.Id + "." + s.Name));
            students.FindAll(s => s.Credits < 300).ForEach(s => Console.WriteLine(s.Id + "." + s.Name));
            students.FindAll(s => s == s).ForEach(s => Console.WriteLine(s.Id + "." + s.Name));
            students.FindAll(s => s.Name.ToLower().Contains("b")).ForEach(s => Console.WriteLine($"{s.Name}"));
            students.OrderBy(s => s.Credits).ToList().ForEach(s => Console.WriteLine(s.Name + "" + s.Surname));
            int a = students.Sum(s => s.Credits);
            Console.WriteLine(a);
            Console.WriteLine(students.Any(s => s.Age < 18));
            Console.WriteLine(students.Any(s => s.Credits > 200));
            students.OrderBy(s => s.Group.Name).ToList().ForEach(s => Console.WriteLine(s.Group+" "+s.Name));
        }
    }
}
