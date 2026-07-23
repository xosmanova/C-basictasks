// Task1
namespace Indexertask
{
    public class Program
    {
        static void Main(string[] args)
        {
            Student student = new Student();
            student[0] = "Math";
            student[1] = "Science";
            student[2] = "History";
            student[3] = "English";
            student[4] = "Art";
            Console.WriteLine(student[0]);
            Console.WriteLine(student[1]);
            Console.WriteLine(student[2]);
            Console.WriteLine(student[3]);
            Console.WriteLine(student[4]);
        }
    }
    public class Student
    {
        string[] subjects = new string[5];
        public string this[int index]
        {
            get
            {
                return subjects[index];
            }
            set
            {
                subjects[index] = value;
            }
        }
    }
}
//Task2
namespace Indexertask
{
    public class Program
    {
        static void Main(string[] args)
        {
            Numbers num = new Numbers();
            num[0] = 10;
            num[1] = 20;
            num[2] = 30;
            num[3] = 40;
            num[4] = 50;
            num[5] = 60;
            num[6] = 70;
            num[7] = 80;
            num[8] = 90;
            num[9] = 100;
           
            num.Show();
        }
    }
    public class Numbers
    {
        int[] nums = new int[10];
        public int this[int index]
        {
            get
            {
                return nums[index];
            }
            set
            {
                nums[index] = value;
            }
        }
       
        public void Show()
       
        {
            for(int i = 0; i<nums.Length; i++)
            {
                Console.WriteLine(nums[i]);
            }
        }
    }
}
//Task3
namespace Indexertask
{
    public class Program
    {
        static void Main(string[] args)
        {
            StudentList studentList = new StudentList(); 
            studentList[0] = "John";
            studentList[1] = "Alice";
            studentList[2] = "Bob";
            studentList[3] = "Eve";
            studentList[4] = "Charlie";
            Console.WriteLine(studentList[0]);
            Console.WriteLine(studentList[1]);
            Console.WriteLine(studentList[2]);
            Console.WriteLine(studentList[3]);
            Console.WriteLine(studentList[4]);


        }
    }
    public class StudentList
    {
        string[] students = new string[5];
        public string this[int index]
        {
            get
            {
                return students[index];
            }
            set
            {
                students[index] = value;
            }
        }
    }
}
//Task4
namespace Indexertask
{
    public class Program
    {
        static void Main(string[] args)
        {

            RangeArray arr = new RangeArray(-5, 5);
            arr[-5] = 10;
            arr[2] = 50;
            arr[5] = 100;
            Console.WriteLine(arr[-5]); 
            Console.WriteLine(arr[2]);  
            Console.WriteLine(arr[5]);  



        }
    }
    public class RangeArray
    {
        private int[] numbers;
        private int low;
        private int high;
        public RangeArray(int low, int high)
        {
            this.low = low;
            this.high = high;
            numbers = new int[high - low + 1];

        }
        public int this[int index]
        {
            get
            {
                if (index < low || index > high)
                {
                    throw new IndexOutOfRangeException("Index out of range");
                }
                return numbers[index - low];
            }
            set
            {
                if (index < low || index > high)
                {
                    throw new IndexOutOfRangeException("Index out of range");
                }
                numbers[index - low] = value;
            }
        }
    }
}
    

//Task5
namespace Indexertask
{
    public class Program
    {
        static void Main(string[] args)
        {

            BookLibrary library = new BookLibrary();
            library[0] = new Book
            {
                Title = "C# Programming",
                Author = "John Doe",
                Price = 29.99
            };
            library[1] = new Book
            {
                Title = "ASP.NET Core",
                Author = "Jane Smith",
                Price = 39.99
            };
            library[2] = new Book
            {
                Title = "Entity Framework",
                Author = "Mike Johnson",
                Price = 24.99
            };
            Console.WriteLine(library[0].Title);
            Console.WriteLine(library[0].Author);  
            Console.WriteLine(library[0].Price);

            Console.WriteLine();
            Console.WriteLine(library[1].Title);
            Console.WriteLine(library[1].Author);
            Console.WriteLine(library[1].Price);
            Console.WriteLine();

            Console.WriteLine(library[2].Title);
            Console.WriteLine(library[2].Author);
            Console.WriteLine(library[2].Price);





        }
    }
    public class  Book
    {
        public string Title { get; set; }
        public string Author { get; set; }
        public double Price { get; set; }

    }
    public class BookLibrary 
    {
        Book[] books = new Book[3];
        public Book this[int index] 
        {
            get
            {
                return books[index];
            }
            set 
            {
                books[index] = value;
            }
        }

    }

}
    

//Task6
namespace Indexertask
{
    public class Program
    {
        static void Main(string[] args)
        {
            Dictionary dictionary = new Dictionary();
            dictionary["apple"] = "alma";
            dictionary["banana"] = "banán";
            dictionary["car"] = "masina";
            Console.WriteLine(dictionary["apple"]);
            Console.WriteLine(dictionary["banana"]);
            Console.WriteLine(dictionary["car"]);



        }
    }
    public class  Dictionary
    {
        Dictionary<string,string>words = new Dictionary<string,string>();
        public string this[string key] 
        {
            get 
            {
                return words[key];
            }
            set 
            {
                words[key] = value;
            }
        }
    }


}
    

//Task7
namespace Indexertask
{
    public class Program
    {
        static void Main(string[] args)
        {
            Matrix m = new Matrix();
            m[0,0] = 10;
            m[1, 2] = 20;
            m[2, 1] = 30;
            Console.WriteLine(m[0, 0]);
            Console.WriteLine(m[1, 2]);
            Console.WriteLine(m[2, 1]);

        }
    }
    public class  Matrix
    {
        public int[,] matrix = new int[3, 3];
        public int this[int row, int col]
        {
            get 
            {
                return matrix[row, col];
            }
            set 
            {
                matrix[row, col] = value;
            }
        }
    }



}
    

//Task8
namespace Indexertask
{
    public class Program
    {
        static void Main(string[] args)
        {
            Student student = new Student();
            Console.WriteLine(student[0]);
            Console.WriteLine(student[1]);

            Console.WriteLine(student["Math"]);
            Console.WriteLine(student["Science"]);
            student["Math"] = 95;
            Console.WriteLine(student["Math"]);

        }
    }
    public class Student
    {
        string[] names = { "Math", "Science", "History" };
        Dictionary<string, int> grades = new Dictionary<string, int>();
        public Student()
        {
            grades["Math"] = 90;
            grades["Science"] = 85;
            grades["History"] = 95;

        }
        public string this[int index]
        {
            get
            {
                return names[index];
            }
        }
        public int this[string name]
        {
            get
            {
                return grades[name];
            }
            set
            {
                grades[name] = value;
            }
        }
    }

}
    

//Task9
namespace Indexertask
{
    public class Program
    {
        static void Main(string[] args)
        {
            Country country = new Country();
            Console.WriteLine(country[0]);
            Console.WriteLine(country[1]);
        }
    }
    public class Country
    {
        string[] countries =
        {

            "Azerbaijan",
            "Turkey",
            "Germany",
            "Japan",
            "Canada"
        };
        public string this[int index] 
        {
            get
            {
                return countries[index];
            }
        }
        
    }

}
    

//Task10
using System;
namespace Indexertask
{
    public class Program
    {
        static void Main(string[] args)
        {
            Masis array = new Masis();
            array[0] = 10;
            array[1] = 20;
            array[2] = 30;
            Console.WriteLine(array[0]);
            Console.WriteLine(array[1]);
            Console.WriteLine(array[2]);
        }
    }
    public class Masis 
    {
        public int[] numbers = new int[2];
        public int this[int index] 
        {
            get 
            {
                return numbers[index];
            }
            set 
            {
                if (index >= numbers.Length) 
                {
                    Array.Resize(ref numbers, index + 1);
                }
                numbers[index] = value;
            }
        }

        
    }

    

}
    

//Task11
using System;
namespace Indexertask
{
    public class Program
    {
        static void Main(string[] args)
        {
            Student student = new Student();

            student["Math"] = 95;
            student["Physics"] = 88;
            student["History"] = 76;
            student["English"] = 120;

            Console.WriteLine(student["Math"]);
            Console.WriteLine(student["Physics"]);
            Console.WriteLine(student["History"]);

        }
    }
    public class Student
    {
        Dictionary<string, int> grades = new Dictionary<string, int>();
        public int this[string subject]
        {
            get 
            {
                if (grades.ContainsKey(subject))
                    return grades[subject];

                return -1;
            }
            set 
            {
                if (value >= 0 && value <= 100)
                {
                    grades[subject] = value;
                }
                else
                {
                    Console.WriteLine("Qiymet 0 ile 100 arasında olmalıdır.");
                }

            }
        }
    }




}
