namespace P1_1
{
    //Создайте класс MyClass, в котором создайте автосвойство типа int.
    //Создайте класс MyCollection<T>, реализующий основной функционал коллекции
    //элементов. При создании MyCollection<T> используйте наследование и
    //реализацию IEnumerable<T>, IEnumerator<T>. В методе Main наполните экземпляр
    //коллекции элементами MyClass, выполните дважды обход этой коллекции
    //с выводом на экран значений автосвойства элементов коллекции.
    public class Program
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
            Console.WriteLine(new string('-',23));

            foreach (var p in myClasses)
            {
                Console.WriteLine(p.Field);
            }

            Console.ReadKey();
        }
    }
}
