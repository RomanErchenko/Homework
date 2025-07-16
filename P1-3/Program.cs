namespace P1_3
{
    internal class Program
    {
        static void Main(string[] args)
        {

            MyCollection<MyClass> myClasses = new MyCollection<MyClass>();
            MyClass m = new MyClass(0);
            MyClass m1 = new MyClass(1);
            MyClass m2 = new MyClass(2);
            MyClass m3 = new MyClass(3);
            MyClass m4 = new MyClass(4);
            MyClass m5 = new MyClass(5);
            MyClass m6 = new MyClass(6);
            MyClass m7 = new MyClass(7);
            MyClass m8 = new MyClass(8);
            MyClass m9 = new MyClass(9);

            myClasses.Add(m);
            myClasses.Add(m1);
            myClasses.Add(m2);
            myClasses.Add(m3);
            myClasses.Add(m4);
            myClasses.Add(m5);
            myClasses.Add(m6);
            myClasses.Add(m7);
            myClasses.Add(m8);
            myClasses.Add(m9);

            foreach (var p in myClasses)
            {
                Console.WriteLine(p.Field);
            }
            Console.WriteLine(new string('-', 23));
            bool z = myClasses.Remove(m5);
            foreach (var p in myClasses)
            {
                Console.WriteLine(p.Field);
            }

            Console.ReadKey();
        }
    }
}
