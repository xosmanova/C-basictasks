//Task1
using System;
namespace OOPTasks
{
    internal class Program
    {
        static void Main(string[] args)
        {
           Student student = new Student();
            student.Name = "Xumar";
            student.Age = 19;
            student.Show();
        }
    }
    public class Student 
    {
        private string _name;
        private int _age;
        public string Name 
        {
            get 
            { 
                return _name;
            }
            set
            {
                if (!string.IsNullOrWhiteSpace(value))
                {
                    _name = value;
                }
                else
                {
                    throw new ArgumentException("Name cannot be null or empty.");
                }
            }
        }
        public int Age 
        {
            get 
            {
                return _age;
            }
            set 
            {
                if (value > 18 && value < 35) 
                {
                    _age = value;
                }
                else 
                {
                    throw new ArgumentException("Age must be between 18 and 35.");
                }
            }
        }
        public void Show() 
        {
            Console.WriteLine($"Name: {Name}, Age: {Age}");
        }
    }
}
//Task2
using System;
namespace OOPTasks
{
    public class Program
    {
        static void Main(string[] args)
        {
                Rectangle rectangle = new Rectangle();
                rectangle.Width = 5;
                rectangle.Height = 10;
                rectangle.Color = "Red";
                Console.WriteLine($"Rectangle: Width={rectangle.Width}, Height={rectangle.Height}, Color={rectangle.Color}, Area={rectangle.Area()}");
              
                Circle circle = new Circle();
                circle.Radius = 7;
                circle.Color = "Blue";
                Console.WriteLine($"Circle: Radius={circle.Radius}, Color={circle.Color}, Area={circle.Area()}"); 
        }
    }
    public class Shape 
    {
        public string Color { get; set; }
    }
    public class Rectangle : Shape
    {
        public double Width { get; set; }
        public double Height { get; set; }
        public double Area()
        {
            return Width * Height;
        }
    }
    public class Circle : Shape
    {
        public double Radius { get; set; }
        public double Area()
        {
            return Math.PI * Radius * Radius;
        }
    }
   
}
//Task3
using System;
namespace OOPTasks
{
    public class Program
    {
        static void Main(string[] args)
        {
            Student student = new Student();
            student.Name = "Xumar";
            student.Age = 19;
            student.Grade = 95.4;

            Teacher teacher = new Teacher();
            teacher.Name = "John";
            teacher.Age = 40;
            teacher.Subject = "Mathematics";

            Principal principal = new Principal();
            principal.Name = "Alice";
            principal.Age = 50;
            principal.YearsOfExperience = 25;

            student.DisplayInfo();

            student.Study();
            Console.WriteLine();
            teacher.DisplayInfo();
            teacher.Teach();
            Console.WriteLine();
            principal.DisplayInfo();
            principal.Manage();

        }
    }
    public class  Person
    {
        private string _name;
        private int _age;
        public string Name
        {
            get { return _name; }
            set 
            {
                if(!string.IsNullOrWhiteSpace(value))
                {
                    _name = value;
                }
                else
                {
                    throw new ArgumentException("Name cannot be empty or whitespace.");
                }
            }
        }
        public int Age
        {
            get { return _age; }
            set 
            {
                if(value >= 0)
                {
                    _age = value;
                }
                else
                {
                    throw new ArgumentException("Age cannot be negative.");
                }
            }
        }
        public virtual void DisplayInfo()
        {
            Console.WriteLine($"Name: {Name}, Age: {Age}");
        }
    }
    public class Student : Person
    {
        public double Grade { get; set; }
        public void Study()
        {
            Console.WriteLine($"{Name} is studying.");
        }
        public override void DisplayInfo()
        {
            Console.WriteLine($"Name: {Name}, Age: {Age}, Grade: {Grade}");
        }
    }
    public class Teacher : Person
    {
        public string Subject { get; set; }
        public void Teach()
        {
            Console.WriteLine($"{Name} is teaching {Subject}.");
        }
        public override void DisplayInfo()
        {
            Console.WriteLine($"Name: {Name}, Age: {Age}, Subject: {Subject}");
        }
    }
    public class Principal : Person
    {
        public int YearsOfExperience { get; set; }
        public void Manage()
        {
            Console.WriteLine($"{Name} is managing the school.");
        }
        public override void DisplayInfo()
        {
            Console.WriteLine($"Name: {Name}, Age: {Age}, Position: Principal");
        }
    }   




}
