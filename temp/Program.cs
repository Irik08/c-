using System;

namespace temp
{
    class Program
    {
        static void Main(string[] args)
        {
            User irik = new User("Irik", 29);
            User dima = new User("Dima", 28);

            bool isIrikOlder = irik > dima;
            Console.WriteLine($"irik is older than dima = {isIrikOlder}");

            irik = null;

            irik?.GetInfo();

            Person irik = new Employee("Irik", "PSB");
            Employee irik2 = new Employee("Irik", "PSB");
            Person danil = new Employee("Danil", "facebook");
            var a = new GenericTest<string>();
            var v = new GenericTest<int>();
            var b = new GenericTest<string>();

            Console.WriteLine(typeof(string));
            Console.WriteLine(typeof(String));


        }
    }

    class GenericTest<T> {
        public static int count;

        public T Id { get; set; }
        
        public GenericTest() {
            count++;
            Console.WriteLine(count);
        }
    }



    class Employee : Person
    {
        public string Company { get; set; }
 
        public Employee(string name, string company)
            : base(name)
        {
            Company = company;
        }

        public override void Display() 
        {
            base.Display();
            Console.WriteLine($" from {Company}");
        }

        public override string ToString()
        {
            return $"{base.ToString()} from {Company}";
        }
    }

    class Person
    {
        public static int count;
        public string Name { get; set; }
 
        public Person(string name)
        {
            count++;
            Name = name;
        }

        public virtual void Display()
        {
            Console.Write(Name);
        }

        public override string ToString()
        {
            return Name;
        }
    }

    public class User 
    {
        public string Name { get; set; }
        public int Age { get; set; }

        public static bool operator > (User first, User second)
        {
            return first.Age > second.Age;
        }

        public static bool operator < (User first, User second)
        {
            return first.Age < second.Age;
        }

        public User(string name, int age)
        {
            Age = age;
            Name = name;     
        }

        public void GetInfo() 
        {
            Console.WriteLine($"I'm {Name}, {Age} years old!");
        }
    } 
}