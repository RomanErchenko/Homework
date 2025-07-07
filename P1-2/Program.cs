namespace P1_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MyCollection<MyClass> myClasses = new MyCollection<MyClass>();
            myClasses.Add(new MyClass(0));
            myClasses.Add(new MyClass(1));
            myClasses.Add(new MyClass(2));
            myClasses.Add(new MyClass(3));
            myClasses.Add(new MyClass(4));
            myClasses.Add(new MyClass(5));
            myClasses.Add(new MyClass(6));
            myClasses.Add(new MyClass(7));
            myClasses.Add(new MyClass(8));
            myClasses.Add(new MyClass(9));

            foreach (var p in myClasses)
            {
                Console.WriteLine(p.Field);
            }
            Console.WriteLine(new string('-', 23));

            foreach (var p in myClasses)
            {
                Console.WriteLine(p.Field);
            }

            Console.ReadKey();
        }
    }
    }

