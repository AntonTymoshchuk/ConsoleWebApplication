using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace ConsoleWebApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            Student student = new Student() { Id = 0, FirstName = "Anton", LastName = "Tymoshchuk" };
            string serializedStudent = JsonConvert.SerializeObject(student);
            Console.WriteLine(serializedStudent);

            Student student2 = JsonConvert.DeserializeObject<Student>(serializedStudent);
            Console.WriteLine(student2.Id);
            Console.WriteLine(student2.FirstName);
            Console.WriteLine(student2.LastName);
        }
    }

    public class Student
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }
}
