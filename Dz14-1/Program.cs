namespace Dz14_1
{
    internal class Program
    {
        //Створіть клас TestClass, у тілі класу реалізуйте метод,
        //який повертає за допомогою ключового слова yield рядок «Hello World!»
        //- 10 разів. У методі Main створіть екземпляр TestClass і
        //через цикл foreach виведіть на екран значення,
        //що зберігаються в екземплярі.
        static void Main(string[] args)
        {
            TestClass n = new TestClass();
            foreach (var i in n.MyMethod())
            {
              Console.WriteLine(i);
            }
            Console.ReadKey();
        }
    }
}
